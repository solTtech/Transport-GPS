namespace transport_manager
{
    partial class CreateWaybillPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_SelectDriver = new System.Windows.Forms.ComboBox();
            this.LengthField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Create = new System.Windows.Forms.Button();
            this.comboBox_SelectTransport = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_SelectDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Додавання трекера";
            // 
            // comboBox_SelectDriver
            // 
            this.comboBox_SelectDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SelectDriver.FormattingEnabled = true;
            this.comboBox_SelectDriver.Location = new System.Drawing.Point(157, 146);
            this.comboBox_SelectDriver.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.comboBox_SelectDriver.Name = "comboBox_SelectDriver";
            this.comboBox_SelectDriver.Size = new System.Drawing.Size(296, 24);
            this.comboBox_SelectDriver.TabIndex = 2;
            this.comboBox_SelectDriver.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectDriver_SelectedIndexChanged);
            // 
            // LengthField
            // 
            this.LengthField.Location = new System.Drawing.Point(157, 261);
            this.LengthField.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.LengthField.Name = "LengthField";
            this.LengthField.Size = new System.Drawing.Size(296, 22);
            this.LengthField.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Марка/модель трекера";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Вибір техніки/транспорту";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Особа, що встановлювала";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Дата встановлення";
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(224, 328);
            this.button_Create.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(175, 47);
            this.button_Create.TabIndex = 9;
            this.button_Create.Text = "Додати";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // comboBox_SelectTransport
            // 
            this.comboBox_SelectTransport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SelectTransport.FormattingEnabled = true;
            this.comboBox_SelectTransport.Location = new System.Drawing.Point(157, 98);
            this.comboBox_SelectTransport.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.comboBox_SelectTransport.Name = "comboBox_SelectTransport";
            this.comboBox_SelectTransport.Size = new System.Drawing.Size(296, 24);
            this.comboBox_SelectTransport.TabIndex = 10;
            this.comboBox_SelectTransport.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectTransport_SelectedIndexChanged);
            // 
            // dateTimePicker_SelectDate
            // 
            this.dateTimePicker_SelectDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_SelectDate.Location = new System.Drawing.Point(157, 200);
            this.dateTimePicker_SelectDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker_SelectDate.Name = "dateTimePicker_SelectDate";
            this.dateTimePicker_SelectDate.Size = new System.Drawing.Size(296, 22);
            this.dateTimePicker_SelectDate.TabIndex = 11;
            // 
            // CreateWaybillPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(641, 558);
            this.Controls.Add(this.dateTimePicker_SelectDate);
            this.Controls.Add(this.comboBox_SelectTransport);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LengthField);
            this.Controls.Add(this.comboBox_SelectDriver);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "CreateWaybillPage";
            this.Text = "Додавання трекера";
            this.Load += new System.EventHandler(this.CreateWaybillPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_SelectDriver;
        private System.Windows.Forms.TextBox LengthField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.ComboBox comboBox_SelectTransport;
        private System.Windows.Forms.DateTimePicker dateTimePicker_SelectDate;
    }
}