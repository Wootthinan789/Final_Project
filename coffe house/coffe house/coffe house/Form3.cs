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
        static string[] mamo = {"0","1"};
        static int num = 1;
        public Form3()
        {
            InitializeComponent();

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

            num = Convert.ToInt32(label1.Text);                  //erferjfneirfjeirj
            num += 1;
            label1.Text = Convert.ToString(num);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        public void pictureBox6_Click(object sender, EventArgs e)
        {
            //Form5 form5 = new Form5();
            //form5.Show();

            string sql = "SELECT * FROM `sales`";
            //sql = "INSERT INTO sales (SaleID,SaleDateTime,CustomerID) VALUES ('16','2020-04-03 05:30:19','10')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
            MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(sql,con1);
            
            con1.Open();
            string c = "";
            MySqlDataReader reader = cmd.ExecuteReader();
            List<string> AuthorList = new List<string>();
            while (reader.Read())
            {

                //label3.Text = (reader.GetString("SaleID"));
                //MessageBox.Show(reader.GetString("SaleID"));
                c += (reader.GetString("SaleID"));
                AuthorList.Add(reader.GetString("SaleID"));
            }
            //cmd.ExecuteNonQuery();
            //con1.Close();
            /*
            AuthorList.Add("Mahesh Chand");
            AuthorList.Add("Praveen Kumar");
            AuthorList.Add("Raj Kumar");
            AuthorList.Add("Nipun Tomar");
            AuthorList.Add("Dinesh Beniwal");
            */
            for (int i =0;i < AuthorList.Count; ++i)
            {
                if (textBox1.Text == AuthorList[i])
                {
                    MessageBox.Show("เจอ");
                }
                else
                {
                    
                }
                //label3.Text = AuthorList[i];
                //MessageBox.Show(AuthorList[i]);
            }

        }


    
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
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
    }
}
