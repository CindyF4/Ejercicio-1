using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conecxion_BD.Properties;
using System.Configuration;

namespace Conecxion_BD.DAL
{
    public class Database
    {

        public static string getStrConnection()
        {
            return Settings.Default.empleadosConnectionString;
        }

        public SqlConnection getConnection()
        {
            SqlConnection Con = new SqlConnection());
            return Con;
        }

    }
}
