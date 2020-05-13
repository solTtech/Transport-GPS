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

namespace transport_manager
{
    public partial class DriversPage : Form
    {
        public DriversPage()
        {
            InitializeComponent();
            refresh();

            dataGridView_Drivers.ClearSelection();
        }

        public void refresh()
        {
            dataGridView_Drivers.Rows.Clear();

            var _context = Drivers.getDriverList();

            foreach (var driver in _context)
            {
                dataGridView_Drivers.Rows.Add(new string[] {
                    driver.Name,
                    driver.Surname,
                    driver.Fathername,
                    driver.Category,
                    driver.Salary.ToString()
                });
            }

        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void button_AddSuperUser_Click(object sender, EventArgs e)
        {
            var openRegistrationPage = new RegistrationPage(true);
            openRegistrationPage.Show();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            var openEditDriverPage = new EditDriverPage();
            openEditDriverPage.Show();
        }
    }
}
