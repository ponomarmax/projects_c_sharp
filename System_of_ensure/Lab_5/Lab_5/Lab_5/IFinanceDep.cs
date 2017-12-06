using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Lab_5
{
    [ServiceContract]
    public interface IFinanceDep
    {
        /// <summary>
        /// Проверяет есть ли финансы для страхования
        /// </summary>
        /// <param name="insuranceSum">Сумма страховки на которую расчитывает клиент</param>
        /// <returns>Рузльтат проверки наявности финансов</returns>
        [OperationContract]
        bool CheckFinance(decimal insuranceSum);

        /// <summary>
        /// Посчитать сумму, которую клиент должен заплатить, для получения страховки
        /// </summary>
        /// <param name="insurance">Страховой бланк, который включает сумму страховки, группу риска, начальную и конечную даты</param>
        /// <returns>Сумму которую должен заплатить клиент</returns>
        [OperationContract]
        decimal DetermineCostOfInsurance(Insurance insurance);
    }

    public enum RiskGroupType { P1 = 1, P2, P3, P4 };

    [DataContract]
    public class Insurance
    {
        RiskGroupType riskGrup;
        decimal insuranceSum;
        DateTime startDate;
        DateTime endDate;

        [DataMember]
        public RiskGroupType RiskGrup
        {
            get { return riskGrup; }
            set { riskGrup = value; }
        }

        [DataMember]
        public decimal InsuranceSum
        {
            get { return insuranceSum; }
            set { insuranceSum = value; }
        }

        [DataMember]
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        [DataMember]
        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
    }
}
