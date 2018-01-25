using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerFactory
{
    public class Logger//Multiple Things / Logging
    {//Req - Logging in TextFile & Excel File
        //New Req - Log in DB & Email (send)

        //Not Following - SRP
        //Not Following - Open closed principle
        //Parallel Development
        //Solved

            //1. Interface / Abstract Class
            //2. Creating Sub-clssses
            //3. Create a Factory method

        public static ILogger GetLog(string logType)//satic Factory Method
        {
            switch (logType)
            {
                case "Text":
                    return new TextLogger();
                case "Excel":
                    return new ExcelLogger();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}