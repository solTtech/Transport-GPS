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
    public partial class LoginPage : Form
    {
        private Button button_LoginReference;
        private Label label_NameReference;
        private Label label_RoleReference;
        public LoginPage(Button button_Login, Label label_Name, Label label_Role)
        {
            InitializeComponent();
            button_LoginReference = button_Login;
            label_RoleReference = label_Role;
            label_NameReference = label_Name;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            String Login = LoginField.Text;
            String Password = PasswordField.Text;

            if (String.IsNullOrEmpty(Login) || String.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Проверьте, что все поля являются заполненными.");
                return;
            }

            int result = Users.getRole(Login, Password);

            if (result != -1)
            {
                MessageBox.Show("Вы были успешно авторизованы.");
                button_LoginReference.Text = "Выйти";
                label_NameReference.Text = Login;
                label_RoleReference.Text = ((Roles)result).ToString();
                this.Close();
                return;
            }
            MessageBox.Show("Неправильный логин или пароль.");
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Registration_Click(object sender, EventArgs e)
        {
            var registrationPageOpen = new RegistrationPage(false);
            registrationPageOpen.Show();
        }
    }
}
