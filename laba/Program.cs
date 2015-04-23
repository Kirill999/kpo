using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace laba
{
    static class Program
    {
        static string myConnectionString = "server=172.18.12.55;uid=admin;" +
                                    "pwd=qwerty;database=kpo;";
        public static MySqlConnection conn = null;
        public static MySqlDataReader rdr = null;
        public static int IDHospotal = 0;
        public static string job = "";
        public static Form1 form1;
        public static Form2 form2;
        public static Form3 form3;
        public static Form4 form4;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            form1 = new Form1();
            form2 = new Form2();
            form3 = new Form3();
            form4 = new Form4();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(form1);
        }
    }
}
