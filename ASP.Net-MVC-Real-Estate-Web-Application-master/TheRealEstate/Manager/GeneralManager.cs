using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace TheReaLState.Manager
{
    public class GeneralManager
    {
        public static string ConString = @"Data Source=desktop-6e92den;Initial Catalog=Practice;Integrated Security=True";
        public static SqlConnection Con = new SqlConnection(ConString);

    }
}