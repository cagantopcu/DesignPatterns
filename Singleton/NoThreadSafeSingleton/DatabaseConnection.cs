using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.NoThreadSafeSingleton
{
    /// <summary>
    /// No Thread Safe Singleton
    /// </summary>
    public sealed class DatabaseConnection
    {
        public string ConnectionString => "Data Source=MSSQL1;Initial Catalog=SingletonPatternDB;Integrated Security=true;";


        private DatabaseConnection()
        {
        }
        private static DatabaseConnection instance = null;
        public static DatabaseConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseConnection();
                }
                return instance;
            }
        }
    }
}
