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
            this.WaybillTable = new System.Windows.Forms.DataGridView();
            this.TransportColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.WaybillTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Role
            // 
            this.label_Role.AutoSize = true;
            this.label_Role.Location = new System.Drawing.Point(146, 12);
            this.label_Role.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Role.Name = "label_Role";
            this.label_Role.Size = new System.Drawing.Size(0, 13);
            this.label_Role.TabIndex = 0;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(15, 49);
            this.label_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(0, 13);
            this.label_Name.TabIndex = 1;
            // 
            // label_Surname
            // 
            this.label_Surname.AutoSize = true;
            this.label_Surname.Location = new System.Drawing.Point(18, 74);
            this.label_Surname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(0, 13);
            this.label_Surname.TabIndex = 2;
            // 
            // label_Fathername
            // 
            this.label_Fathername.AutoSize = true;
            this.label_Fathername.Location = new System.Drawing.Point(18, 94);
            this.label_Fathername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Fathername.Name = "label_Fathername";
            this.label_Fathername.Size = new System.Drawing.Size(0, 13);
            this.label_Fathername.TabIndex = 3;
            // 
            // label_Category
            // 
            this.label_Category.AutoSize = true;
            this.label_Category.Location = new System.Drawing.Point(244, 74);
            this.label_Category.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Category.Name = "label_Category";
            this.label_Category.Size = new System.Drawing.Size(0, 13);
            this.label_Category.TabIndex = 4;
            // 
            // label_Salary
            // 
            this.label_Salary.AutoSize = true;
            this.label_Salary.Location = new System.Drawing.Point(244, 94);
            this.label_Salary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Salary.Name = "label_Salary";
            this.label_Salary.Size = new System.Drawing.Size(0, 13);
            this.label_Salary.TabIndex = 5;
            // 
            // WaybillTable
            // 
            this.WaybillTable.AllowDrop = true;
            this.WaybillTable.AllowUserToResizeColumns = false;
            this.WaybillTable.AllowUserToResizeRows = false;
            this.WaybillTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WaybillTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WaybillTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WaybillTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransportColumn,
            this.Length,
            this.Value});
            this.WaybillTable.Location = new System.Drawing.Point(37, 151);
            this.WaybillTable.Name = "WaybillTable";
            this.WaybillTable.RowHeadersVisible = false;
            this.WaybillTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.WaybillTable.Size = new System.Drawing.Size(302, 173);
            this.WaybillTable.TabIndex = 7;
            this.WaybillTable.Visible = false;
            // 
            // TransportColumn
            // 
            this.TransportColumn.HeaderText = "Транспорт";
            this.TransportColumn.Name = "TransportColumn";
            // 
            // Length
            // 
            this.Length.HeaderText = "Длина поездки";
            this.Length.Name = "Length";
            // 
            // Value
            // 
            this.Value.HeaderText = "Стоймость поездки";
            this.Value.Name = "Value";
            // 
            // InfoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 374);
            this.Controls.Add(this.WaybillTable);
            this.Controls.Add(this.label_Salary);
            this.Controls.Add(this.label_Category);
            this.Controls.Add(this.label_Fathername);
            this.Controls.Add(this.label_Surname);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_Role);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InfoPage";
            this.Text = "InfoPage";
            ((System.ComponentModel.ISupportInitialize)(this.WaybillTable)).EndInit();
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
        private System.Windows.Forms.DataGridView WaybillTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransportColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}