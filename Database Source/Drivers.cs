using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using transport_manager.Models;

namespace transport_manager.Database_Source
{
    static internal class Drivers
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

        static public void addDriver(String Login, String Name, String Surname, String Fathername, String Category, int Salary)
        {

            openConnection();
            var command = new MySqlCommand("INSERT INTO `drivers` (`Name`, `Surname`, `Fathername`, `Category`, `Salary`, `Login`) VALUES(@dName, @dSurname, @dFathername, @dCategory, @dSalary, @dLogin);", db);

            command.Parameters.Add("@dName", MySqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@dSurname", MySqlDbType.VarChar).Value = Surname;
            command.Parameters.Add("@dFathername", MySqlDbType.VarChar).Value = Fathername;
            command.Parameters.Add("@dCategory", MySqlDbType.VarChar).Value = Category;
            command.Parameters.Add("@dSalary", MySqlDbType.Int32).Value = Salary;
            command.Parameters.Add("@dLogin", MySqlDbType.VarChar).Value = Login;

            command.ExecuteNonQuery();
            closeConnection();
        }

        static public void eraseByLogin(string Login)
        {
            openConnection();

            var command = new MySqlCommand("DELETE FROM `drivers` WHERE `Login` = @uLogin;", db);
            
            command.Parameters.Add("@uLogin", MySqlDbType.VarChar).Value = Login;
            
            command.ExecuteNonQuery();

            closeConnection();
        }

        static public DriverModel getDriverByLogin(String Login)
        {
            openConnection();

            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT * FROM `drivers` WHERE `Login` = @uLogin;", db);
            var table = new DataTable();

            command.Parameters.Add("@uLogin", MySqlDbType.VarChar).Value = Login;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            closeConnection();

            return new DriverModel()
            {
                Id = (int)(uint)table.Rows[0]["Id"],
                Name = (String)table.Rows[0]["Name"],
                Surname = (String)table.Rows[0]["Surname"],
                Fathername = (String)table.Rows[0]["Fathername"],
                Category = (String)table.Rows[0]["Category"],
                Login = (String)Login,
                Salary = (int)table.Rows[0]["Salary"],
            };
        }

        static public DriverModel getDriverById(int Id)
        {
            openConnection();

            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT * FROM `drivers` WHERE `Id` = @Id;", db);
            var table = new DataTable();

            command.Parameters.Add("@Id", MySqlDbType.Int32).Value = Id;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            closeConnection();

            return new DriverModel()
            {
                Name = (string)table.Rows[0]["Name"],
                Surname = (String)table.Rows[0]["Surname"],
                Fathername = (String)table.Rows[0]["Fathername"],
                Category = (String)table.Rows[0]["Category"],
                Login = (String)table.Rows[0]["Login"],
                Salary = (int)table.Rows[0]["Salary"],
            };
        }

        static public List<DriverModel> getDriverList()
        {
            openConnection();

            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT * FROM `drivers`", db);
            var table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            var result = new List<DriverModel>();

            for (int i = 0; i < table.Rows.Count; ++i)
            {
                result.Add(new DriverModel()
                {
                    Id = int.Parse(table.Rows[i]["Id"].ToString()),
                    Name = (String)table.Rows[i]["Name"],
                    Surname = (String)table.Rows[i]["Surname"],
                    Fathername = (String)table.Rows[i]["Fathername"],
                    Category = (String)table.Rows[i]["Category"],
                    Salary = (int)table.Rows[i]["Salary"],
                    Login = (String)table.Rows[i]["Login"]
                });
            }

            closeConnection();
            
            return result;
        }
    }
}
