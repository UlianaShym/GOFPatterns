using System;
using System.Collections.Generic;

namespace GofPatternsFun.Creational.Singleton
{
    /// <summary>
    /// Provides only one class instance and only one accsess poit to it.
    /// Private constructor, public method which creates 1 instance(if it doesn't exists) and return it
    /// </summary>
    class Logger
    {
        private List<string> logArchive;
        private static Logger _logger;

        private Logger()
        {
            logArchive = new List<string>();
        }

        public static Logger GetInstance()
        {
            if (_logger == null)
            {
                _logger = new Logger();
            }

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
