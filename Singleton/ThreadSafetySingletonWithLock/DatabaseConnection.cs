using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.ThreadSafetySingletonWithLock
{
    /// <summary>
    /// Thread Safety Singleton using Double Check Locking
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
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new DatabaseConnection();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
