// See https://aka.ms/new-console-template for more information
using static VersatileLoggingSystem.Enums;
using VersatileLoggingSystem;
using VersatileLoggingSystem.ILoggerInterface;

// FACTORY PATTERN - Centralized logger creation
ILogger logger = LoggerFactory.CreateLogger(LoggerType.Console);

// STRATEGY PATTERN - LoggingService uses different strategies (ILogger implementations)
var loggingService = new LoggingService(logger);


//different strategies -
//Console log
loggingService.LogMessage("Hi, this is a log message!");

// File log
ILogger fileLogger = LoggerFactory.CreateLogger(LoggerType.File);
var fileLoggingService = new LoggingService(fileLogger);
fileLoggingService.LogMessage("Logging to a file.");

// InMemeory log
ILogger memoryLogger = LoggerFactory.CreateLogger(LoggerType.Memory);
var memoryLoggingService = new LoggingService(memoryLogger);
memoryLoggingService.LogMessage("Logging to memory.");