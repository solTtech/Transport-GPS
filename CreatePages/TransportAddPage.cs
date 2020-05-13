using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using transport_manager.Database_Source;

namespace transport_manager
{
    public partial class TransportAddPage : Form
    {
        public TransportAddPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string type = TypeField.Text;
            string consumption = textBox2.Text;
            int a;

            try
            {
                a = Int32.Parse(consumption);
            }
            catch (Exception)
            {
                MessageBox.Show("Расход должен быть целым числом!");
                return;
            }

            Transport.addTransport(type, a);

            MessageBox.Show("Транспорт был успешно добавлен!");
            this.Close();

        }
    }
}
