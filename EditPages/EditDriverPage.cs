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
    public partial class EditDriverPage : Form
    {
        List<DriverModel> drivers;
        string oldPassword;
        public EditDriverPage()
        {
            InitializeComponent();
            drivers = Drivers.getDriverList();
            foreach (var item in drivers)
            {
                comboBox_SelectName.Items.AddRange(new string[] { item.Login });
            }
            comboBox_SelectName.SelectedIndex = 0;
        }

        private void comboBox_SelectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var driverState = drivers[comboBox_SelectName.SelectedIndex];
            oldPassword = Users.getPass(driverState.Login);
            PasswordField.Text = oldPassword;
            NameField.Text = driverState.Name;
            FathernameField.Text = driverState.Fathername;
            SurnameField.Text = driverState.Surname;
            CategoryField.Text = driverState.Category;
            SalaryField.Text = driverState.Salary.ToString();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NameField.Text) || String.IsNullOrEmpty(SurnameField.Text) ||
                String.IsNullOrEmpty(FathernameField.Text) || String.IsNullOrEmpty(CategoryField.Text) ||
                String.IsNullOrEmpty(PasswordField.Text) || String.IsNullOrEmpty(SalaryField.Text))
            {
                MessageBox.Show("Проверьте заполнение полей, поля не должны быть пустыми.");
                return;
            }


            if (PasswordField.Text != oldPassword)
            {
                Users.eraseByLogin(comboBox_SelectName.Text);
                Users.addUser(comboBox_SelectName.Text, PasswordField.Text, Roles.Driver);
            }

            int Salary = 0;

            if (int.TryParse(SalaryField.Text, out Salary) == false)
            {
                MessageBox.Show("Оклад должен быть числом.");
                return;
            }

            Drivers.eraseByLogin(comboBox_SelectName.Text);
            Drivers.addDriver(comboBox_SelectName.Text, NameField.Text, SurnameField.Text, FathernameField.Text, CategoryField.Text, Salary);

            MessageBox.Show("Данный водитель был успешно отредактирован.");
            Close();
        }

        private void button_Erase_Click(object sender, EventArgs e)
        {
            Drivers.eraseByLogin(comboBox_SelectName.Text);
            MessageBox.Show("Данный водитель был успешно удалён.");
            Close();
        }
    }
}
