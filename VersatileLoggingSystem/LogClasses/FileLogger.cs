using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VersatileLoggingSystem.ILoggerInterface;

namespace VersatileLoggingSystem.LogClasses
{
    /// <summary>
    /// Logs messages to a file. 
    /// </summary>
    public class FileLogger : ILogger
    {
        /// <summary>
        /// A path to ensure the file is created in a specific location
        /// </summary>
        private readonly string _filePath = "log.txt";

        /// <summary>
        /// Log method of the ILogger interface, common method which can be reused and explains Openclosed Principle.
        /// </summary>
        /// <param name="message"></param>
        public void Log(string message)
        {
            File.AppendAllText(_filePath, $"{message}{Environment.NewLine}");
        }
    }
}
