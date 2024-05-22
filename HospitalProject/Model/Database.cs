using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Model
{
    public static class Database
    {
        static string connectionString = @"Server = .\SQLEXPRESS; DATABASE = HospitalDB;Integrated Security = True";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
