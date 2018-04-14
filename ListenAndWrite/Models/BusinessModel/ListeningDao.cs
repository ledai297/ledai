using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ListenAndWrite.Models.DataModel;
using System.Data;
using System.Data.SqlClient;

namespace ListenAndWrite.Models.BusinessModel
{
    public class ListeningDao
    {

        
        public Listening GetListeningByID(int ListeningID)
        {
            SqlConnection conn = new ConnectToSql().GetSqlConnection();
            conn.Open();
            string queryString = "select * from Listening where ListeningID = @ListeningID";
            SqlCommand command = new SqlCommand(queryString, conn);
            command.Parameters.AddWithValue("ListeningID", ListeningID);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Listening listening = new Listening()
                {
                    LevelID = reader.GetInt32(1),
                    ListeningID = ListeningID,
                    Tittle = reader.GetString(2),
                    Solution = reader.GetString(3),
                    Url = reader.GetString(4),


                };
                return listening;
            }
            conn.Close();
            return null;
        }
        public List<Levels> GetAllLevels()
        {
            List<Levels> levels = new List<Levels>();
            SqlConnection conn = new ConnectToSql().GetSqlConnection();
            conn.Open();
            string queryString = "select * from Levels ";
            SqlCommand command = new SqlCommand(queryString, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Levels level = new Levels() {
                    LevelID = reader.GetInt32(0),
                    LevelName = reader.GetString(1),
                    
                };
                levels.Add(level);

            }
            return levels;
        }

        public List<Listening> GetListeningByLevelName(string LevelID)
        {
            SqlConnection conn = new ConnectToSql().GetSqlConnection();
            conn.Open();
            string queryString = "select * from Listening where LevelID=@LevelID";
            SqlCommand command = new SqlCommand(queryString, conn);
            command.Parameters.AddWithValue("LevelID", LevelID);
            List<Listening> listListening = new List<Listening>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Listening listening = new Listening()
                {
                    ListeningID = reader.GetInt32(0),
                    Tittle = reader.GetString(2),
                    Solution = reader.GetString(3),
                    Url = reader.GetString(4),
                };
                listListening.Add(listening);
            }
            conn.Close();
            return listListening;
        }

        public List<Listening> GetListeningByLevelID(int levelID)
        {
            SqlConnection conn = new ConnectToSql().GetSqlConnection();
            conn.Open();
            string queryString = "select * from Listening where LevelID=@LevelID";
            SqlCommand command = new SqlCommand(queryString, conn);
            command.Parameters.AddWithValue("LevelID",levelID);
            List<Listening> listListening = new List<Listening>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Listening listening = new Listening()
                {
                    ListeningID = reader.GetInt32(0),
                    LevelID = levelID,
                    Tittle = reader.GetString(2),
                    Solution=reader.GetString(3),
                    Url=reader.GetString(4),
                };
                listListening.Add(listening);
            }
            conn.Close();
            return listListening;
        }
        public Listening GetListeningByTitle(string title)
        {
            SqlConnection conn = new ConnectToSql().GetSqlConnection();
            conn.Open();
            string queryString = "select * from Listening where Title=@Title";
            SqlCommand command = new SqlCommand(queryString, conn);
            command.Parameters.AddWithValue("Title", title);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Listening listening = new Listening()
                {
                    LevelID = reader.GetInt32(0),
                    Tittle = title,
                    Solution  =reader.GetString(3),
                    Url = reader.GetString(4),
                };
                return listening;
                
            }
            return null;
        }
    }
}