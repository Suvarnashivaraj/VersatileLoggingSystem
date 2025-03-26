using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VersatileLoggingSystem.LogClasses;
using Xunit;

namespace VersatileLoggingSystem
{
    /// <summary>
    /// All tests for logging classes
    /// </summary>
    public class LoggingTests
    {
        /// <summary>
        /// Test for check console log
        /// </summary>
        [Fact]
        public void ConsoleLogger_Should_Log_Message()
        {
            var logger = new ConsoleLogger();
            logger.Log("Test message"); // This will print to console
        }

        /// <summary>
        /// Test for check file logging
        /// </summary>
        [Fact]
        public void FileLogger_Should_Log_To_File()
        {
            var logger = new FileLogger();
            logger.Log("File test log");

            // Check if the file contains the log message
            string logContent = System.IO.File.ReadAllText("log.txt");
            Assert.Contains("File test log", logContent);
        }

        /// <summary>
        /// Test for check InMemory logging
        /// </summary>
        [Fact]
        public void InMemoryLogger_Should_Store_Messages_InMemory()
        {
            var logger = new InMemoryLogger();
            logger.Log("Memory log test");

            var logs = logger.GetLogs();
            Assert.Contains("Memory log test", logs);
        }
    }
}
