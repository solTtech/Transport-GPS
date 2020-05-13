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
    public static class Transport
    {

        static MySqlConnection db = new MySqlConnection(ConnectionSettings.MySqlConnectionSettings);
        public static List<TransportModel> getTransportList()
        {

            List<TransportModel> list = new List<TransportModel>();

            db.Open();

            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT * FROM `transport`;", db);
            var table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                TransportModel item = new TransportModel();

                item.Id = int.Parse(table.Rows[i]["Id"].ToString());
                item.Type = (string)table.Rows[i]["Type"];
                item.Consumption = (int)table.Rows[i]["Consumption"];

                list.Add(item);
            }

            db.Close();
            return list;
        }

        public static TransportModel getTransportById(int Id)
        {
            db.Open();

            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT * FROM `transport` WHERE `Id` = @Id;", db);
            var table = new DataTable();

            command.Parameters.Add("@Id", MySqlDbType.Int32).Value = Id;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            db.Close();

            return new TransportModel()
            {
                Id = Id,
                Type = (string)table.Rows[0]["Type"],
                Consumption = (int)table.Rows[0]["Consumption"]
            };

        }

        public static void eraseByType(string type)
        {
            db.Open();

            var command = new MySqlCommand("DELETE FROM `transport` WHERE `Type` = @type LIMIT 1;", db);
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;

            command.ExecuteNonQuery();

            db.Close();
        }

        public static void addTransport(string type, int cons)
        {
            db.Open();

            var command = new MySqlCommand("INSERT INTO `transport` (`Type`, `Consumption`) VALUES(@uType, @uCons);", db);

            command.Parameters.Add("@uType", MySqlDbType.VarChar).Value = type;
            command.Parameters.Add("@uCons", MySqlDbType.Int32).Value = cons;

            command.ExecuteNonQuery();

            db.Close();
        }
    }
}
