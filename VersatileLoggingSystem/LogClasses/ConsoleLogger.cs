using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VersatileLoggingSystem.ILoggerInterface;

namespace VersatileLoggingSystem.LogClasses
{
    /* SOLID - Single responsibility principle
     Used strategy pattern - different concrete logging class */

    /// <summary>
    /// Logs messages to the Console.
    /// </summary>
    public class ConsoleLogger : ILogger
    {
        /// <summary>
        /// Log method of the ILogger interface, common method which can be reused and explains Openclosed Principle.
        /// </summary>
        /// <param name="message"></param>
        public void Log(string message)
        {
            Console.WriteLine($"{message}");
        }
    }
}
