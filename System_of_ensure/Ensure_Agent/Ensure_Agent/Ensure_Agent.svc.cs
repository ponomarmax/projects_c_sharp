using Ensure_Agent.FinanceDep;
using Ensure_Agent.EnsureCommitet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Ensure_Agent
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IEnsure_Agent
    {
        Regex regex = new Regex(@"^[А-Яа-я]{2}\d{6}$");
        int code = 0;//0 -ok 1-жулік 2-нема грошей
        FinanceDepClient claim_to_finance;
        EnsureCommitetClient claim_to_commitet;
        RiskGroupType group_risk;

        public string AddClaim(int sum_of_ensure, DateTime start_data, DateTime end_data, int group, string passport, out decimal cost)
        {
            if (!regex.IsMatch(passport))
                throw new FaultException("Your passport isn't match to pattern");
            
            if (group > 4 || group < 1) //range group [1,2]
                throw new FaultException("Risk group must have value P1, P2, P3 or P4");
            cost = 0; //initializating
            WriteLog("AddClaim", new string[] { sum_of_ensure.ToString(), start_data.ToString(), end_data.ToString(), group.ToString(), passport });

            claim_to_commitet = new EnsureCommitetClient();
            try
            {
                code = claim_to_commitet.Request(passport, sum_of_ensure);
                switch (code)
                {
                    case 0://all is ok
                        claim_to_finance = new FinanceDepClient();
                        group_risk = RiskGroupType.P1;
                        switch (group)
                        {
                            case 1:
                                group_risk = RiskGroupType.P1;
                                break;
                            case 2:
                                group_risk = RiskGroupType.P2;
                                break;
                            case 3:
                                group_risk = RiskGroupType.P3;
                                break;
                            case 4:
                                group_risk = RiskGroupType.P4;
                                break;
                        }
                        Insurance insurance = new Insurance
                        {
                            RiskGrup = group_risk,
                            InsuranceSum = sum_of_ensure,
                            StartDate = start_data,
                            EndDate = end_data
                        };
                        cost = claim_to_finance.DetermineCostOfInsurance(insurance);
                        return "Insurance is ok";
                    case 1:
                        return "Жулік";
                    case 2:
                        return "Нема грошей";
                }
            }
            catch (FaultException e)
            {
                WriteLog("AddClaim Error",new string[] { e.Message });
            }
            return "";
        }
        private void WriteLog(string methodName, string[] parameters)
        {
            string filePath = @"E:\3_1\ІПЗ\Ensure_Agent\log.txt";
            string content = "* " + DateTime.Now + " ***\r\n" + methodName + " was called with params: ";
            foreach (string param in parameters)
                content += param + " ";
            content += "\r\n\r\n";
            File.AppendAllText(filePath, content, Encoding.UTF8);
        }
    }
}
