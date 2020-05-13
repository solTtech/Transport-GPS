namespace transport_manager
{
    partial class MainPage
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Login = new System.Windows.Forms.Button();
            this.button_TransportList = new System.Windows.Forms.Button();
            this.button_WaybillList = new System.Windows.Forms.Button();
            this.button_InformationGet = new System.Windows.Forms.Button();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Role = new System.Windows.Forms.Label();
            this.button_UsersPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(1010, 683);
            this.button_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(387, 224);
            this.button_Login.TabIndex = 0;
            this.button_Login.Text = "Войти";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_TransportList
            // 
            this.button_TransportList.Location = new System.Drawing.Point(657, 132);
            this.button_TransportList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_TransportList.Name = "button_TransportList";
            this.button_TransportList.Size = new System.Drawing.Size(387, 224);
            this.button_TransportList.TabIndex = 1;
            this.button_TransportList.Text = "Транспорт";
            this.button_TransportList.UseVisualStyleBackColor = true;
            this.button_TransportList.Click += new System.EventHandler(this.button_TransportList_Click);
            // 
            // button_WaybillList
            // 
            this.button_WaybillList.Location = new System.Drawing.Point(1309, 132);
            this.button_WaybillList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_WaybillList.Name = "button_WaybillList";
            this.button_WaybillList.Size = new System.Drawing.Size(387, 224);
            this.button_WaybillList.TabIndex = 3;
            this.button_WaybillList.Text = "Путевые листы";
            this.button_WaybillList.UseVisualStyleBackColor = true;
            this.button_WaybillList.Click += new System.EventHandler(this.button_WaybillList_Click);
            // 
            // button_InformationGet
            // 
            this.button_InformationGet.Location = new System.Drawing.Point(337, 683);
            this.button_InformationGet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_InformationGet.Name = "button_InformationGet";
            this.button_InformationGet.Size = new System.Drawing.Size(387, 224);
            this.button_InformationGet.TabIndex = 4;
            this.button_InformationGet.Text = "Информация о себе";
            this.button_InformationGet.UseVisualStyleBackColor = true;
            this.button_InformationGet.Click += new System.EventHandler(this.button_InformationGet_Click);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_Name.Location = new System.Drawing.Point(703, 417);
            this.label_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(0, 58);
            this.label_Name.TabIndex = 5;
            // 
            // label_Role
            // 
            this.label_Role.AutoSize = true;
            this.label_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_Role.Location = new System.Drawing.Point(703, 523);
            this.label_Role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Role.Name = "label_Role";
            this.label_Role.Size = new System.Drawing.Size(0, 58);
            this.label_Role.TabIndex = 6;
            // 
            // button_UsersPage
            // 
            this.button_UsersPage.Location = new System.Drawing.Point(13, 132);
            this.button_UsersPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_UsersPage.Name = "button_UsersPage";
            this.button_UsersPage.Size = new System.Drawing.Size(387, 224);
            this.button_UsersPage.TabIndex = 7;
            this.button_UsersPage.Text = "Пользователи";
            this.button_UsersPage.UseVisualStyleBackColor = true;
            this.button_UsersPage.Click += new System.EventHandler(this.button_UsersPage_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1928, 1057);
            this.Controls.Add(this.button_UsersPage);
            this.Controls.Add(this.label_Role);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.button_InformationGet);
            this.Controls.Add(this.button_WaybillList);
            this.Controls.Add(this.button_TransportList);
            this.Controls.Add(this.button_Login);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainPage";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.Text = "Transport Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_TransportList;
        private System.Windows.Forms.Button button_WaybillList;
        private System.Windows.Forms.Button button_InformationGet;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Role;
        private System.Windows.Forms.Button button_UsersPage;
    }
}

