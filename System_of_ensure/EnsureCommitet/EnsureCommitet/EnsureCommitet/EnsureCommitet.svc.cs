using EnsureCommitet.ScammersDB;
using EnsureCommitet.FinanceDep;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;

namespace EnsureCommitet
{
    public class Service1 : IEnsureCommitet
    {
        public int Request(string id, int amount)//receive request fom Agent
        {
            WriteLog("Request", new string[] { id, amount.ToString() });
            //return true && Enought_Money(amount);
            if (Is_Crime(id))
            {
                return 1;
            }
            if (!Enought_Money(amount))
            {
                return 2;
            }
            return 0;
        }
        public bool Is_Crime(string passport)
        {
            try
            {
                Regex regex = new Regex(@"^[А-Яа-я]{2}\d{6}$");
                ScammersDBClient crime = new ScammersDBClient();
                WriteLog("Is_Not_Crime", new string[] { passport });
                if (!regex.IsMatch(passport))
                {
                    //is the passport number has correct format
                    throw new FaultException("Incorrect parameter format. Use format like AA000000. Letters must be Cyrillic");
                }
                    return crime.CheckUser(passport); // is  crime
            }
            catch (FaultException e)
            {
                WriteLog("Is_Not_Crime", new string[] { "Error occured" + e.Message});
                return false;
            }
        }
        public bool Enought_Money(int amount)
        {
            try
            {
                FinanceDepClient fd = new FinanceDepClient();
                WriteLog("Enought_Money", new string[] { amount.ToString() });
                if (amount < 1000) throw new FaultException("Too small amount of money");
                return fd.CheckFinance(amount);//enought money
            }
            catch (FaultException e)
            {
                WriteLog("Enought_Money", new string[] { "Error occured" + e.Message });
                return false;
            }
        }

        private void WriteLog(string methodName, string[] parameters)//method for logging
        {
            string filePath = @"F:\ipz\EnsureCommitet\log.txt";
            string content = "* " + DateTime.Now + " ***\r\n" + methodName + " was called with params: ";
            foreach (string param in parameters)
                content += param + " ";
            content += "\r\n\r\n";
            File.AppendAllText(filePath, content, Encoding.UTF8);
        }
    }
    }
