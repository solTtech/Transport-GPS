using System;
using System.Collections.Generic;


using System.Windows.Forms;
using transport_manager.Database_Source;
using transport_manager.Models;

namespace transport_manager
{
    public partial class TransportPage : Form
    {
        public TransportPage()
        {
            InitializeComponent();

            dataGridUpdate();
            dataGridView1.ClearSelection();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void dataGridUpdate()
        {
            dataGridView1.Rows.Clear();
            List <TransportModel> list = Transport.getTransportList();
            
            foreach (var item in list)
            {
                dataGridView1.Rows.Add(new string[] { item.Type, item.Consumption.ToString() });
            }
            
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.RowIndex.ToString());
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            var transportPageOpen = new TransportAddPage();
            transportPageOpen.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridUpdate();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            var openEditTransportPage = new EditTransportPage();
            openEditTransportPage.Show();
        }
    }
}
