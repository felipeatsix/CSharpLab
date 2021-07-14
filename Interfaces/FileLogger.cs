using System.IO;
using Interfaces.Enum;

namespace Interfaces
{
    public class FileLogger : ILogger
    {
        public void LogMessage(MessageType type, string message)
        {
            using (var sw = new StreamWriter(@"c:\users\felip\desktop\log.txt"))
            {
                sw.WriteLine("{0}: {1}", MessageType.LogMessage, message);
            }
        }

        public void ErrorMessage(MessageType type, string message)
        {
            using (var sw = new StreamWriter(@"c:\users\felip\desktop\errorLog.txt"))
            {
                sw.WriteLine("{0}: {1}", MessageType.ErrorMessage, message);
            }
        }
    }
}