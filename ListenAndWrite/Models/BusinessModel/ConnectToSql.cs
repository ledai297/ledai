using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace ListenAndWrite.Models.BusinessModel
{
    public class ConnectToSql
    {
        SqlConnection conn;
        public SqlConnection GetSqlConnection()
        {
            string connectionString = "Data Source=DESKTOP-DAIH69A\\SQLEXPRESS;Initial Catalog=ListenAndWrite;User ID=sa;Password=ledai2907";
            conn = new SqlConnection(connectionString);
            return conn;
        }
    }
}