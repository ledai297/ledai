using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using ListenAndWrite.Models.DataModel;
namespace ListenAndWrite.Models.BusinessModel
{
    public class LevelDao
    {
        public List<Levels> GetAllLevel()
        {
            List<Levels> ListLevels = new List<Levels>();
            string QueryString = "select * from Levels";
            SqlConnection conn = new ConnectToSql().GetSqlConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(QueryString, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int LevelID = reader.GetInt32(0);
                string LevelName = reader.GetString(1);
                Levels level = new Levels()
                {
                    LevelID = LevelID,
                    LevelName = LevelName,
                };
                ListLevels.Add(level);
                
            }
            conn.Close();
            return ListLevels;
        }
    }
}