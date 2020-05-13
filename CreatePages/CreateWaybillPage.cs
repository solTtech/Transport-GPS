using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using transport_manager.Models;
using transport_manager.Database_Source;
using System.Net.NetworkInformation;

namespace transport_manager
{
    public partial class CreateWaybillPage : Form
    {

        List<DriverModel> drivers;
        List<TransportModel> transport;
        public CreateWaybillPage()
        {
            InitializeComponent();
            
            drivers = Drivers.getDriverList();
            transport = Transport.getTransportList();
            
            foreach (var item in drivers)
            {
                comboBox_SelectDriver.Items.AddRange(new string[]
                {
                    item.Category + ": " + 
                    item.Name + " " +
                    item.Surname + " " +
                    item.Fathername +
                    ", Оклад:" + item.Salary.ToString() + "$"
                });
            }

            foreach (var item in transport)
            {
                comboBox_SelectTransport.Items.AddRange(new string[]
                {
                    item.Type + ", Расход:" + item.Consumption.ToString()
                });
            }

            comboBox_SelectDriver.SelectedIndex = 0;
            comboBox_SelectTransport.SelectedIndex = 0;
        }

        private void comboBox_SelectDriver_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectTransport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            int wayLength;

            if (string.IsNullOrEmpty(LengthField.Text) || int.TryParse(LengthField.Text, out wayLength) == false)
            {
                MessageBox.Show("Поле длины поездки должно быть не пустым, а также должно быть числом.");
                return;
            }

            int price;

            if (string.IsNullOrEmpty(PriceField.Text) || int.TryParse(PriceField.Text, out price) == false)
            {
                MessageBox.Show("Поле стоймости поездки должно быть не пустым, а также должно быть числом.");
                return;
            }

            var waybillDate = (DateTime)dateTimePicker_SelectDate.Value;

            Waybills.addWaybill(new WaybillModel()
            {
                DriverId = drivers[comboBox_SelectDriver.SelectedIndex].Id,
                TransportId = transport[comboBox_SelectTransport.SelectedIndex].Id,
                Distance = wayLength,
                Price = price,
                Date = waybillDate.ToString("dd/MM/yyyy")
            });

            MessageBox.Show("Путевой лист был успешно добавлен.");
            Close();
        }
    }
}
