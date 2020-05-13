namespace transport_manager
{
    partial class UsersPage
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
            this.button_Drivers = new System.Windows.Forms.Button();
            this.button_Superusers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Drivers
            // 
            this.button_Drivers.Location = new System.Drawing.Point(402, 537);
            this.button_Drivers.Name = "button_Drivers";
            this.button_Drivers.Size = new System.Drawing.Size(403, 154);
            this.button_Drivers.TabIndex = 0;
            this.button_Drivers.Text = "Водители";
            this.button_Drivers.UseVisualStyleBackColor = true;
            this.button_Drivers.Click += new System.EventHandler(this.button_Drivers_Click);
            // 
            // button_Superusers
            // 
            this.button_Superusers.Location = new System.Drawing.Point(402, 180);
            this.button_Superusers.Name = "button_Superusers";
            this.button_Superusers.Size = new System.Drawing.Size(403, 154);
            this.button_Superusers.TabIndex = 1;
            this.button_Superusers.Text = "Админы и операторы";
            this.button_Superusers.UseVisualStyleBackColor = true;
            this.button_Superusers.Click += new System.EventHandler(this.button_Superusers_Click);
            // 
            // UsersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 904);
            this.Controls.Add(this.button_Superusers);
            this.Controls.Add(this.button_Drivers);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UsersPage";
            this.Text = "UsersPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Drivers;
        private System.Windows.Forms.Button button_Superusers;
    }
}