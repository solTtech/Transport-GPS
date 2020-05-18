using System;
using System.CodeDom;
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
    public partial class InfoPage : Form
    {
        public InfoPage(String Login, String Role)
        {
            InitializeComponent();


            label_Role.Text = Role;

            if (Role == "Driver")
            { 
                var DriverInfo = Drivers.getDriverByLogin(Login);
                label_Category.Text = DriverInfo.Category;
                label_Fathername.Text = DriverInfo.Fathername;
                label_Name.Text = DriverInfo.Name;
                label_Salary.Text = DriverInfo.Salary.ToString();
                label_Surname.Text = DriverInfo.Surname;

                WaybillTable.Visible = true;

                List<WaybillModel> waybills = Waybills.getWaybillList().Where(item => item.DriverId == DriverInfo.Id).ToList();

                foreach (var item in waybills)
                {
                    var currentTransport = Transport.getTransportById(item.TransportId);
                    WaybillTable.Rows.Add(new string[] { currentTransport.Type, item.Distance.ToString(), item.Price.ToString()} );
                }
            }
        }
    }
}
