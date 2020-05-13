using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using transport_manager.Database_Source;
using transport_manager.Models;

namespace transport_manager
{
    public partial class CalcPage : Form
    {
        public CalcPage()
        {
            InitializeComponent();
        }

        private void button_Calc_Click(object sender, EventArgs e)
        {
            var waybills = Waybills.getWaybillList();

            DateTime start = DateTime.Parse(((DateTime)StartDate.Value).ToString("dd/MM/yyyy"));
            DateTime end = DateTime.Parse(((DateTime)EndDate.Value).ToString("dd/MM/yyyy"));

            if (start > end)
            {
                MessageBox.Show("Начало не может быть позже конца.");
                return;
            }

            var validWays = new List<WaybillModel>();

            foreach (var item in waybills)
            {
                if (start <= DateTime.Parse(item.Date) && DateTime.Parse(item.Date) <= end)
                {
                    validWays.Add(item);
                }
            }

            var driverMap = new Dictionary<int, int>();
            var transportMap = new Dictionary<int, int>();

            foreach (var item in validWays)
            {
                if (driverMap.ContainsKey(item.DriverId) == false)
                {
                    driverMap.Add(item.DriverId, item.Price - Drivers.getDriverById(item.DriverId).Salary * item.Distance);
                }
                else
                {
                    driverMap[item.DriverId] += item.Price - Drivers.getDriverById(item.DriverId).Salary * item.Distance;
                }


                if (transportMap.ContainsKey(item.TransportId) == false)
                {
                    transportMap.Add(item.TransportId, item.Price - Drivers.getDriverById(item.DriverId).Salary * item.Distance);
                }
                else
                {
                    transportMap[item.TransportId] = Math.Max(item.Price - Drivers.getDriverById(item.DriverId).Salary * item.Distance, transportMap[item.TransportId]);
                }
            }
            
            int maxDriverValue = int.MinValue, maxDriverId = -1;

            foreach (var item in driverMap)
            {
                if (item.Value > maxDriverValue)
                {
                    maxDriverValue = item.Value;
                    maxDriverId = item.Key;
                }
            }

            if (maxDriverId != -1)
            {
                var driver = Drivers.getDriverById(maxDriverId);
                var reportDriver = new ReportDriver()
                {
                    Name = driver.Name,
                    Surname = driver.Surname,
                    Fathername = driver.Fathername,
                    Income = maxDriverValue,
                    DateStartReport = start,
                    DateEndReport = end
                };
                reportDriver.saveToXml();
            }

            foreach (var item in transportMap)
            {
                var transport = Transport.getTransportById(item.Key);
                var reportTransport = new ReportTransport()
                {
                    Type = transport.Type,
                    Income = item.Value,
                    DateStartReport = start,
                    DateEndReport = end
                };
                reportTransport.saveToXml();

            }
            Close();
        }
    }
}
