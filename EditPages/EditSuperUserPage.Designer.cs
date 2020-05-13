namespace transport_manager
{
    partial class EditSuperUserPage
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
            this.comboBox_SelectName = new System.Windows.Forms.ComboBox();
            this.button_Edit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.label_TextPage = new System.Windows.Forms.Label();
            this.roleField = new System.Windows.Forms.ComboBox();
            this.button_Erase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_SelectName
            // 
            this.comboBox_SelectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SelectName.FormattingEnabled = true;
            this.comboBox_SelectName.Location = new System.Drawing.Point(357, 184);
            this.comboBox_SelectName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_SelectName.Name = "comboBox_SelectName";
            this.comboBox_SelectName.Size = new System.Drawing.Size(282, 33);
            this.comboBox_SelectName.TabIndex = 46;
            this.comboBox_SelectName.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectName_SelectedIndexChanged);
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(389, 416);
            this.button_Edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(219, 88);
            this.button_Edit.TabIndex = 45;
            this.button_Edit.Text = "Редактировать";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 44;
            this.label7.Text = "Пароль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "Логин";
            // 
            // PasswordField
            // 
            this.PasswordField.Location = new System.Drawing.Point(357, 269);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(282, 31);
            this.PasswordField.TabIndex = 37;
            // 
            // label_TextPage
            // 
            this.label_TextPage.AutoSize = true;
            this.label_TextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_TextPage.Location = new System.Drawing.Point(146, 73);
            this.label_TextPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TextPage.Name = "label_TextPage";
            this.label_TextPage.Size = new System.Drawing.Size(731, 37);
            this.label_TextPage.TabIndex = 31;
            this.label_TextPage.Text = "Редактирование привилегированного пользоватея";
            // 
            // roleField
            // 
            this.roleField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleField.FormattingEnabled = true;
            this.roleField.Items.AddRange(new object[] {
            "Operator",
            "Admin"});
            this.roleField.Location = new System.Drawing.Point(357, 348);
            this.roleField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roleField.Name = "roleField";
            this.roleField.Size = new System.Drawing.Size(282, 33);
            this.roleField.TabIndex = 47;
            // 
            // button_Erase
            // 
            this.button_Erase.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_Erase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Erase.Location = new System.Drawing.Point(389, 549);
            this.button_Erase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Erase.Name = "button_Erase";
            this.button_Erase.Size = new System.Drawing.Size(219, 88);
            this.button_Erase.TabIndex = 48;
            this.button_Erase.Text = "Удалить";
            this.button_Erase.UseVisualStyleBackColor = false;
            this.button_Erase.Click += new System.EventHandler(this.button_Erase_Click);
            // 
            // EditSuperUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 859);
            this.Controls.Add(this.button_Erase);
            this.Controls.Add(this.roleField);
            this.Controls.Add(this.comboBox_SelectName);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.label_TextPage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditSuperUserPage";
            this.Text = "EditSuperUserPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_SelectName;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Label label_TextPage;
        private System.Windows.Forms.ComboBox roleField;
        private System.Windows.Forms.Button button_Erase;
    }
}