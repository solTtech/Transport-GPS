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
    public partial class EditSuperUserPage : Form
    {

        List<UserModel> users;
        public EditSuperUserPage()
        {
            InitializeComponent();
            users = Users.getSuperUserList();
            
            foreach (var item in users)
            {
                comboBox_SelectName.Items.AddRange(new string[] { item.Login });
            }

            comboBox_SelectName.SelectedIndex = 0;
        }

        private void comboBox_SelectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            PasswordField.Text = users[comboBox_SelectName.SelectedIndex].Password;
            roleField.SelectedIndex = ((int)users[comboBox_SelectName.SelectedIndex].Role - 1);
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PasswordField.Text))
            {
                MessageBox.Show("Поле с паролем не должно быть пустым.");
                return;
            }

            Users.eraseByLogin(comboBox_SelectName.Text);
            Users.addUser(comboBox_SelectName.Text, PasswordField.Text, (Roles)(roleField.SelectedIndex + 1));
           
            MessageBox.Show("Пользователь был успешно отредактирован.");
            Close();
        }

        private void button_Erase_Click(object sender, EventArgs e)
        {
            Users.eraseByLogin(comboBox_SelectName.Text);
            MessageBox.Show("Пользователь был успешно удалён.");
            Close();
        }
    }
}
