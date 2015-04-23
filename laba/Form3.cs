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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void nextWindow()
        {
            this.Hide();
  
            Program.form4.GetView().Rows.Clear();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
            cmd = new MySql.Data.MySqlClient.MySqlCommand();
            cmd.Connection = Program.conn;
            MySql.Data.MySqlClient.MySqlDataReader rdr = null;
            cmd.CommandText = "SELECT doctor.id, doctor.Name, doctor.cabinet, timetable.timestart, timetable.timeend, timetable.Day FROM doctor, timetable WHERE doctor.id = timetable.iddoctor AND doctor.idhospital = " + Program.IDHospotal + " AND doctor.post = '" + Program.job + "'";
            rdr = cmd.ExecuteReader();
            int id = 0;
            Program.form4.GetView().AllowUserToAddRows = true;
            System.Windows.Forms.DataGridViewRow row = (System.Windows.Forms.DataGridViewRow)Program.form4.GetView().Rows[0].Clone();
            while (rdr.Read())
            {
                row.Cells[0].Value = rdr.GetString("Name");
                row.Cells[1].Value = rdr.GetString("Cabinet");
                row.Cells[1 + Int32.Parse(rdr.GetString("day"))].Value = rdr.GetString("timestart") + ":00-" + rdr.GetString("timeend") + ":00";
                if (id != Int32.Parse(rdr.GetString("id")))
                {
                    Program.form4.GetView().Rows.Add(row);
                    row = (System.Windows.Forms.DataGridViewRow)Program.form4.GetView().Rows[0].Clone();
                }
                id = Int32.Parse(rdr.GetString("id"));
            }
            Program.form4.GetView().AllowUserToAddRows = false;
            rdr.Close();
            Program.form4.Show();
        }
        //
        //
        private void label1_Click(object sender, EventArgs e)
        {
            Program.job = "Акушерство и гинекология";
            nextWindow();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Program.job = "Неврология";
            nextWindow();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Program.job = "Онкология";
            nextWindow();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Program.job = "Оториноларинголория";
            nextWindow();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Program.job = "Терапия";
            nextWindow();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Program.job = "Терапия. Гастроэнтерология";
            nextWindow();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Program.job = "Терапия. Кардиология";
            nextWindow();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Program.job = "Хирургия";
            nextWindow();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Program.job = "Хирургия. Урология";
            nextWindow();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Program.job = "Эндокринология";
            nextWindow();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Program.form1.Show();
        }
    }
}
