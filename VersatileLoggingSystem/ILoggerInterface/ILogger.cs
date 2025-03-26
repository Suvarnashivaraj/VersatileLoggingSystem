using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersatileLoggingSystem.ILoggerInterface
{

    /* SOLID principle used- Interface Segregation Principle and Dependency Inversion Principle
    Defines a common interface that all loggers must implement.
    Ensures LoggingService depends on an abstraction (ILogger), not concrete implementations. */

    /// <summary>
    /// Common interface that all loggers must implement.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Helps when needed to Extend or the easy addition of new logger types in the future.
        /// </summary>
        /// <param name="message"></param>
        void Log(string message);
    }
}
