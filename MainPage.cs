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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (button_Login.Text == "Войти")
            {
                var loginPageOpen = new LoginPage(button_Login, label_Name, label_Role);
                loginPageOpen.Show();

            } else
            {
                MessageBox.Show("Вы успешно вышли.");
                button_Login.Text = "Войти";
                label_Name.Text = "";
                label_Role.Text = "";
            }
        }

        private void button_DriversList_Click(object sender, EventArgs e)
        {
            if (label_Role.Text == Roles.Driver.ToString() || String.IsNullOrEmpty(label_Role.Text))
            {
                MessageBox.Show("У вас недостаточно прав для просмотра этой страницы.");
                return;
            }
        }

        private void button_TransportList_Click(object sender, EventArgs e)
        {
            if (label_Role.Text == Roles.Driver.ToString() || String.IsNullOrEmpty(label_Role.Text))
            {
                MessageBox.Show("У вас недостаточно прав для просмотра этой страницы.");
                return;
            }

            var transportPageOpen = new TransportPage();
            transportPageOpen.Show();

        }

        private void button_WaybillList_Click(object sender, EventArgs e)
        {
            if (label_Role.Text == Roles.Driver.ToString() || String.IsNullOrEmpty(label_Role.Text))
            {
                MessageBox.Show("У вас недостаточно прав для просмотра этой страницы.");
                return;
            }
            var WaybillPageOpen = new WaybillPage();
            WaybillPageOpen.Show();
        } 

        private void button_InformationGet_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(label_Role.Text))
            {
                MessageBox.Show("Для просмотра этой страницы нужно авторизироваться.");
                return;
            }
            var openInfoPage = new InfoPage(label_Name.Text, label_Role.Text);
            openInfoPage.Show();
        }

        private void button_UsersPage_Click(object sender, EventArgs e)
        {
            if (label_Role.Text == Roles.Driver.ToString() || label_Role.Text == Roles.Operator.ToString() || String.IsNullOrEmpty(label_Role.Text))
            {
                MessageBox.Show("У вас недостаточно прав для просмотра этой страницы.");
                return;
            }
            var openUsersPage = new UsersPage();
            openUsersPage.Show();
        }
    }
}
