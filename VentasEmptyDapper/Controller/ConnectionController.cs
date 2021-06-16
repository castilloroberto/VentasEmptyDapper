using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace VentasEmptyDapper.Controller
{
    public class ConnectionController
    {
        protected SqlConnection Connection => new SqlConnection(GetString);
        private string GetString => ConfigurationManager.ConnectionStrings["roberto"].ConnectionString;
    }
}
