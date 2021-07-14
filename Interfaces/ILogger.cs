using Interfaces.Enum;

namespace Interfaces
{
    public interface ILogger
    {
        void LogMessage(MessageType type, string message);
        void ErrorMessage(MessageType type, string message);
    }
}