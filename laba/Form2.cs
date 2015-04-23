using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace laba
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nextWindow()
        {
            this.Hide();
            Program.form3.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Program.IDHospotal = 1;
            nextWindow();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Program.IDHospotal = 2;
            nextWindow();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Program.IDHospotal = 3;
            nextWindow();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }
    }
}
