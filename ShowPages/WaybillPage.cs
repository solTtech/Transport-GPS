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
    public partial class WaybillPage : Form
    {
        public WaybillPage()
        {
            InitializeComponent();

            updateDataGrid();
            dataGridView1.ClearSelection();
        }

        public void updateDataGrid()
        {
            dataGridView1.Rows.Clear();

            List<WaybillModel> list = Waybills.getWaybillList();

            foreach (var item in list)
            {
                var driverItem = Drivers.getDriverById(item.DriverId);
                dataGridView1.Rows.Add(new string[] { driverItem.Name, driverItem.Surname, driverItem.Fathername, item.Price.ToString(), item.Distance.ToString(), item.Date });
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            var openCreateWaybillPage = new CreateWaybillPage();
            openCreateWaybillPage.Show();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            updateDataGrid();
        }

        private void button_Calc_Click(object sender, EventArgs e)
        {
            var openCalcPage = new CalcPage();
            openCalcPage.Show();
        }
    }
}
