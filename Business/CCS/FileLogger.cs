using System;
using System.Collections.Generic;
using System.Text;

namespace Business.CCS
{
    public class Logger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Dosya loglandı");
        }
    }
}
