using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.ServiceModel;

namespace lab5
{
    public class ScammersDB : IScammersDB
    {
        Regex regex = new Regex(@"^[А-Яа-я]{2}\d{6}$");
        Random DB = new Random();
        
        public bool CheckUser(string SeriesAndNumberPassport)
        {
            bool Scrammer;
            if (!regex.IsMatch(SeriesAndNumberPassport)) //проверка на соответствие параметра формату 
            {
                WriteLog("CheckUser", new string[] { SeriesAndNumberPassport }, "Incorrect parameter format");
                throw new FaultException("Incorrect parameter format. Use format like AA000000. Letters must be Cyrillic");
            }
            Scrammer = CheckInDB(SeriesAndNumberPassport);
            WriteLog("CheckUser", new string[] { SeriesAndNumberPassport }, Scrammer.ToString());
            return Scrammer;
        }

        private bool CheckInDB(string user)
        {
            //сложные запросы к базе данных    
            return (DB.Next(100) > 90);
        }
        private void WriteLog(string methodName, string[] parameters, string result)
        {
            string filePath = @"D:\SoftDev\Labs\lab5\log.txt";
            string content = "*** " + DateTime.Now + " ***\r\n" + methodName + " was called with params: ";
            foreach (string param in parameters)
                content += param + " ";
            content += "\r\nResult: " + result;
            content += "\r\n\r\n";
            File.AppendAllText(filePath, content, Encoding.UTF8);
        }
    }
}
