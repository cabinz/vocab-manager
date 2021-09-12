using ManagerLibrary.DataAccess;
using System.Configuration;

namespace ManagerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitConnection()
        {
            // The method is scalable for potential extra storage to connect.
            // Add new connection by simply adding parameters 
            // and making Connection a list storing all the connections.
            //Connection = new SqlConnector();
            Connection = new SqliteConnector();
        }

        public static string ConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
