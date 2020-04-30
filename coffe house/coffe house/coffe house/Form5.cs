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
    public partial class Form5 : Form
    {
        static List<string> name = new List<string>();
        static List<string> pri = new List<string>();
        static string proid = "";
        public Form5()
        {
            
            //string data = "614007";




            InitializeComponent();
            List<string> AuthorList = new List<string>();

            string sql3 = "SELECT * FROM `mamory`";
            MySqlConnection con3 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd3 = new MySqlCommand(sql3, con3);

            con3.Open();
            MySqlDataReader reader3 = cmd3.ExecuteReader();
            List<string> AuthorList3 = new List<string>();
            while (reader3.Read())
            {
                AuthorList3.Add(reader3.GetString("proid"));
            }



            string sql = "SELECT * FROM `products`";
            MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(sql, con1);

            con1.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                AuthorList.Add(reader.GetString("ProductID"));
                name.Add(reader.GetString("ProductName"));
                pri.Add(reader.GetString("Price"));
            }
            for (int i = 0; i < AuthorList.Count; ++i)
            {
                //MessageBox.Show("in if" + AuthorList3[1]+AuthorList[i]);
                if (AuthorList3[1] == AuthorList[i])
                {
                    //MessageBox.Show("in if" + AuthorList[i]);
                    proid = AuthorList[i];
                    pictureBox1.LoadAsync(@"F:\x\" + AuthorList[i]+".png");
                    //MessageBox.Show("in if"+AuthorList[i]);
                    label2.Text = name[i];
                    label8.Text = pri[i];

                    string sql2 = "DELETE FROM mamory WHERE proid='" + AuthorList[i] + "'";
                    MySqlConnection con2 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                    MySqlCommand cmd2 = new MySqlCommand(sql2, con2);

                    con2.Open();
                    cmd2.ExecuteReader();
                    //MessageBox.Show("ลบ");
                    con2.Close();
                }
            }

            comboBox1.Text = "1";

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(proid,comboBox1.Text);

            string sql = "SELECT * FROM `basket`";
            sql = "INSERT INTO basket (ProductID,Quantity) VALUES ('" + proid +"','" + comboBox1.Text + "' )"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
            MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(sql, con1);

            con1.Open();
            cmd.ExecuteReader();
            MessageBox.Show("เพิ่มแล้ว","แจ้งเตือน",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Hide();
            con1.Close();
        }
    }
}
