using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Data
{
    internal class DatabaseConn
    {
        public static MySqlConnection GetConnection()
        {
            var connString = ConfigurationManager.ConnectionStrings["CompanySalesDb"].ConnectionString;

            return new MySqlConnection(connString);
        }
    }
}
