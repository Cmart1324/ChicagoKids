using System;
using System.Data.OleDb;
using System.IO;


namespace DataLayer
{
    public class DataL
    {

        private string _loginConnection;

        private void GetPath()
        {
            string[] subDirectories = Directory.GetDirectories(Directory.GetCurrentDirectory());
            string path;
            bool found = false;

            try
            {
                path = Directory.GetCurrentDirectory();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                throw;
            }

            try
            {
                while (!found)
                {
                    foreach (var element in subDirectories)
                    {
                        if (!element.Contains("App_Data")) continue;
                        found = true;
                        path = element + "\\App_Data";
                    }
                    if (!found)
                    {
                        path = Directory.GetParent(path).ToString();
                        subDirectories = Directory.GetDirectories(path);
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                throw;
            }

            _loginConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "\\loginDB.accdb";
        }

        public string[] CheckLogin(string theUserName)
        {

            string queryString = "SELECT userName, password FROM logins WHERE userName = @UserName";
            string[] userInfo = new string[2];

            GetPath();
            using (OleDbConnection lConnection = new OleDbConnection(_loginConnection))
            {
                OleDbCommand login = new OleDbCommand(queryString, lConnection);
                login.Parameters.AddWithValue("@UserName", theUserName);

                lConnection.Open();
                OleDbDataReader loginInfo = login.ExecuteReader();

                while (loginInfo != null && loginInfo.Read())
                {
                    userInfo[0] = loginInfo.GetString(0);
                    userInfo[1] = loginInfo.GetString(1);
                }

                lConnection.Close();
            }
            return userInfo;
        }

        public void AddUserLogin(string[] theUserLogin)
        {
            string queryString = "INSERT INTO logins (userName, password) values (@UserName, @Password)";
            using (OleDbConnection lConnection = new OleDbConnection(_loginConnection))
            {
                OleDbCommand login = new OleDbCommand(queryString, lConnection);
                login.Parameters.AddWithValue("@UserName", theUserLogin[0]);
                login.Parameters.AddWithValue("@Password", theUserLogin[1]);

                lConnection.Open();
                login.ExecuteNonQuery();
                lConnection.Close();
            }
        }

        public void RemoveUserLogin(string theUserName)
        {
            string queryString = "DELETE FROM logins where userName = @UserName";
            using (OleDbConnection lConnection = new OleDbConnection(_loginConnection))
            {
                OleDbCommand login = new OleDbCommand(queryString, lConnection);
                login.Parameters.AddWithValue("@UserName", theUserName);

                lConnection.Open();
                login.ExecuteNonQuery();
                lConnection.Close();
            }
        }

        public void UpdateUserLogin(string[] theUserLogin)
        {
            const string queryString = "UPDATE logins SET password = @Password WHERE userName = @UserName";

            using (OleDbConnection lConnection = new OleDbConnection(_loginConnection))
            {
                OleDbCommand login = new OleDbCommand(queryString, lConnection);
                login.Parameters.AddWithValue("@Password", theUserLogin[1]);
                login.Parameters.AddWithValue("@UserName", theUserLogin[0]);

                lConnection.Open();
                login.ExecuteNonQuery();
                lConnection.Close();
            }
        }
    }
}
