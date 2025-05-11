using System;
using MySql.Data.MySqlClient;

namespace MERCURY_SYSTEM // make sure namespace mo match sa project
{
    public class Connector
    {
        private string connectionString = "server=localhost;user=root;password=mariadb;database=PharmacySystem;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}