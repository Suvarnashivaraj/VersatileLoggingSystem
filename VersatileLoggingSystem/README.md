# VersatileLoggingSystem

This project implements a Versatile Logging System that allows logging messages to multiple outputs:
- Console
- File ( log.txt )
- In-Memory Storage  

It follows 
- Supports multiple logging types (Console, File, In-Memory).  
- Follows SOLID principles for maintainability.  
- Uses Dependency Injection for flexibility (DIP principles).  
- Implemented with Factory & Strategy patterns for extensibility.  
- Unit tests included using Xunit.
- Well-organized, clear, and adheres to the KISS and DRY principles, and comments
---

## Design Patterns & Principles Used
1. Factory Pattern
Used to create logger instances dynamically based on the desired logging type.  
- Implemented in the LoggerFactory class.  

2. Strategy Pattern
Encapsulates different logging behaviors as separate classes to allow dynamic selection of the logging strategy.  
- Implemented through the ILogger interface and its implementations in ConsoleLogger, FileLogger, and InMemoryLogger classes.  

3. SOLID Principles Applied
- Single Responsibility: Each class handles only one concern (ex-, logging classes, strategy, factory).  
- Open/Closed: Easily extendable by adding new loggers without modifying existing code.  
- Liskov Substitution: ILogger implementations can be used interchangeably.  
- Interface Segregation: ILogger defines only the Log method, keeping it minimal.  
- Dependency Inversion: ILogger is injected via Dependency Injection.  

---
## How to Run
Prerequisites-
.NET 6 or later installed in VS2022.

Steps-
1. Clone this repository:
   git clone https://github.com/Suvarnashivaraj/VersatileLoggingSystem.git 
2. Build and run the solution
3. Result logs will be found in the console file, in-memory, log.txt(in the solution folder- bin/Debug/net6.0(or net8.0, whichever you used).