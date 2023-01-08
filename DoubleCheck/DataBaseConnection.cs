namespace Singleton.DoubleCheck
{
    public class DataBaseConnection
    {
        private DataBaseConnection(){}

        public static DataBaseConnection Instance { get { return Nested.instance; } }

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly DataBaseConnection instance = new DataBaseConnection();
        }
    }
}