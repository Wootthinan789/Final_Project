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

        public Form5(string data)
        {
            MessageBox.Show("ok");
            InitializeComponent();
            if (data == null)
            {
                MessageBox.Show("ไม่พบข้อมูล");
            }
            else
            {
                string sql = "SELECT * FROM `products`";
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                List<string> AuthorList = new List<string>();
                while (reader.Read())
                {
                    AuthorList.Add(reader.GetString("ProductID"));
                }
                //MessageBox.Show("f5"+data);
                for (int i = 0; i < AuthorList.Count; ++i)
                {
                    if (data == AuthorList[i])
                    {
                        MessageBox.Show(AuthorList[i]);
                        //pictureBox1.LoadAsync(@"C:\Users\chan\Pictures\x\"+AuthorList[i]+".png");
                        //pictureBox1.Image =new Bitmap("C:\\Users\\chan\\Pictures\\x\\614006.png");
                    }
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
