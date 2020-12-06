
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public class Teacher
    {
        string name;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        bool isAuthenticated = false;

        public bool IsAuthenticated
        {
            get { return isAuthenticated; }
            set { isAuthenticated = value; }
        }

        public Teacher()
        {

        }
        public Teacher(string username,string password)
        {
            this.username = username;
            this.password = password;

        }
        public Teacher(string name, string username, string password, string email):this(username,password)
        {
            this.email = email;
            this.name = name;
        }
        
        public bool Authenticate()
        {
            bool flag = false;
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString =ConfigurationManager.AppSettings["paperConnectionString"];
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select name,email from teacher where username='"+this.username+"' and password='"+this.password+"'";
            try
            {
                conn.Open();
                MySqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    this.name = sdr[0].ToString();
                    this.email = sdr[1].ToString();
                    flag = true;
                    this.isAuthenticated = true;
                }
                //int count = (int)cmd.ExecuteScalar();
                sdr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }

    }
}
