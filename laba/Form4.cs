using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                MessageBox.Show("Вы успешно записались на прием");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form2.Show();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }

        private void dataGridView1_Click(object sender, DataGridViewCellEventArgs e)
        {
           // if (dataGridView1.getSe
           // MessageBox.Show("Вы успешно записались на прием");
        }

        public DataGridView GetView()
        {
            return dataGridView1;
        }

        public void NewView()
        {
            dataGridView1 = new DataGridView();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Program.form1.Show();
        }
    }
}
