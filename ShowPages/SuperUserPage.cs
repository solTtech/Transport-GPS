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
    public partial class SuperUserPage : Form
    {
        public SuperUserPage()
        {
            InitializeComponent();
            refresh();
            dataGridView_SuperUser.ClearSelection();

        }

        public void refresh()
        {
            dataGridView_SuperUser.Rows.Clear();

            var _context = Users.getSuperUserList();

            foreach (var user in _context)
            {
                dataGridView_SuperUser.Rows.Add(new string[] { user.Login, user.Password, user.Role.ToString() });
            }
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void button_AddSuperUser_Click(object sender, EventArgs e)
        {
            var openCreateSuperUserPage = new CreateSuperUserPage();
            openCreateSuperUserPage.Show();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            var openEditSuperUserPage = new EditSuperUserPage();
            openEditSuperUserPage.Show();
        }
    }
}
