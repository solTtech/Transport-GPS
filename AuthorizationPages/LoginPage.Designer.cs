namespace transport_manager
{
    partial class LoginPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Login = new System.Windows.Forms.Button();
            this.button_Registration = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginField
            // 
            this.LoginField.Location = new System.Drawing.Point(286, 254);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(344, 31);
            this.LoginField.TabIndex = 0;
            this.LoginField.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(348, 485);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(200, 61);
            this.button_Login.TabIndex = 4;
            this.button_Login.Text = "Войти";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_Registration
            // 
            this.button_Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.button_Registration.Location = new System.Drawing.Point(348, 592);
            this.button_Registration.Name = "button_Registration";
            this.button_Registration.Size = new System.Drawing.Size(200, 61);
            this.button_Registration.TabIndex = 5;
            this.button_Registration.Text = "Зарегистрироваться";
            this.button_Registration.UseVisualStyleBackColor = true;
            this.button_Registration.Click += new System.EventHandler(this.button_Registration_Click);
            // 
            // button_Back
            // 
            this.button_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.button_Back.Location = new System.Drawing.Point(348, 693);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(200, 61);
            this.button_Back.TabIndex = 6;
            this.button_Back.Text = "Назад";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // PasswordField
            // 
            this.PasswordField.Location = new System.Drawing.Point(286, 388);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.Size = new System.Drawing.Size(344, 31);
            this.PasswordField.TabIndex = 2;
            this.PasswordField.Tag = "";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 829);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Registration);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginField);
            this.Name = "LoginPage";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_Registration;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.TextBox PasswordField;
    }
}