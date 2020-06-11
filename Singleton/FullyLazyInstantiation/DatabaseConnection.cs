using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.FullyLazyInstantiation
{
    /// <summary>
    /// Fully lazy instantiation
    /// </summary>
    public sealed class DatabaseConnection
    {
        public string ConnectionString => "Data Source=MSSQL1;Initial Catalog=SingletonPatternDB;Integrated Security=true;";

        private DatabaseConnection()
        {
        }

        public static DatabaseConnection Instance => Nested.instance;

        private class Nested
        {
            static Nested()
            {
            }

            internal static readonly DatabaseConnection instance = new DatabaseConnection();
        }
    }
}
