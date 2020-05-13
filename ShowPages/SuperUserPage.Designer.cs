namespace transport_manager
{
    partial class SuperUserPage
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
            this.dataGridView_SuperUser = new System.Windows.Forms.DataGridView();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_AddSuperUser = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SuperUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_SuperUser
            // 
            this.dataGridView_SuperUser.AllowUserToAddRows = false;
            this.dataGridView_SuperUser.AllowUserToResizeColumns = false;
            this.dataGridView_SuperUser.AllowUserToResizeRows = false;
            this.dataGridView_SuperUser.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_SuperUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_SuperUser.ColumnHeadersHeight = 50;
            this.dataGridView_SuperUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_SuperUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Login,
            this.Password,
            this.Role});
            this.dataGridView_SuperUser.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_SuperUser.Name = "dataGridView_SuperUser";
            this.dataGridView_SuperUser.RowHeadersVisible = false;
            this.dataGridView_SuperUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_SuperUser.RowTemplate.Height = 40;
            this.dataGridView_SuperUser.Size = new System.Drawing.Size(784, 700);
            this.dataGridView_SuperUser.TabIndex = 0;
            // 
            // Login
            // 
            this.Login.HeaderText = "Логин";
            this.Login.MinimumWidth = 12;
            this.Login.Name = "Login";
            this.Login.Width = 60;
            // 
            // Password
            // 
            this.Password.HeaderText = "Пароль";
            this.Password.MinimumWidth = 12;
            this.Password.Name = "Password";
            this.Password.Width = 60;
            // 
            // Role
            // 
            this.Role.HeaderText = "Роль";
            this.Role.MinimumWidth = 12;
            this.Role.Name = "Role";
            this.Role.Width = 90;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(866, 151);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(246, 105);
            this.button_Refresh.TabIndex = 1;
            this.button_Refresh.Text = "Обновить";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_AddSuperUser
            // 
            this.button_AddSuperUser.Location = new System.Drawing.Point(866, 338);
            this.button_AddSuperUser.Name = "button_AddSuperUser";
            this.button_AddSuperUser.Size = new System.Drawing.Size(246, 105);
            this.button_AddSuperUser.TabIndex = 2;
            this.button_AddSuperUser.Text = "Добавить";
            this.button_AddSuperUser.UseVisualStyleBackColor = true;
            this.button_AddSuperUser.Click += new System.EventHandler(this.button_AddSuperUser_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(866, 527);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(246, 105);
            this.button_Edit.TabIndex = 3;
            this.button_Edit.Text = "Редактировать";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // SuperUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 734);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_AddSuperUser);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.dataGridView_SuperUser);
            this.Name = "SuperUserPage";
            this.Text = "SuperUserPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SuperUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_SuperUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button button_AddSuperUser;
        private System.Windows.Forms.Button button_Edit;
    }
}