using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffe_house
{
    public partial class Form1 : Form
    {
        static List<string> staffID = new List<string>();
        public Form1()
        {
            InitializeComponent();
            string sql3 = "SELECT * FROM `login_save`";
            MySqlConnection con3 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd1 = new MySqlCommand(sql3, con3);

            con3.Open();
            MySqlDataReader reader3 = cmd1.ExecuteReader();
            while (reader3.Read())
            {
                staffID.Add(reader3.GetString("staffsID"));
            }
            if (staffID.Count == 0)
            {
                pictureBox10.Hide();
                C.Text = "NO login";
            }
            else
            {
                pictureBox5.Hide();
                C.Text = "StaffID = "+staffID[0];
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            C.Text = "NO login";
                string del = "DELETE FROM `login_save` WHERE staffsID";
                MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(del, con);

                con.Open();
                cmd.ExecuteReader();
                con.Close();
                pictureBox10.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
