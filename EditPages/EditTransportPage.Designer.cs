namespace transport_manager
{
    partial class EditTransportPage
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
            this.comboBox_SelectTransport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConsumptionField = new System.Windows.Forms.TextBox();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Erase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_SelectTransport
            // 
            this.comboBox_SelectTransport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SelectTransport.FormattingEnabled = true;
            this.comboBox_SelectTransport.Location = new System.Drawing.Point(166, 81);
            this.comboBox_SelectTransport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_SelectTransport.Name = "comboBox_SelectTransport";
            this.comboBox_SelectTransport.Size = new System.Drawing.Size(144, 24);
            this.comboBox_SelectTransport.TabIndex = 0;
            this.comboBox_SelectTransport.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectTransport_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Редагування транспорту";
            // 
            // ConsumptionField
            // 
            this.ConsumptionField.Location = new System.Drawing.Point(166, 132);
            this.ConsumptionField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConsumptionField.Name = "ConsumptionField";
            this.ConsumptionField.Size = new System.Drawing.Size(144, 22);
            this.ConsumptionField.TabIndex = 2;
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(285, 332);
            this.button_Edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(142, 36);
            this.button_Edit.TabIndex = 3;
            this.button_Edit.Text = "Редагувати";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Erase
            // 
            this.button_Erase.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_Erase.Location = new System.Drawing.Point(285, 396);
            this.button_Erase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Erase.Name = "button_Erase";
            this.button_Erase.Size = new System.Drawing.Size(142, 36);
            this.button_Erase.TabIndex = 4;
            this.button_Erase.Text = "Видалити";
            this.button_Erase.UseVisualStyleBackColor = false;
            this.button_Erase.Click += new System.EventHandler(this.button_Erase_Click);
            // 
            // EditTransportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 443);
            this.Controls.Add(this.button_Erase);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.ConsumptionField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_SelectTransport);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditTransportPage";
            this.Text = "Редагування транспорту";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_SelectTransport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ConsumptionField;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Erase;
    }
}