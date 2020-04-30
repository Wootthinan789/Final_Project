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
         List<string> ProductID = new List<string>();
         List<string> ProductName = new List<string>();
         List<string> Price = new List<string>();

         List<string> StaffID2 = new List<string>();
         List<string> StaffID = new List<string>();
         List<string> StaffCode = new List<string>();
         List<string> StaffName = new List<string>();
         List<string> Gender = new List<string>();
         List<string> StaffPassword = new List<string>();
         List<string> StaffLevel = new List<string>();
        public Form10()
        {
            InitializeComponent();
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            comboBox8.Enabled = false;
            comboBox9.Enabled = false;
            textBox8.Enabled = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            comboBox5.Text = "-";
            comboBox6.Text = "-";
            comboBox7.Text = "-";
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
            groupBox7.Visible = false;
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
                MessageBox.Show("อัพเดตแล้ว","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("กรุณาเลือกข้อมูล","",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            groupBox7.Visible = false;

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
            int ch = 0;
            for (int i = 0; i < StaffID.Count; ++i)
            {
                if (StaffID[i] == comboBox4.Text)
                {
                    if (StaffLevel[i] == "Admin") 
                    {
                        ch = 1;
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
            if (ch == 1)
            {
                MessageBox.Show("ข้อมูล Admin ไม่ได้รับอนุญาตให้แก้ไข");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox10.Text);
                int b = Convert.ToInt32(textBox11.Text);
                string sql10 = "INSERT INTO `staffs`(`StaffID`, `StaffCode`, `StaffName`, `Gender`, `StaffPassword`, `StaffLevel`) VALUES ('"+ textBox10.Text + "','"+ textBox11.Text + "','"+ textBox12.Text + "','"+ comboBox3 .Text+ "','"+ textBox14.Text + "','"+ comboBox2.Text + "')";
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd2 = new MySqlCommand(sql10, con1);

                con1.Open();
                cmd2.ExecuteReader();
                con1.Close();
                MessageBox.Show("สมัครแล้ว","",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
            if (textBox10.Text != "")
            {
                MessageBox.Show("อัพเดตแล้ว", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            if (textBox10.Text != "") 
            {
                MessageBox.Show("ลบข้อมูลแล้ว", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            groupBox7.Visible = false;

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
            groupBox7.Visible = false;

            string sel = "SELECT * FROM staffs WHERE StaffLevel <> 'Admin' AND StaffLevel <> 'Manager'";
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
            groupBox7.Visible = false;

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
            groupBox7.Visible = false;

            string sel11 = "SELECT ProductName, Amount, Quantity,  YEAR(SaleDateTime) AS YEAR, MONTH(SaleDateTime) AS MONTH, DAY(SaleDateTime) AS DAY FROM sales, sale_details, products WHERE sales.SaleID = sale_details.SaleID AND products.ProductID = sale_details.ProductID";
            MySqlConnection con11 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd11 = new MySqlCommand(sel11, con11);

            con11.Open();
            DataSet ds = new DataSet();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd11);
            da.Fill(ds);
            dataGridView4.DataSource = ds.Tables[0].DefaultView;

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
            List<string> ProductName = new List<string>();
            List<string> Amount = new List<string>();
            List<string> YEAR = new List<string>();
            List<string> MONTH = new List<string>();
            List<string> DAY = new List<string>();
            List<string> Quantity = new List<string>();
            string sel = "SELECT ProductName, Amount, Quantity,  YEAR(SaleDateTime) AS YEAR, MONTH(SaleDateTime) AS MONTH, DAY(SaleDateTime) AS DAY FROM sales, sale_details, products WHERE sales.SaleID = sale_details.SaleID AND products.ProductID = sale_details.ProductID";
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(sel, con);

            con.Open();


            MySqlDataReader reader0 = cmd.ExecuteReader();


            while (reader0.Read())
            {
                ProductName.Add(reader0.GetString("ProductName"));
                Quantity.Add(reader0.GetString("Quantity"));
                Amount.Add(reader0.GetString("Amount"));
                YEAR.Add(reader0.GetString("YEAR"));
                MONTH.Add(reader0.GetString("MONTH"));
                DAY.Add(reader0.GetString("DAY"));
            }
            int qu = 0;
            int sum = 0;
            int chek = 0;
            for (int i = 0; i < ProductName.Count; ++i)
            {
                if (comboBox7.Text == "-")                  //วัน
                {
                    if (comboBox6.Text == "-")              //เดือน
                    {
                        if (comboBox5.Text == "-")            //year
                        {
                            chek = 1;
                        }
                        else
                        {
                            if (comboBox5.Text == YEAR[i])
                            {
                                string sqly = "SELECT ProductName, Amount, Quantity, YEAR(SaleDateTime) AS YEAR, MONTH(SaleDateTime) AS MONTH, DAY(SaleDateTime) AS DAY FROM sales, sale_details, products WHERE sales.SaleID = sale_details.SaleID AND products.ProductID = sale_details.ProductID AND YEAR(SaleDateTime) = '"+comboBox5.Text+"' ";
                                MySqlConnection cony = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                                MySqlCommand cmdy = new MySqlCommand(sqly, cony);

                                cony.Open();
                                DataSet dsy = new DataSet();

                                MySqlDataAdapter day = new MySqlDataAdapter(cmdy);
                                day.Fill(dsy);
                                dataGridView4.DataSource = dsy.Tables[0].DefaultView;

                                qu += Convert.ToInt32(Quantity[i]);
                                sum += Convert.ToInt32(Amount[i]);
                            }
                        }
                    }
                    else
                    {
                        if (comboBox5.Text == YEAR[i])
                        {
                            if (comboBox6.Text == MONTH[i]) 
                            {
                                string sqlm = "SELECT ProductName, Amount, Quantity, YEAR(SaleDateTime) AS YEAR, MONTH(SaleDateTime) AS MONTH, DAY(SaleDateTime) AS DAY FROM sales, sale_details, products WHERE sales.SaleID = sale_details.SaleID AND products.ProductID = sale_details.ProductID AND YEAR(SaleDateTime) = '"+comboBox5.Text+"' AND MONTH(SaleDateTime) = '"+comboBox6.Text+"' ";
                                MySqlConnection conm = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                                MySqlCommand cmdm = new MySqlCommand(sqlm, conm);

                                conm.Open();
                                DataSet dsm = new DataSet();

                                MySqlDataAdapter dam = new MySqlDataAdapter(cmdm);
                                dam.Fill(dsm);
                                dataGridView4.DataSource = dsm.Tables[0].DefaultView;

                                qu += Convert.ToInt32(Quantity[i]);
                                sum += Convert.ToInt32(Amount[i]);
                            }
                        }
                    } 
                }
                else
                {
                    if (comboBox5.Text == YEAR[i])
                    {
                        if (comboBox6.Text == MONTH[i])
                        {
                            if (comboBox7.Text == DAY[i]) 
                            {
                                string sqld = "SELECT ProductName, Quantity,Amount , YEAR(SaleDateTime) AS YEAR, MONTH(SaleDateTime) AS MONTH, DAY(SaleDateTime) AS DAY FROM sales, sale_details, products WHERE sales.SaleID = sale_details.SaleID AND products.ProductID = sale_details.ProductID AND YEAR(SaleDateTime) = '" + comboBox5.Text+"' AND MONTH(SaleDateTime) = '"+comboBox6.Text+"' AND DAY(SaleDateTime) = '"+comboBox7.Text+"'";
                                MySqlConnection cond = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                                MySqlCommand cmdd = new MySqlCommand(sqld, cond);

                                cond.Open();
                                DataSet dsd = new DataSet();

                                MySqlDataAdapter dad = new MySqlDataAdapter(cmdd);
                                dad.Fill(dsd);
                                dataGridView4.DataSource = dsd.Tables[0].DefaultView;

                                qu += Convert.ToInt32(Quantity[i]);
                                sum += Convert.ToInt32(Amount[i]);
                            }
                        }
                    }
                }
            }
            if(chek == 1)
            {
                MessageBox.Show("โปรดตรวจวันที่");
            }
            label10.Text = Convert.ToString(qu);
            label11.Text = Convert.ToString(sum);

            /*
            if (comboBox6.Text == "-" && comboBox7.Text == "-") 
            {
                List<string> SaleDateTime = new List<string>();
                List<string> SaleID = new List<string>();
                List<string> CustomerID = new List<string>();
                List<string> StaffID = new List<string>();
                List<string> GrandTotal = new List<string>();
                string sel = "SELECT * FROM sales WHERE SaleDateTime >= '"+ comboBox5.Text + "-01-01 00:00:00' AND SaleDateTime <= '"+ comboBox5.Text + "-12-30 23:59:59'";
                MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sel, con);

                con.Open();
                MySqlDataReader reader0 = cmd.ExecuteReader();
                while (reader0.Read())
                {
                    SaleDateTime.Add(reader0.GetString("SaleDateTime"));
                    SaleID.Add(reader0.GetString("SaleID"));
                    CustomerID.Add(reader0.GetString("CustomerID"));
                    StaffID.Add(reader0.GetString("StaffID"));
                    GrandTotal.Add(reader0.GetString("GrandTotal"));
                }
                int sump = 0;
                for (int i = 0; i < SaleDateTime.Count; ++i)
                {
                    sump += Convert.ToInt32(GrandTotal[i]);
                }
                label10.Text = Convert.ToString("-");
                label11.Text = Convert.ToString(sump);
            }
            */

            /*
            if ((comboBox5.Text == "-" && comboBox6.Text == "-" && comboBox7.Text == "-") || (comboBox5.Text == "" && comboBox6.Text == "" && comboBox7.Text == ""))
            {
                MessageBox.Show("โปรดกรอกข้อมูลให้ถูกต้อง");
            }
            */
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            /*DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0].DefaultView;*/
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
            for (int i = 0; i < SaleDetailID.Count; ++i)
            {
                sum_Quantity += Convert.ToInt32(Quantity[i]);
                sum_Amount += Convert.ToInt32(Amount[i]);
            }
            label10.Text = Convert.ToString(sum_Quantity);
            label11.Text = Convert.ToString(sum_Amount);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int randomnumber = random.Next(100, 999);
            textBox11.Text = Convert.ToString(randomnumber);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
            Form10 form101 = new Form10();
            form101.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
            Form10 form101 = new Form10();
            form101.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            if (MessageBox.Show("คุณต้องการลบใช่หรือไม่","แจ้งเตือน",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (row != 0)
                {
                    string sel = "SELECT * FROM `customers`";
                    MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                    MySqlCommand cmd = new MySqlCommand(sel, con);

                    con.Open();
                    MySqlDataReader reader0 = cmd.ExecuteReader();
                    /////

                    /////
                    List<string> ID = new List<string>();

                    while (reader0.Read())
                    {
                        ID.Add(reader0.GetString("CustomerID"));
                    }

                    string selb = "DELETE FROM `customers` WHERE CustomerID ='"+ID[row]+"' ";
                    MySqlConnection conb = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                    MySqlCommand cmdb = new MySqlCommand(selb, conb);


                    conb.Open();
                    cmdb.ExecuteReader();
                    con.Close();


                    dataGridView1.Rows.RemoveAt(row);
                    MessageBox.Show("ลบแล้ว");
                }
                else
                {
                    MessageBox.Show("ข้อมูลนี้ไม่สามารถลบได้","เตือน" ,MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = true;


            string sel = "SELECT SaleID, SaleDateTime, CustomerName,StaffName ,GrandTotal FROM sales,staffs,customers WHERE customers.CustomerID = sales.CustomerID AND staffs.StaffID = sales.StaffID";
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(sel, con);

            con.Open();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            dataGridView5.DataSource = ds.Tables[0].DefaultView;

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox5.Enabled = true;
            comboBox8.Enabled = true;
            comboBox9.Enabled = true;
            textBox8.Enabled = true;
            //int row = dataGridView1.CurrentCell.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow roe = this.dataGridView1.Rows[e.RowIndex];


                textBox4.Text = roe.Cells["CustomerID"].Value.ToString();
                textBox5.Text = roe.Cells["CustomerName"].Value.ToString();
                comboBox8.Text = roe.Cells["Gender"].Value.ToString();
                comboBox9.Text = roe.Cells["CustomerType"].Value.ToString();
                textBox8.Text = roe.Cells["CustomerTelNo"].Value.ToString();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                string sel = "UPDATE customers SET CustomerID='" + textBox4.Text + "',CustomerName='" + textBox5.Text + "',Gender='" + comboBox8.Text + "',CustomerType='" + comboBox9.Text + "',CustomerTelNo='" + textBox8.Text + "' WHERE CustomerID='" + textBox4.Text + "'";
                MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sel, con);

                con.Open();
                cmd.ExecuteReader();
                con.Close();

                MessageBox.Show("อัพเดตแล้ว", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                Form10 form10 = new Form10();
                form10.Show();
            }
            catch
            {
                MessageBox.Show("ERROR","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
