namespace transport_manager
{
    partial class CreateSuperUserPage
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
            this.loginField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.roleField = new System.Windows.Forms.ComboBox();
            this.button_Enter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginField
            // 
            this.loginField.Location = new System.Drawing.Point(164, 152);
            this.loginField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(317, 31);
            this.loginField.TabIndex = 0;
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(164, 240);
            this.passwordField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(317, 31);
            this.passwordField.TabIndex = 1;
            // 
            // roleField
            // 
            this.roleField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleField.FormattingEnabled = true;
            this.roleField.Items.AddRange(new object[] {
            "Operator",
            "Admin"});
            this.roleField.Location = new System.Drawing.Point(164, 319);
            this.roleField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roleField.Name = "roleField";
            this.roleField.Size = new System.Drawing.Size(317, 33);
            this.roleField.TabIndex = 2;
            // 
            // button_Enter
            // 
            this.button_Enter.Location = new System.Drawing.Point(227, 409);
            this.button_Enter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Enter.Name = "button_Enter";
            this.button_Enter.Size = new System.Drawing.Size(184, 94);
            this.button_Enter.TabIndex = 3;
            this.button_Enter.Text = "Создать";
            this.button_Enter.UseVisualStyleBackColor = true;
            this.button_Enter.Click += new System.EventHandler(this.button_Enter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 291);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Роль";
            // 
            // CreateSuperUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 598);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Enter);
            this.Controls.Add(this.roleField);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.loginField);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreateSuperUserPage";
            this.Text = "CreateSuperUserPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.ComboBox roleField;
        private System.Windows.Forms.Button button_Enter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}