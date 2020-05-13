using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using transport_manager.Models;

namespace transport_manager.Database_Source
{
    public static class Waybills
    {

        static MySqlConnection db = new MySqlConnection(ConnectionSettings.MySqlConnectionSettings);
        public static List<WaybillModel> getWaybillList()
        {

            List<WaybillModel> list = new List<WaybillModel>();
            db.Open();

            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT * FROM `waybills`;", db);
            var table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                list.Add(new WaybillModel() 
                {
                    DriverId = int.Parse(table.Rows[i]["DriverId"].ToString()),
                    TransportId = int.Parse(table.Rows[i]["TransportId"].ToString()),
                    Date = (string)table.Rows[i]["Date"],
                    Distance = int.Parse(table.Rows[i]["Distance"].ToString()),
                    Price = int.Parse(table.Rows[i]["Price"].ToString()),
                });
            }

            db.Close();
            return list;
        }

        static public void addWaybill(WaybillModel waybill)
        {
            db.Open();

            var command = new MySqlCommand("INSERT INTO `waybills` (`DriverId`, `TransportId`, `Distance`, `Price`, `Date`) VALUES(@DriverId, @TransportId, @Distance, @Price, @Date);", db);

            command.Parameters.Add("@DriverId", MySqlDbType.Int32).Value = waybill.DriverId;
            command.Parameters.Add("@TransportId", MySqlDbType.Int32).Value = waybill.TransportId;
            command.Parameters.Add("@Distance", MySqlDbType.Int32).Value = waybill.Distance;
            command.Parameters.Add("@Price", MySqlDbType.Int32).Value = waybill.Price;
            command.Parameters.Add("@Date", MySqlDbType.VarChar).Value = waybill.Date;

            command.ExecuteNonQuery();

            db.Close();
        }

    }
}
