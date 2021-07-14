using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var useFileLogger = new DbBuilder("my_database", new FileLogger());
            var useConsoleLogger = new DbBuilder("my_database", new ConsoleLogger());
            
            useFileLogger.Create();
            useConsoleLogger.Create();
        }
    }
}
