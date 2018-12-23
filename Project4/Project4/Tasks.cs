using System;
using System.Data.SqlClient;
using System.Configuration;

namespace Project4
{
    class Tasks
    {
        /// <summary>
        /// Connection string to Northwind database
        /// </summary>
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString"].ConnectionString;

        /// <summary>
        /// Represents a unique session to a SQL Server data source.
        /// </summary>
        private SqlConnection connection;

        /// <summary>
        /// Allows to query and send commands to a database
        /// </summary>
        private SqlCommand command;

        /// <summary>
        /// Is used to read data from a data source
        /// </summary>
        private SqlDataReader reader;
    }
}
