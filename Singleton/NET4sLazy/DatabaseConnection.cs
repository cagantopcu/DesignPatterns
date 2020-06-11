using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.NET4sLazy
{
    /// <summary>
    /// Using .NET 4's Lazy<T> type
    /// </summary>
    public sealed class DatabaseConnection
    {
        public string ConnectionString => "Data Source=MSSQL1;Initial Catalog=SingletonPatternDB;Integrated Security=true;";
        private DatabaseConnection()
        {
        }
        private static readonly Lazy<DatabaseConnection> lazy = new Lazy<DatabaseConnection>(() => new DatabaseConnection());
        public static DatabaseConnection Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
