using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerFactory
{
    class Program
    {
        static void Main(string[] args)
        {//Client
            ILogger log = Logger.GetLog("Text");//dynamically - configuration - any other way
            log.Log();

            Console.ReadLine();
        }
    }
}