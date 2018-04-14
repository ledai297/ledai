using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ListenAndWrite.Models.DataModel;
using System.Data;
using System.Data.SqlClient;
namespace ListenAndWrite.Models.BusinessModel
{
    public class AccountDao
    {
        public Account Login(string email,string password)
        {
            SqlConnection conn = new ConnectToSql().GetSqlConnection();
            conn.Open();
            string queryString = "select * from Account where email=@email and pass=@password";
            SqlCommand command = new SqlCommand(queryString, conn);
            command.Parameters.AddWithValue("email", email);
            command.Parameters.AddWithValue("password", password);
            int result = command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Account account = new Account()
                {
                    AccountID = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    Email=email,
                    Password=password,
                    Birth = reader.GetDateTime(5),
                };
                conn.Close();
                return account;
            }
            return null;
        }

        public bool checkAccount(string email)
        {
            SqlConnection conn = new ConnectToSql().GetSqlConnection();
            conn.Open();
            string queryString = "select * from Account where email=@email";
            SqlCommand command = new SqlCommand(queryString, conn);
            command.Parameters.AddWithValue("email", email);
            int result = command.ExecuteNonQuery();
            if (result > 0)
            {
                return false;
            }
            conn.Close();
            return true;
        }

        public bool SignUp(Account account)
        {
            if (checkAccount(account.Email))
            {
                SqlConnection conn = new ConnectToSql().GetSqlConnection();
                conn.Open();
                string queryString = "insert into Account(FirstName,LastName,Email,Pass) values(@FirstName,@LastName,@Email,@Pass)";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.Parameters.AddWithValue("FirstName", account.FirstName);
                command.Parameters.AddWithValue("LastName", account.LastName);
                command.Parameters.AddWithValue("Email", account.Email);
                command.Parameters.AddWithValue("Pass", account.Password);
                //command.Parameters.AddWithValue("Birth", account.Birth);
                command.ExecuteNonQuery();
                return true;
            }
            return false;
        }
    }
}