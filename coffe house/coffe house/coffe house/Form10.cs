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
    public partial class Form10 : Form
    {
        static List<string> ProductID = new List<string>();
        static List<string> ProductName = new List<string>();
        static List<string> Price = new List<string>();

        static List<string> StaffID2 = new List<string>();
        static List<string> StaffID = new List<string>();
        static List<string> StaffCode = new List<string>();
        static List<string> StaffName = new List<string>();
        static List<string> Gender = new List<string>();
        static List<string> StaffPassword = new List<string>();
        static List<string> StaffLevel = new List<string>();
        public Form10()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < ProductID.Count; ++i)
            {
                if (ProductID[i]  == comboBox1.Text)
                {
                    pictureBox1.LoadAsync(@"F:\x\" + ProductID[i] + ".png");
                    textBox1.Text = ProductID[i];
                    textBox2.Text = ProductName[i];
                    textBox3.Text = Price[i];
                }
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            string sel = "SELECT * FROM `products`";
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(sel, con);

            con.Open();
            MySqlDataReader reader0 = cmd.ExecuteReader();
            while (reader0.Read())
            {
                ProductID.Add(reader0.GetString("ProductID"));
                ProductName.Add(reader0.GetString("ProductName"));
                Price.Add(reader0.GetString("Price"));
            }
            for (int i = 0; i < ProductID.Count; ++i)
            {
                comboBox1.Items.Add(ProductID[i]);
            }

            string sel2 = "SELECT * FROM `staffs`";
            MySqlConnection con2 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd2 = new MySqlCommand(sel2, con2);

            con2.Open();
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                StaffID2.Add(reader2.GetString("StaffID"));
            }
            for (int l = 0; l < StaffID2.Count; ++l)
            {
                comboBox4.Items.Add(StaffID2[l]);
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int ff = Convert.ToInt32(textBox3.Text);
                string sel = "UPDATE `products` SET `ProductID`='" + textBox1.Text + "',`ProductName`='" + textBox2.Text + "',`Price`='" + textBox3.Text + "',`ProductDetail`='-' WHERE ProductID = '" + comboBox1.Text + "'";
                MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sel, con);

                con.Open();
                MySqlDataReader reader0 = cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("อัพเดตแล้ว");
            }
            catch
            {
                MessageBox.Show("กรุณาเลือกข้อมูล");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {







            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = true;
            groupBox6.Visible = false;

            string sel = "SELECT * FROM `staffs`";
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(sel, con);

            con.Open();
            MySqlDataReader reader0 = cmd.ExecuteReader();
            while (reader0.Read())
            {
                StaffID.Add(reader0.GetString("StaffID"));
                StaffCode.Add(reader0.GetString("StaffCode"));
                StaffName.Add(reader0.GetString("StaffName"));
                Gender.Add(reader0.GetString("Gender"));
                StaffPassword.Add(reader0.GetString("StaffPassword"));
                StaffLevel.Add(reader0.GetString("StaffLevel"));
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < StaffID.Count; ++i)
            {
                if (StaffID[i] == comboBox4.Text)
                {
                    if (StaffLevel[i] == "Admin") 
                    {
                        MessageBox.Show("ข้อมูล Admin ไม่ได้รับอนุญาตให้แก้ไข");
                        comboBox4.Text = StaffID[0];
                    }
                    else
                    {
                        textBox10.Text = StaffID[i];
                        textBox11.Text = StaffCode[i];
                        textBox12.Text = StaffName[i];
                        comboBox3.Text = Gender[i];
                        textBox14.Text = StaffPassword[i];
                        comboBox2.Text = StaffLevel[i];
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string sql10 = "INSERT INTO `staffs`(`StaffID`, `StaffCode`, `StaffName`, `Gender`, `StaffPassword`, `StaffLevel`) VALUES ('"+ textBox10.Text + "','"+ textBox11.Text + "','"+ textBox12.Text + "','"+ comboBox3 .Text+ "','"+ textBox14.Text + "','"+ comboBox2.Text + "')";
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd2 = new MySqlCommand(sql10, con1);

                con1.Open();
                cmd2.ExecuteReader();
                con1.Close();
                MessageBox.Show("สมัครแล้ว");
                //Form10 form10 = new Form10();
                //form10.Hide();
                //form10.Show();

            }
            catch
            {
                MessageBox.Show("เกิดปัญหาในการสมัคร โปรดติดต่อ  Admin: Chan");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            var random = new Random();
            int randomnumber = random.Next(10000, 99999);
            textBox10.Text = Convert.ToString(randomnumber);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string sel = "UPDATE `products` SET `ProductID`='" + textBox1.Text + "',`ProductName`='" + textBox2.Text + "',`Price`='" + textBox3.Text + "',`ProductDetail`='-' WHERE StaffID  = '" + comboBox4.Text + "'";
            sel = "UPDATE `staffs` SET `StaffID`='"+textBox10.Text+"',`StaffCode`='" + textBox11.Text + "',`StaffName`='"+ textBox12.Text + "',`Gender`='"+ comboBox3.Text + "',`StaffPassword`='"+ textBox14.Text + "',`StaffLevel`='"+ comboBox2.Text + "' WHERE StaffID  = '" + comboBox4.Text + "'";
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(sel, con);

            con.Open();
            MySqlDataReader reader0 = cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("อัพเดตแล้ว");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            comboBox4.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            comboBox3.Text = "";
            textBox14.Text = "";
            comboBox2.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string jk =  comboBox4.Text;
            string del = "DELETE FROM `staffs` WHERE StaffID='"+jk+"'";
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(del, con);

            con.Open();
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("ลบข้อมูลแล้ว");
            //Form10 form10 = new Form10();
            //form10.Hide();
            //form10.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            string sel = "SELECT * FROM `customers`";
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(sel, con);

            con.Open();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            string sel = "SELECT * FROM `staffs`";
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(sel, con);

            con.Open();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0].DefaultView;

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            string sel = "SELECT SaleDetailID,  ProductName, Quantity, Amount FROM sale_details, products WHERE sale_details.ProductID = products.ProductID";
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(sel, con);

            con.Open();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0].DefaultView;

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;

            List<string> SaleDetailID = new List<string>();
            List<string> SaleID = new List<string>();
            List<string> ProductID3 = new List<string>();
            List<string> Price3 = new List<string>();
            List<string> Quantity = new List<string>();
            List<string> Amount = new List<string>();
            string sel = "SELECT * FROM `sale_details`";
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(sel, con);

            con.Open();
            MySqlDataReader reader0 = cmd.ExecuteReader();
            while (reader0.Read())
            {
                SaleDetailID.Add(reader0.GetString("SaleDetailID"));
                SaleID.Add(reader0.GetString("SaleID"));
                ProductID3.Add(reader0.GetString("ProductID"));
                Price3.Add(reader0.GetString("Price"));
                Quantity.Add(reader0.GetString("Quantity"));
                Amount.Add(reader0.GetString("Amount"));
            }
            int sum_Quantity = 0;
            int sum_Amount = 0;
            for (int i =0; i < SaleDetailID.Count; ++i)
            {
                sum_Quantity += Convert.ToInt32(Quantity[i]);
                sum_Amount += Convert.ToInt32(Amount[i]);
            }
            label10.Text = Convert.ToString(sum_Quantity);
            label11.Text = Convert.ToString(sum_Amount);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (comboBox6.Text == "-" && comboBox7.Text == "-") 
            {
                List<string> SaleDetailID = new List<string>();
                List<string> SaleID = new List<string>();
                List<string> ProductID3 = new List<string>();
                List<string> Price3 = new List<string>();
                List<string> Quantity = new List<string>();
                List<string> Amount = new List<string>();
                string sel = "SELECT * FROM `sales` WHERE year = 2018";
                MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sel, con);

                con.Open();
                MySqlDataReader reader0 = cmd.ExecuteReader();
                while (reader0.Read())
                {
                    SaleDetailID.Add(reader0.GetString("SaleDetailID"));
                    SaleID.Add(reader0.GetString("SaleID"));
                    ProductID3.Add(reader0.GetString("ProductID"));
                    Price3.Add(reader0.GetString("Price"));
                    Quantity.Add(reader0.GetString("Quantity"));
                    Amount.Add(reader0.GetString("Amount"));
                }
            }
        }
    }
}
