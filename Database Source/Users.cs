using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using transport_manager.Models;

namespace transport_manager.Database_Source
{
    static internal class Users
    {
        static MySqlConnection db = new MySqlConnection(ConnectionSettings.MySqlConnectionSettings);

        static public void openConnection()
        {
            if (db.State == System.Data.ConnectionState.Closed)
            {
                db.Open();
            }
        }

        static public void closeConnection()
        {
            if (db.State == System.Data.ConnectionState.Open)
            {
                db.Close();
            }
        }

        static public int getRole(String Login, String Password)
        {
            openConnection();

            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @uLogin AND `Password` = @uPassword;", db);
            var table = new DataTable();

            command.Parameters.Add("@uLogin", MySqlDbType.VarChar).Value = Login;
            command.Parameters.Add("@uPassword", MySqlDbType.VarChar).Value = Password;
            
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count != 1) return -1;

            closeConnection();

            return (int)table.Rows[0]["Role"];
        }

        static public void eraseByLogin(string Login)
        {
            openConnection();
            var command = new MySqlCommand("DELETE FROM `users` WHERE `Login` = @uLogin;", db);

            command.Parameters.Add("@uLogin", MySqlDbType.VarChar).Value = Login;
            command.ExecuteNonQuery();

            closeConnection();
        }

        static public string getPass(String Login)
        {
            openConnection();

            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @uLogin", db);
            var table = new DataTable();

            command.Parameters.Add("@uLogin", MySqlDbType.VarChar).Value = Login;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            closeConnection();

            return (string)table.Rows[0]["Password"];
        }

        static public bool isExists(String Login)
        {
            openConnection();

            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @uLogin", db);
            var table = new DataTable();

            command.Parameters.Add("@uLogin", MySqlDbType.VarChar).Value = Login;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            closeConnection();

            return table.Rows.Count != 0;
        }

        static public void addUser(String Login, String Password, Roles Role)
        {
            openConnection();

            var command = new MySqlCommand("INSERT INTO `users` (`Login`, `Password`, `Role`) VALUES(@uLogin, @uPassword, @uRole);", db);
            
            command.Parameters.Add("@uLogin", MySqlDbType.VarChar).Value = Login;
            command.Parameters.Add("@uPassword", MySqlDbType.VarChar).Value = Password;
            command.Parameters.Add("@uRole", MySqlDbType.Int32).Value = (int)Role;

            command.ExecuteNonQuery();

            closeConnection();
        }

        static public List <UserModel> getSuperUserList()
        {
            openConnection();

            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT * FROM `users` WHERE `Role` = 1 OR `Role` = 2", db);
            var table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            var result = new List<UserModel>();

            for (int i = 0; i < table.Rows.Count; ++i)
            {
                result.Add(new UserModel()
                {
                    Login = (String)table.Rows[i]["Login"],
                    Password = (String)table.Rows[i]["Password"],
                    Role = (Roles)(int)table.Rows[i]["Role"]
                });
            }

            closeConnection();

            return result;
        }
    }
}
