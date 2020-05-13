namespace transport_manager
{
    partial class InfoPage
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
            this.label_Role = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Surname = new System.Windows.Forms.Label();
            this.label_Fathername = new System.Windows.Forms.Label();
            this.label_Category = new System.Windows.Forms.Label();
            this.label_Salary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Role
            // 
            this.label_Role.AutoSize = true;
            this.label_Role.Location = new System.Drawing.Point(291, 24);
            this.label_Role.Name = "label_Role";
            this.label_Role.Size = new System.Drawing.Size(0, 25);
            this.label_Role.TabIndex = 0;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(30, 94);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(0, 25);
            this.label_Name.TabIndex = 1;
            // 
            // label_Surname
            // 
            this.label_Surname.AutoSize = true;
            this.label_Surname.Location = new System.Drawing.Point(35, 142);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(0, 25);
            this.label_Surname.TabIndex = 2;
            // 
            // label_Fathername
            // 
            this.label_Fathername.AutoSize = true;
            this.label_Fathername.Location = new System.Drawing.Point(35, 180);
            this.label_Fathername.Name = "label_Fathername";
            this.label_Fathername.Size = new System.Drawing.Size(0, 25);
            this.label_Fathername.TabIndex = 3;
            // 
            // label_Category
            // 
            this.label_Category.AutoSize = true;
            this.label_Category.Location = new System.Drawing.Point(489, 142);
            this.label_Category.Name = "label_Category";
            this.label_Category.Size = new System.Drawing.Size(0, 25);
            this.label_Category.TabIndex = 4;
            // 
            // label_Salary
            // 
            this.label_Salary.AutoSize = true;
            this.label_Salary.Location = new System.Drawing.Point(489, 180);
            this.label_Salary.Name = "label_Salary";
            this.label_Salary.Size = new System.Drawing.Size(0, 25);
            this.label_Salary.TabIndex = 5;
            // 
            // InfoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 329);
            this.Controls.Add(this.label_Salary);
            this.Controls.Add(this.label_Category);
            this.Controls.Add(this.label_Fathername);
            this.Controls.Add(this.label_Surname);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_Role);
            this.Name = "InfoPage";
            this.Text = "InfoPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Role;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.Label label_Fathername;
        private System.Windows.Forms.Label label_Category;
        private System.Windows.Forms.Label label_Salary;
    }
}