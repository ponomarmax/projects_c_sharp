using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Lab_5
{
    public class FinanceDep : IFinanceDep
    {
        Random rand = new Random();

        public bool CheckFinance(decimal insuranceSum)
        {
            string parameter = "insuranceSum is " + insuranceSum;
            if (insuranceSum <= 0)
            {
                string message = "Сума менше або рівна нулю";
                WriteLog(parameter, "error, message is \"" + message + "\"");
                throw new FaultException(message);
            }
            WriteLog(parameter, "complited succesfull");
            return rand.Next((int) insuranceSum) > insuranceSum / 20;
        }

        public decimal DetermineCostOfInsurance(Insurance insurance)
        {
            string parameters = "insuranceSum is " + insurance.InsuranceSum + "; riskGrup is " + insurance.RiskGrup
                + "; startDate is " + insurance.StartDate.ToString("d") + "; endDate is " + insurance.EndDate.ToString("d");

            if (insurance.InsuranceSum <= 0)
            {
                string message = "Сума менше або рівна нулю";
                WriteLog(parameters, "error, message is \"" + message + "\"");
                throw new FaultException(message);
            }

            int amountOfDays;
            if (insurance.EndDate.Year > insurance.StartDate.Year)
                amountOfDays = (insurance.EndDate.Year - insurance.StartDate.Year) * 365
                    - insurance.StartDate.DayOfYear + insurance.EndDate.DayOfYear; //В высокосном году у нас СКИДКААААААА)))
            else if (insurance.EndDate.Year == insurance.StartDate.Year && insurance.EndDate.DayOfYear > insurance.StartDate.DayOfYear)
                amountOfDays = insurance.EndDate.DayOfYear - insurance.StartDate.DayOfYear;
            else
            {
                string message = "Не правильна дата!!!";
                WriteLog(parameters, "error, message is \"" + message + "\"");
                throw new FaultException(message);
            }

            WriteLog(parameters, "complited succesfull");
            return insurance.InsuranceSum * (int)insurance.RiskGrup * amountOfDays / 5000; //дробь на 5 с коэфициента группы риска, и на 1000 делится количество дней
        }

        void WriteLog(string parameters, string result)
        {
            using (StreamWriter file = new StreamWriter(@"D:\USERS\Rodion\Рабочий стол\Лекции\5-й семестр\Інженерія програмного забезпечення\Labs\Lab_5\Lab5.txt", true))
            {
                file.WriteLine("--------------New request " + DateTime.Now.ToString() + "--------------");
                file.WriteLine("Parameters: " + parameters + "; Result: " + result + "\r\n");
            }
        }
    }
}
