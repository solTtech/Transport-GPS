using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace transport_manager
{
    public partial class UsersPage : Form
    {
        public UsersPage()
        {
            InitializeComponent();
        }

        private void button_Superusers_Click(object sender, EventArgs e)
        {
            var openSuperUserPage = new SuperUserPage();
            openSuperUserPage.Show();
        }

        private void button_Drivers_Click(object sender, EventArgs e)
        {
            var openDriverPage = new DriversPage();
            openDriverPage.Show();
        }
    }
}
