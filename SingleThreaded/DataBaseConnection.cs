namespace Singleton.SingleThreaded
{
    public class DataBaseConnection
    {
        private static DataBaseConnection _dbInstance = null;

        private DataBaseConnection(){}

        public static DataBaseConnection CreateDBInstance()
        {
            if(_dbInstance == null)
                _dbInstance = new DataBaseConnection();
            return _dbInstance;
        }
    }
}