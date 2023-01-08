using Singleton.LazyClass;

namespace Singleton;
class Program
{
    static void Main(string[] args)
    {
        DataBaseConnection dbInstance = DataBaseConnection.DBInstance;
        DataBaseConnection dbInstance2 = DataBaseConnection.DBInstance;
    }
}
