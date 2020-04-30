using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffe_house
{
    public partial class Form3 : Form
    {
        static int num = 1;
        public Form3()
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
                label3.Text = "NO login";
            }
            else
            {
                pictureBox5.Hide();
                label3.Text = "StaffID = " + staffID[0];
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO `from_save`(`formid`) VALUES ('3')";
            MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(sql, con1);

            con1.Open();
            cmd.ExecuteReader();
            con1.Close();

<<<<<<< HEAD
            Form9 form9 = new Form9();
            form9.Show();
=======
            Form9 form9 = new Form9("1");
            form9.Show(this);
>>>>>>> 6fc7818ca239d7e8f369de95b44befe05fea0ae5

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6("3");
            form6.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*
            string sql = "SELECT * FROM `mamory`";
            sql = "INSERT INTO mamory (proid) VALUES ('614002')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
            MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(sql, con1);

            con1.Open();
            cmd.ExecuteReader();
            con1.Close();
            */
            if (label1.Text == "1")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614002')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "2")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614006')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "3")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614010')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "4")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614014')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "5")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614018')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "6")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614022')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "7")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614026')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "8")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614030')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "9")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614034')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "10")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614038')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "11")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614042')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "12")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614046')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "13")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614050')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "14")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614054')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "15")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614058')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "16")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614062')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            Form5 form5 = new Form5();
            form5.Show();
        }

        public void pictureBox6_Click(object sender, EventArgs e)
        {
            /*
            string sql = "SELECT * FROM `mamory`";
            sql = "INSERT INTO mamory (proid) VALUES ('614001')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
            MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(sql, con1);

            con1.Open();
            cmd.ExecuteReader();
            con1.Close();
            */
            if (label1.Text == "1")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614001')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "2")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614005')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "3")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614009')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "4")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614013')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "5")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614017')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "6")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614021')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "7")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614025')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "8")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614029')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "9")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614033')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "10")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614037')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "11")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614041')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "12")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614045')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "13")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614049')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "14")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614053')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "15")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614057')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "16")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614061')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }

            Form5 form5 = new Form5();
            form5.Show();
        }


    
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            /*
            string sql = "SELECT * FROM `mamory`";
            sql = "INSERT INTO mamory (proid) VALUES ('614003')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
            MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(sql, con1);

            con1.Open();
            cmd.ExecuteReader();
            con1.Close();
            */
            if (label1.Text == "1")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614003')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "2")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614007')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "3")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614011')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "4")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614015')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "5")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614019')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "6")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614023')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "7")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614027')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "8")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614031')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "9")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614035')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "10")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614039')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "11")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614043')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "12")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614047')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "13")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614051')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "14")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614055')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "15")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614059')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "16")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614063')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }

            Form5 form5 = new Form5();
            form5.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            /*
            string sql = "SELECT * FROM `mamory`";
            sql = "INSERT INTO mamory (proid) VALUES ('614004')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
            MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(sql, con1);

            con1.Open();
            cmd.ExecuteReader();
            con1.Close();
            */
            if (label1.Text == "1")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614004')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "2")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614008')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "3")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614012')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "4")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614016')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "5")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614020')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "6")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614024')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "7")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614028')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "8")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614032')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "9")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614036')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "10")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614040')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "11")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614044')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "12")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614048')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "13")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614052')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "14")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614056')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "15")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614060')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }
            if (label1.Text == "16")
            {
                string sql = "SELECT * FROM `mamory`";
                sql = "INSERT INTO mamory (proid) VALUES ('614064')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                con1.Close();
            }

            Form5 form5 = new Form5();
            form5.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }




        private void pictureBox9_Click_1(object sender, EventArgs e)
        {


            num = Convert.ToInt32(label1.Text);
            if (num != 1)
            {                                              
                num -= 1;
                label1.Text = Convert.ToString(num);
            }
            if (label1.Text == "1")
            {
                pictureBox6.LoadAsync(@"F:\x\614001.png");
                pictureBox1.LoadAsync(@"F:\x\614002.png");
                pictureBox7.LoadAsync(@"F:\x\614003.png");
                pictureBox8.LoadAsync(@"F:\x\614004.png");
            }
            if (label1.Text == "2")
            {
                pictureBox6.LoadAsync(@"F:\x\614005.png");
                pictureBox1.LoadAsync(@"F:\x\614006.png");
                pictureBox7.LoadAsync(@"F:\x\614007.png");
                pictureBox8.LoadAsync(@"F:\x\614008.png");
            }
            if (label1.Text == "3")
            {
                pictureBox6.LoadAsync(@"F:\x\614009.png");
                pictureBox1.LoadAsync(@"F:\x\614010.png");
                pictureBox7.LoadAsync(@"F:\x\614011.png");
                pictureBox8.LoadAsync(@"F:\x\614012.png");
            }
            if (label1.Text == "4")
            {
                pictureBox6.LoadAsync(@"F:\x\614013.png");
                pictureBox1.LoadAsync(@"F:\x\614014.png");
                pictureBox7.LoadAsync(@"F:\x\614015.png");
                pictureBox8.LoadAsync(@"F:\x\614016.png");
            }
            if (label1.Text == "5")
            {
                pictureBox6.LoadAsync(@"F:\x\614017.png");
                pictureBox1.LoadAsync(@"F:\x\614018.png");
                pictureBox7.LoadAsync(@"F:\x\614019.png");
                pictureBox8.LoadAsync(@"F:\x\614020.png");
            }
            if (label1.Text == "6")
            {
                pictureBox6.LoadAsync(@"F:\x\614021.png");
                pictureBox1.LoadAsync(@"F:\x\614022.png");
                pictureBox7.LoadAsync(@"F:\x\614023.png");
                pictureBox8.LoadAsync(@"F:\x\614024.png");
            }
            if (label1.Text == "7")
            {
                pictureBox6.LoadAsync(@"F:\x\614025.png");
                pictureBox1.LoadAsync(@"F:\x\614026.png");
                pictureBox7.LoadAsync(@"F:\x\614027.png");
                pictureBox8.LoadAsync(@"F:\x\614028.png");
            }
            if (label1.Text == "8")
            {
                pictureBox6.LoadAsync(@"F:\x\614029.png");
                pictureBox1.LoadAsync(@"F:\x\614030.png");
                pictureBox7.LoadAsync(@"F:\x\614031.png");
                pictureBox8.LoadAsync(@"F:\x\614032.png");
            }
            if (label1.Text == "9")
            {
                pictureBox6.LoadAsync(@"F:\x\614033.png");
                pictureBox1.LoadAsync(@"F:\x\614034.png");
                pictureBox7.LoadAsync(@"F:\x\614035.png");
                pictureBox8.LoadAsync(@"F:\x\614036.png");
            }
            if (label1.Text == "10")
            {
                pictureBox6.LoadAsync(@"F:\x\614037.png");
                pictureBox1.LoadAsync(@"F:\x\614038.png");
                pictureBox7.LoadAsync(@"F:\x\614039.png");
                pictureBox8.LoadAsync(@"F:\x\614040.png");
            }
            if (label1.Text == "11")
            {
                pictureBox6.LoadAsync(@"F:\x\614041.png");
                pictureBox1.LoadAsync(@"F:\x\614042.png");
                pictureBox7.LoadAsync(@"F:\x\614043.png");
                pictureBox8.LoadAsync(@"F:\x\614044.png");
            }
            if (label1.Text == "12")
            {
                pictureBox6.LoadAsync(@"F:\x\614045.png");
                pictureBox1.LoadAsync(@"F:\x\614046.png");
                pictureBox7.LoadAsync(@"F:\x\614047.png");
                pictureBox8.LoadAsync(@"F:\x\614048.png");
            }
            if (label1.Text == "13")
            {
                pictureBox6.LoadAsync(@"F:\x\614049.png");
                pictureBox1.LoadAsync(@"F:\x\614050.png");
                pictureBox7.LoadAsync(@"F:\x\614051.png");
                pictureBox8.LoadAsync(@"F:\x\614052.png");
            }
            if (label1.Text == "14")
            {
                pictureBox6.LoadAsync(@"F:\x\614053.png");
                pictureBox1.LoadAsync(@"F:\x\614054.png");
                pictureBox7.LoadAsync(@"F:\x\614055.png");
                pictureBox8.LoadAsync(@"F:\x\614056.png");
            }
            if (label1.Text == "15")
            {
                pictureBox6.LoadAsync(@"F:\x\614057.png");
                pictureBox1.LoadAsync(@"F:\x\614058.png");
                pictureBox7.LoadAsync(@"F:\x\614059.png");
                pictureBox8.LoadAsync(@"F:\x\614060.png");
            }
            if (label1.Text == "16")
            {
                pictureBox6.LoadAsync(@"F:\x\614061.png");
                pictureBox1.LoadAsync(@"F:\x\614062.png");
                pictureBox7.LoadAsync(@"F:\x\614063.png");
                pictureBox8.LoadAsync(@"F:\x\614064.png");
            }

        }
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            List<string> checkproduct = new List<string>();
            string sql8 = "SELECT * FROM `products`";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();

            while (reader8.Read())
            {
                checkproduct.Add(reader8.GetString("ProductID"));
            }
            int max = checkproduct.Count;
            int max2 = max / 4;
            if (num < max2)
            {
                num = Convert.ToInt32(label1.Text);                  //erferjfneirfjeirj
                num += 1;
                label1.Text = Convert.ToString(num);
            }
            else
            {
                MessageBox.Show("สิ้นสุด");
            }

            
            if (label1.Text == "2")
            {
                pictureBox6.LoadAsync(@"F:\x\614005.png");
                pictureBox1.LoadAsync(@"F:\x\614006.png");
                pictureBox7.LoadAsync(@"F:\x\614007.png");
                pictureBox8.LoadAsync(@"F:\x\614008.png");
            }
            if (label1.Text == "3")
            {
                pictureBox6.LoadAsync(@"F:\x\614009.png");
                pictureBox1.LoadAsync(@"F:\x\614010.png");
                pictureBox7.LoadAsync(@"F:\x\614011.png");
                pictureBox8.LoadAsync(@"F:\x\614012.png");
            }
            if (label1.Text == "4")
            {
                pictureBox6.LoadAsync(@"F:\x\614013.png");
                pictureBox1.LoadAsync(@"F:\x\614014.png");
                pictureBox7.LoadAsync(@"F:\x\614015.png");
                pictureBox8.LoadAsync(@"F:\x\614016.png");
            }
            if (label1.Text == "5")
            {
                pictureBox6.LoadAsync(@"F:\x\614017.png");
                pictureBox1.LoadAsync(@"F:\x\614018.png");
                pictureBox7.LoadAsync(@"F:\x\614019.png");
                pictureBox8.LoadAsync(@"F:\x\614020.png");
            }
            if (label1.Text == "6")
            {
                pictureBox6.LoadAsync(@"F:\x\614021.png");
                pictureBox1.LoadAsync(@"F:\x\614022.png");
                pictureBox7.LoadAsync(@"F:\x\614023.png");
                pictureBox8.LoadAsync(@"F:\x\614024.png");
            }
            if (label1.Text == "7")
            {
                pictureBox6.LoadAsync(@"F:\x\614025.png");
                pictureBox1.LoadAsync(@"F:\x\614026.png");
                pictureBox7.LoadAsync(@"F:\x\614027.png");
                pictureBox8.LoadAsync(@"F:\x\614028.png");
            }
            if (label1.Text == "8")
            {
                pictureBox6.LoadAsync(@"F:\x\614029.png");
                pictureBox1.LoadAsync(@"F:\x\614030.png");
                pictureBox7.LoadAsync(@"F:\x\614031.png");
                pictureBox8.LoadAsync(@"F:\x\614032.png");
            }
            if (label1.Text == "9")
            {
                pictureBox6.LoadAsync(@"F:\x\614033.png");
                pictureBox1.LoadAsync(@"F:\x\614034.png");
                pictureBox7.LoadAsync(@"F:\x\614035.png");
                pictureBox8.LoadAsync(@"F:\x\614036.png");
            }
            if (label1.Text == "10")
            {
                pictureBox6.LoadAsync(@"F:\x\614037.png");
                pictureBox1.LoadAsync(@"F:\x\614038.png");
                pictureBox7.LoadAsync(@"F:\x\614039.png");
                pictureBox8.LoadAsync(@"F:\x\614040.png");
            }
            if (label1.Text == "11")
            {
                pictureBox6.LoadAsync(@"F:\x\614041.png");
                pictureBox1.LoadAsync(@"F:\x\614042.png");
                pictureBox7.LoadAsync(@"F:\x\614043.png");
                pictureBox8.LoadAsync(@"F:\x\614044.png");
            }
            if (label1.Text == "12")
            {
                pictureBox6.LoadAsync(@"F:\x\614045.png");
                pictureBox1.LoadAsync(@"F:\x\614046.png");
                pictureBox7.LoadAsync(@"F:\x\614047.png");
                pictureBox8.LoadAsync(@"F:\x\614048.png");
            }
            if (label1.Text == "13")
            {
                pictureBox6.LoadAsync(@"F:\x\614049.png");
                pictureBox1.LoadAsync(@"F:\x\614050.png");
                pictureBox7.LoadAsync(@"F:\x\614051.png");
                pictureBox8.LoadAsync(@"F:\x\614052.png");
            }
            if (label1.Text == "14")
            {
                pictureBox6.LoadAsync(@"F:\x\614053.png");
                pictureBox1.LoadAsync(@"F:\x\614054.png");
                pictureBox7.LoadAsync(@"F:\x\614055.png");
                pictureBox8.LoadAsync(@"F:\x\614056.png");
            }
            if (label1.Text == "15")
            {
                pictureBox6.LoadAsync(@"F:\x\614057.png");
                pictureBox1.LoadAsync(@"F:\x\614058.png");
                pictureBox7.LoadAsync(@"F:\x\614059.png");
                pictureBox8.LoadAsync(@"F:\x\614060.png");
            }
            if (label1.Text == "16")
            {
                pictureBox6.LoadAsync(@"F:\x\614061.png");
                pictureBox1.LoadAsync(@"F:\x\614062.png");
                pictureBox7.LoadAsync(@"F:\x\614063.png");
                pictureBox8.LoadAsync(@"F:\x\614064.png");
            }
        }





        private void pictureBox10_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM `sales`";
            MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(sql, con1);

            con1.Open();
            string c = "";
            MySqlDataReader reader = cmd.ExecuteReader();
            List<string> AuthorList = new List<string>();
            while (reader.Read())
            {
                c += (reader.GetString("SaleID"));
                AuthorList.Add(reader.GetString("SaleID"));
            }
            for (int i = 0; i < AuthorList.Count; ++i)
            {
                if (textBox1.Text == AuthorList[i])
                {
                    Form5 form5 = new Form5();
                    form5.Show();
                }
                else
                {

                }
            }
        }

        private void pictureBox11_Click_1(object sender, EventArgs e)
        {
            label3.Text = "NO login";
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
