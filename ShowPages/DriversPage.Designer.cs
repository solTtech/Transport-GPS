namespace transport_manager
{
    partial class DriversPage
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
            this.dataGridView_Drivers = new System.Windows.Forms.DataGridView();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fathername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_AddSuperUser = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Drivers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Drivers
            // 
            this.dataGridView_Drivers.AllowUserToResizeColumns = false;
            this.dataGridView_Drivers.AllowUserToResizeRows = false;
            this.dataGridView_Drivers.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_Drivers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Drivers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView_Drivers.ColumnHeadersHeight = 58;
            this.dataGridView_Drivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Drivers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name1,
            this.Surname,
            this.Fathername,
            this.Category,
            this.Salary});
            this.dataGridView_Drivers.Location = new System.Drawing.Point(2, -1);
            this.dataGridView_Drivers.Name = "dataGridView_Drivers";
            this.dataGridView_Drivers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView_Drivers.RowHeadersVisible = false;
            this.dataGridView_Drivers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView_Drivers.RowTemplate.Height = 40;
            this.dataGridView_Drivers.Size = new System.Drawing.Size(834, 658);
            this.dataGridView_Drivers.TabIndex = 0;
            // 
            // Name1
            // 
            this.Name1.HeaderText = "Имя";
            this.Name1.MinimumWidth = 12;
            this.Name1.Name = "Name1";
            this.Name1.Width = 50;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.MinimumWidth = 12;
            this.Surname.Name = "Surname";
            this.Surname.Width = 50;
            // 
            // Fathername
            // 
            this.Fathername.HeaderText = "Отчество";
            this.Fathername.MinimumWidth = 12;
            this.Fathername.Name = "Fathername";
            this.Fathername.Width = 50;
            // 
            // Category
            // 
            this.Category.HeaderText = "Классность";
            this.Category.MinimumWidth = 12;
            this.Category.Name = "Category";
            this.Category.Width = 50;
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Оклад";
            this.Salary.MinimumWidth = 12;
            this.Salary.Name = "Salary";
            this.Salary.Width = 50;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(977, 175);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(239, 105);
            this.button_Refresh.TabIndex = 2;
            this.button_Refresh.Text = "Обновить";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_AddSuperUser
            // 
            this.button_AddSuperUser.Location = new System.Drawing.Point(977, 364);
            this.button_AddSuperUser.Name = "button_AddSuperUser";
            this.button_AddSuperUser.Size = new System.Drawing.Size(239, 105);
            this.button_AddSuperUser.TabIndex = 3;
            this.button_AddSuperUser.Text = "Добавить";
            this.button_AddSuperUser.UseVisualStyleBackColor = true;
            this.button_AddSuperUser.Click += new System.EventHandler(this.button_AddSuperUser_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(977, 552);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(239, 105);
            this.button_Edit.TabIndex = 4;
            this.button_Edit.Text = "Редактировать";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // DriversPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 800);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_AddSuperUser);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.dataGridView_Drivers);
            this.Name = "DriversPage";
            this.Text = "DriversPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Drivers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Drivers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fathername;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button button_AddSuperUser;
        private System.Windows.Forms.Button button_Edit;
    }
}