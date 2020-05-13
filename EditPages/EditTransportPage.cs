using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using transport_manager.Models;
using transport_manager.Database_Source;

namespace transport_manager
{
    public partial class EditTransportPage : Form
    {

        List<TransportModel> transport;
        public EditTransportPage()
        {
            InitializeComponent();
            transport = Transport.getTransportList();
            foreach (var item in transport)
            {
                comboBox_SelectTransport.Items.AddRange(new string[] { item.Type });
            }
            comboBox_SelectTransport.SelectedIndex = 0;
        }

        private void comboBox_SelectTransport_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsumptionField.Text = transport[comboBox_SelectTransport.SelectedIndex].Consumption.ToString();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            int result;
            if (string.IsNullOrEmpty(ConsumptionField.Text) || int.TryParse(ConsumptionField.Text, out result) == false)
            {
                MessageBox.Show("Поле расхода топлива не должно быть пустым, а также должно быть числом.");
                return;
            }

            Transport.eraseByType(comboBox_SelectTransport.Text);
            Transport.addTransport(comboBox_SelectTransport.Text, result);

            MessageBox.Show("Транспорт был успешно отредактирован.");
            Close();
        }

        private void button_Erase_Click(object sender, EventArgs e)
        {
            Transport.eraseByType(comboBox_SelectTransport.Text);
            MessageBox.Show("Транспорт был успешно удалён.");
            Close();
        }
    }
}
