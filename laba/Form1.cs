using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;

namespace laba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1420" &&  dateTimePicker1.Value <= DateTime.Now)
            {
                this.Hide();
                textBox1.Text = "";
                dateTimePicker1.Value = new DateTime(1990, 1, 1);
                Program.form2.Show();
            }
            else
                MessageBox.Show("Номер полиса и дата рождения не совпадают");
        }
    }
}
