using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.ThreadSafetySingleton
{
    /// <summary>
    /// Thread Safety Singleton
    /// </summary>
    public sealed class DatabaseConnection
    {
        public string ConnectionString => "Data Source=MSSQL1;Initial Catalog=SingletonPatternDB;Integrated Security=true;";

        DatabaseConnection()
        {
        }

        private static readonly object padlock = new object();

        private static DatabaseConnection instance = null;

        public static DatabaseConnection Instance
        {
            get
            {
                lock (padlock)
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
}
