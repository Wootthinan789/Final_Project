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
        List<string> staffID = new List<string>();
        List<string> save = new List<string>();
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
            string sql = "INSERT INTO `from_save`(`formid`) VALUES ('1')";
            MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(sql, con1);

            con1.Open();
            cmd.ExecuteReader();
            con1.Close();

            Form9 form9 = new Form9("1");
            form9.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string bb = "1";
            Form6 form6 = new Form6(bb);
            form6.Show();
            /*
            string sel = "SELECT * FROM `login_save`";
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(sel, con);

            con.Open();
            MySqlDataReader reader0 = cmd.ExecuteReader();
            while (reader0.Read())
            {
                save.Add(reader0.GetString("staffsID"));
            }
            if (save.Count == 0)
            {
                Form6 form6 = new Form6();
                form6.Show();
            }
            else
            {
                Form8 form8 = new Form8();
                form8.Show();
            }
            
    */
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
                pictureBox5.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
