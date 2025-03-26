using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VersatileLoggingSystem.ILoggerInterface;

namespace VersatileLoggingSystem
{
    /* SOLID - Dependency Inversion Principle
      LoggingService depends on ILogger abstraction, not a concrete class  - strategy pattern. */

    /// <summary>
    /// Logging service helps not to depend on concrete implementations.
    /// </summary>
    public class LoggingService
    {        
        private readonly ILogger _logger;

        // Dependency Injection ensures loose coupling
        public LoggingService(ILogger logger)
        {
            _logger = logger;
        }
        public void LogMessage(string message)
        {
            _logger.Log(message);  // Executes the strategy (logging behavior)
        }
    }
}
