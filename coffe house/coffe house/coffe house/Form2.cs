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
   
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            List<string> staffID = new List<string>();
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
                pictureBox11.Hide();
                label2.Text = "NO login";
            }
            else
            {
                pictureBox5.Hide();
                label2.Text = "StaffID = " + staffID[0];
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO `from_save`(`formid`) VALUES ('2')";
            MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(sql, con1);

            con1.Open();
            cmd.ExecuteReader();
            con1.Close();

            Form9 form9 = new Form9();
            form9.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
                 
            
            string sql = "SELECT * FROM `mamory`";
            sql = "INSERT INTO mamory (proid) VALUES ('614007')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
            MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(sql, con1);

            con1.Open();
            cmd.ExecuteReader();
            con1.Close();

            Form5 form5 = new Form5();
            form5.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM `mamory`";
            sql = "INSERT INTO mamory (proid) VALUES ('614021')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
            MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(sql, con1);

            con1.Open();
            cmd.ExecuteReader();
            con1.Close();

            Form5 form5 = new Form5();
            form5.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            string sql = "SELECT * FROM `mamory`";
            sql = "INSERT INTO mamory (proid) VALUES ('614008')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
            MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(sql, con1);

            con1.Open();
            cmd.ExecuteReader();
            con1.Close();

            Form5 form5 = new Form5();
            form5.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM `mamory`";
            sql = "INSERT INTO mamory (proid) VALUES ('614006')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
            MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(sql, con1);

            con1.Open();
            cmd.ExecuteReader();
            con1.Close();

            Form5 form5 = new Form5();
            form5.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //var random = new Random();
            //int randomnumber = random.Next(00000,99999);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            label2.Text = "NO login";
            string del = "DELETE FROM `login_save` WHERE staffsID";
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(del, con);

            con.Open();
            cmd.ExecuteReader();
            con.Close();
            pictureBox11.Hide();
            pictureBox5.Show();
        }
    }
}
