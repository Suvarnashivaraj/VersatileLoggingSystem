using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VersatileLoggingSystem.ILoggerInterface;

namespace VersatileLoggingSystem.LogClasses
{
    /// <summary>
    /// Logs messages to an in-memory store.
    /// </summary>
    public class InMemoryLogger : ILogger
    {
        /// <summary>
        /// Lists all inmemory logs.
        /// </summary>
        private readonly List<string> _logs = new List<string>();

        /// <summary>
        /// Log method of the ILogger interface, common method which can be reused and explains Openclosed Principle.
        /// </summary>
        /// <param name="message"></param>
        public void Log(string message)
        {
            _logs.Add($"{message}");
        }
        /// <summary>
        /// Fetch and holds all logs without altering 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetLogs() => _logs;
    }
}
