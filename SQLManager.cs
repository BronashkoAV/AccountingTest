using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace AccountingTest
{
    static class SQLManager
    {
        private static SqlConnection _sqlConnection = null;

        public static SqlConnection SqlConnection
        {
            get
            {
                if (_sqlConnection == null)
                {
                    _sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
                    _sqlConnection.Open();
                }
                return _sqlConnection;
            }
        }
    }
}
