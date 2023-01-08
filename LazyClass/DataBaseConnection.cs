namespace Singleton.LazyClass
{
    public sealed class DataBaseConnection
    {        
        private static readonly Lazy<DataBaseConnection>  _dbInstance = 
            new Lazy<DataBaseConnection>(() => new DataBaseConnection());

        public static DataBaseConnection DBInstance {get{return _dbInstance.Value;}}
        
        private DataBaseConnection(){}
    }
}