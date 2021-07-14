using Interfaces.Enum;

namespace Interfaces
{
    public class DbBuilder
    {
        private readonly ILogger _logger;
        private readonly string _dbName;

        public DbBuilder(string dbname, ILogger logger)
        {
            _dbName = dbname;
            _logger = logger;
        }

        public void Create()
        {
            if (_dbName == "csn_dba")
                _logger.LogMessage(MessageType.LogMessage, "Creating DB " + _dbName);
            else
                _logger.ErrorMessage(MessageType.ErrorMessage, "Failed to create db " + _dbName);
        }
    }
}