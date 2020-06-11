using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.ThreadSafetySingletonWithoutLock
{
    /// <summary>
    /// Thread Safe Singleton without using locks and no lazy instantiation
    /// </summary>
    public sealed class DatabaseConnection
    {
        public string ConnectionString => "Data Source=MSSQL1;Initial Catalog=SingletonPatternDB;Integrated Security=true;";

        private static readonly DatabaseConnection instance = new DatabaseConnection();

        static DatabaseConnection()
        {
        }

        private DatabaseConnection()
        {
        }

        public static DatabaseConnection Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
