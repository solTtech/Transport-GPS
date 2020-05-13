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
    public partial class CreateSuperUserPage : Form
    {
        public CreateSuperUserPage()
        {
            InitializeComponent();
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(loginField.Text) || String.IsNullOrEmpty(passwordField.Text) || String.IsNullOrEmpty(roleField.Text))
            {
                MessageBox.Show("Поля должны быть непустыми.");
                return;
            }

            Users.addUser(loginField.Text, passwordField.Text, (Roles)(roleField.SelectedIndex + 1));
            MessageBox.Show(roleField.Text + " был успешно добавлен.");
            this.Close();
        }
    }
}
