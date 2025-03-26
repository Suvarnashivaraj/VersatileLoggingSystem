using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VersatileLoggingSystem.ILoggerInterface;
using VersatileLoggingSystem.LogClasses;
using static VersatileLoggingSystem.Enums;

namespace VersatileLoggingSystem
{
    /// <summary>
    /// Responsible for creating ILogger instance based on input. - FACTORY PATTERN 
    /// </summary>
    public static class LoggerFactory
    {
        /// <summary>
        ///  Centralized object creation for loggers.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static ILogger CreateLogger(LoggerType type)
        {
            return type switch
            {
                LoggerType.Console => new ConsoleLogger(),  // Creates ConsoleLogger instance
                LoggerType.File => new FileLogger(),        // Creates FileLogger instance
                LoggerType.Memory => new InMemoryLogger(),    // Creates InMemoryLogger instance
                _ => throw new ArgumentException("Invalid logger type"),
            };
        }
    }
}
