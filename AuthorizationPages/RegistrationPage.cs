using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using transport_manager.Database_Source;
using transport_manager.Models;

namespace transport_manager
{
    public partial class RegistrationPage : Form
    {

        private bool currentState;
        public RegistrationPage(bool isRegOrAdd)
        {
            InitializeComponent();
            currentState = isRegOrAdd;

            if (isRegOrAdd)
            {
                button_Enter.Text = "Добавить";
                label8.Text = "Добавление";
                this.Text = "AddDriver";
            }

        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NameField.Text) || String.IsNullOrEmpty(SurnameField.Text) ||
                String.IsNullOrEmpty(FathernameField.Text) || String.IsNullOrEmpty(CategoryField.Text) ||
                String.IsNullOrEmpty(LoginField.Text) || String.IsNullOrEmpty(PasswordField.Text) ||
                String.IsNullOrEmpty(SalaryField.Text))
            {
                MessageBox.Show("Проверьте заполнение полей, поля не должны быть пустыми.");
                return;
            }

            int Salary = 0;

            if (int.TryParse(SalaryField.Text, out Salary) == false)
            {
                MessageBox.Show("Оклад должен быть числом.");
                return;
            }

            if (Users.isExists(LoginField.Text))
            {
                MessageBox.Show("Данный логин уже существует.");
                return;
            }

            Users.addUser(LoginField.Text, PasswordField.Text, Roles.Driver);
            Drivers.addDriver(LoginField.Text, NameField.Text, SurnameField.Text, FathernameField.Text, CategoryField.Text, Salary);

            MessageBox.Show(currentState == false ? "Вы были успешно зарегистрированы." : "Вы успешно добавили водителя.");
            this.Close();
        }
    }
}
