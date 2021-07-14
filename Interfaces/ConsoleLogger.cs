using System;
using Interfaces.Enum;

namespace Interfaces
{
    public class ConsoleLogger : ILogger
    {
        public void LogMessage(MessageType type, string message)
        {
            Console.WriteLine("{0}: {1}", MessageType.LogMessage, message );
        }

        public void ErrorMessage(MessageType type, string message)
        {
            Console.WriteLine("{0}: {1}", MessageType.ErrorMessage, message);
        }
    }
}