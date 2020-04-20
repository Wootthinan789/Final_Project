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
        public Form5()
        {

            //string data = "614007";

            


            InitializeComponent();

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
            List<string> AuthorList = new List<string>();
            List<string> name = new List<string>();
            List<string> pri = new List<string>();
            while (reader.Read())
            {
                AuthorList.Add(reader.GetString("ProductID"));
                name.Add(reader.GetString("ProductName"));
                pri.Add(reader.GetString("Price"));
            }
            
            for (int i = 0; i < AuthorList.Count; ++i)
            {
                if (AuthorList3[1] == AuthorList[i])
                {
                    pictureBox1.LoadAsync(@"C:\Users\chan\Pictures\x\"+AuthorList[i]+".png");
                    MessageBox.Show("in if"+AuthorList[i]);
                    label2.Text = name[i];
                    label8.Text = pri[i];

                    string sql2 = "DELETE FROM mamory WHERE proid='" + AuthorList[i] + "'";
                    MySqlConnection con2 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                    MySqlCommand cmd2 = new MySqlCommand(sql2, con2);

                    con2.Open();
                    cmd2.ExecuteReader();
                    MessageBox.Show("ลบ");
                    con2.Close();
                }
            }


            
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
