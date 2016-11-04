using System;
using System.Collections.Generic;

namespace GofPatternsFun.Creational
{
    class Logger2
    {
        private readonly List<string> logArchive;
        private static readonly Logger2 _logger = new Logger2();

        private Logger2()
        {
            logArchive = new List<string>();
        }

        public static Logger2 GetInstance()
        {
            return _logger;
        }

        public void AddLog(string message)
        {
            logArchive.Add(message);
        }

        public void PrintAllLogs()
        {
            foreach (var log in logArchive)
            {
                Console.WriteLine(log);
            }
        }
    }
}
