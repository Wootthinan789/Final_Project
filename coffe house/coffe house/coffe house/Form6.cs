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
    public partial class Form6 : Form
    {
        List<string> AuthorList8 = new List<string>();
        string data = "";
        public Form6(string bb)
        {
            InitializeComponent();
            data = bb;
            groupBox1.Visible = groupBox1.Visible;
            groupBox2.Visible = groupBox2.Visible;
            groupBox3.Visible = groupBox3.Visible;
            groupBox4.Visible = groupBox4.Visible;
            groupBox6.Visible = groupBox6.Visible; 
            groupBox7.Visible = groupBox7.Visible;
            groupBox8.Visible = groupBox8.Visible;
            groupBox16.Visible = false;
            groupBox14.Visible = false;
            groupBox12.Visible = false;
            groupBox9.Visible = false;
            groupBox11.Visible = false;
            groupBox13.Visible = false;
            groupBox15.Visible = false;
            groupBox31.Visible = false;
            groupBox26.Visible = false;
            groupBox22.Visible = false;
            groupBox17.Visible = false;
            groupBox19.Visible = false;
            groupBox24.Visible = false;
            groupBox28.Visible = false;
            groupBox32.Visible = false;
            groupBox29.Visible = false;
            groupBox25.Visible = false;
            groupBox20.Visible = false;
            groupBox23.Visible = false;




            label32.Text = "";
            label34.Text = "";

            var random = new Random();
            int randomnumber = random.Next(00000,99999);

            string sql8 = "SELECT * FROM `basket`";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();

            while (reader8.Read())
            {
                AuthorList8.Add(reader8.GetString("ProductID"));
            }

            string sql3 = "SELECT * FROM `basket`";
            MySqlConnection con3 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd1 = new MySqlCommand(sql3, con3);

            con3.Open();
            MySqlDataReader reader3 = cmd1.ExecuteReader();
            List<string> AuthorList3 = new List<string>();
            List<string> AuthorList4 = new List<string>();
            while (reader3.Read())
            {
                AuthorList3.Add(reader3.GetString("ProductID"));
                AuthorList4.Add(reader3.GetString("Quantity"));
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            string sql2 = "SELECT * FROM `products`";
            MySqlConnection con2 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd2 = new MySqlCommand(sql2, con2);

            con2.Open();
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            List<string> AuthorList = new List<string>();
            List<string> AuthorList2 = new List<string>();
            List<string> AuthorList5 = new List<string>();
            while (reader2.Read())
            {
                AuthorList.Add(reader2.GetString("ProductID"));
                AuthorList2.Add(reader2.GetString("ProductName"));
                AuthorList5.Add(reader2.GetString("Price"));
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            List<string> sumQ = new List<string>();
            List<string> sumP = new List<string>();
            for (int i =0; i< AuthorList3.Count; ++i)
            {
                if(i == 0)
                {
                    groupBox1.Visible = true;
                    for (int x =0;x<AuthorList.Count;++x)
                    {
                        if (AuthorList3[i] == AuthorList[x]) 
                        {
                            label4.Text = AuthorList2[x];
                            label5.Text = AuthorList4[i];
                            label28.Text = AuthorList5[x];
                            label6.Text = Convert.ToString((Convert.ToInt32(label5.Text)) * (Convert.ToInt32(label28.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label6.Text);
                        }
                    }
                }
                if (i == 1)
                {
                    groupBox2.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label9.Text = AuthorList2[x];
                            label29.Text = AuthorList5[x];
                            label8.Text = AuthorList4[i];
                            label7.Text = Convert.ToString((Convert.ToInt32(label8.Text)) * (Convert.ToInt32(label29.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label7.Text);
                        }
                    }
                }
                if (i == 2)
                {
                    groupBox3.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label12.Text = AuthorList2[x];
                            label30.Text = AuthorList5[x];
                            label11.Text = AuthorList4[i];
                            label10.Text = Convert.ToString((Convert.ToInt32(label30.Text)) * (Convert.ToInt32(label11.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label10.Text);
                        }
                    }
                }
                if (i == 3)
                {
                    groupBox4.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label15.Text = AuthorList2[x];
                            label33.Text = AuthorList5[x];
                            label14.Text = AuthorList4[i];
                            label13.Text = Convert.ToString((Convert.ToInt32(label33.Text)) * (Convert.ToInt32(label14.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label13.Text);
                        }
                    }
                }
                if (i == 4)
                {
                    groupBox6.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label21.Text = AuthorList2[x];
                            label36.Text = AuthorList5[x];
                            label20.Text = AuthorList4[i];
                            label19.Text = Convert.ToString((Convert.ToInt32(label36.Text)) * (Convert.ToInt32(label20.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label19.Text);
                        }
                    }
                }
                if (i == 5)
                {
                    groupBox7.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label24.Text = AuthorList2[x];
                            label37.Text = AuthorList5[x];
                            label23.Text = AuthorList4[i];
                            label22.Text = Convert.ToString((Convert.ToInt32(label37.Text)) * (Convert.ToInt32(label23.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label22.Text);
                        }
                    }
                }
                if (i == 6)
                {
                    groupBox8.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label27.Text = AuthorList2[x];
                            label38.Text = AuthorList5[x];
                            label26.Text = AuthorList4[i];
                            label25.Text = Convert.ToString((Convert.ToInt32(label38.Text)) * (Convert.ToInt32(label26.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label25.Text);
                        }
                    }
                }
                if (i == 7)
                {
                    groupBox16.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label69.Text = AuthorList2[x];
                            label66.Text = AuthorList5[x];
                            label68.Text = AuthorList4[i];
                            label67.Text = Convert.ToString((Convert.ToInt32(label68.Text)) * (Convert.ToInt32(label66.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label25.Text);
                        }
                    }
                }
                if (i == 8)
                {
                    groupBox14.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label61.Text = AuthorList2[x];
                            label58.Text = AuthorList5[x];
                            label60.Text = AuthorList4[i];
                            label59.Text = Convert.ToString((Convert.ToInt32(label60.Text)) * (Convert.ToInt32(label58.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label25.Text);
                        }
                    }
                }
                if (i == 9)
                {
                    groupBox12.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label53.Text = AuthorList2[x];
                            label50.Text = AuthorList5[x];
                            label52.Text = AuthorList4[i];
                            label51.Text = Convert.ToString((Convert.ToInt32(label50.Text)) * (Convert.ToInt32(label52.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label25.Text);
                        }
                    }
                }
                if (i == 10)
                {
                    groupBox9.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label45.Text = AuthorList2[x];
                            label39.Text = AuthorList5[x];
                            label44.Text = AuthorList4[i];
                            label43.Text = Convert.ToString((Convert.ToInt32(label39.Text)) * (Convert.ToInt32(label44.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label25.Text);
                        }
                    }
                }
                if (i == 11)
                {
                    groupBox11.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label49.Text = AuthorList2[x];
                            label46.Text = AuthorList5[x];
                            label48.Text = AuthorList4[i];
                            label47.Text = Convert.ToString((Convert.ToInt32(label46.Text)) * (Convert.ToInt32(label48.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label25.Text);
                        }
                    }
                }
                if (i == 12)
                {
                    groupBox13.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label57.Text = AuthorList2[x];
                            label54.Text = AuthorList5[x];
                            label56.Text = AuthorList4[i];
                            label55.Text = Convert.ToString((Convert.ToInt32(label54.Text)) * (Convert.ToInt32(label56.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label25.Text);
                        }
                    }
                }
                if (i == 13)
                {
                    groupBox15.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label65.Text = AuthorList2[x];
                            label62.Text = AuthorList5[x];
                            label64.Text = AuthorList4[i];
                            label63.Text = Convert.ToString((Convert.ToInt32(label62.Text)) * (Convert.ToInt32(label64.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label25.Text);
                        }
                    }
                }
                if (i == 14)
                {
                    groupBox31.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label127.Text = AuthorList2[x];
                            label124.Text = AuthorList5[x];
                            label126.Text = AuthorList4[i];
                            label125.Text = Convert.ToString((Convert.ToInt32(label124.Text)) * (Convert.ToInt32(label126.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label25.Text);
                        }
                    }
                }
                if (i == 15)
                {
                    groupBox26.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label107.Text = AuthorList2[x];
                            label104.Text = AuthorList5[x];
                            label106.Text = AuthorList4[i];
                            label105.Text = Convert.ToString((Convert.ToInt32(label104.Text)) * (Convert.ToInt32(label106.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label25.Text);
                        }
                    }
                }
                if (i == 16)
                {
                    groupBox22.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label91.Text = AuthorList2[x];
                            label88.Text = AuthorList5[x];
                            label90.Text = AuthorList4[i];
                            label89.Text = Convert.ToString((Convert.ToInt32(label88.Text)) * (Convert.ToInt32(label90.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label25.Text);
                        }
                    }
                }
                if (i == 17)
                {
                    groupBox17.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label76.Text = AuthorList2[x];
                            label70.Text = AuthorList5[x];
                            label75.Text = AuthorList4[i];
                            label74.Text = Convert.ToString((Convert.ToInt32(label70.Text)) * (Convert.ToInt32(label75.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label25.Text);
                        }
                    }
                }
                if (i == 18)
                {
                    groupBox19.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label80.Text = AuthorList2[x];
                            label77.Text = AuthorList5[x];
                            label79.Text = AuthorList4[i];
                            label78.Text = Convert.ToString((Convert.ToInt32(label77.Text)) * (Convert.ToInt32(label79.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label25.Text);
                        }
                    }
                }
                if (i == 19)
                {
                    groupBox24.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label99.Text = AuthorList2[x];
                            label96.Text = AuthorList5[x];
                            label98.Text = AuthorList4[i];
                            label97.Text = Convert.ToString((Convert.ToInt32(label96.Text)) * (Convert.ToInt32(label98.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label25.Text);
                        }
                    }
                }
                if (i == 20)
                {
                    groupBox28.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label115.Text = AuthorList2[x];
                            label112.Text = AuthorList5[x];
                            label114.Text = AuthorList4[i];
                            label113.Text = Convert.ToString((Convert.ToInt32(label112.Text)) * (Convert.ToInt32(label114.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label25.Text);
                        }
                    }
                }
                if (i == 21)
                {
                    groupBox32.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label131.Text = AuthorList2[x];
                            label128.Text = AuthorList5[x];
                            label130.Text = AuthorList4[i];
                            label129.Text = Convert.ToString((Convert.ToInt32(label128.Text)) * (Convert.ToInt32(label130.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label25.Text);
                        }
                    }
                }
                if (i == 22)
                {
                    groupBox29.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label119.Text = AuthorList2[x];
                            label116.Text = AuthorList5[x];
                            label118.Text = AuthorList4[i];
                            label117.Text = Convert.ToString((Convert.ToInt32(label116.Text)) * (Convert.ToInt32(label118.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label25.Text);
                        }
                    }
                }
                if (i == 23)
                {
                    groupBox25.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label103.Text = AuthorList2[x];
                            label100.Text = AuthorList5[x];
                            label102.Text = AuthorList4[i];
                            label101.Text = Convert.ToString((Convert.ToInt32(label100.Text)) * (Convert.ToInt32(label102.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label25.Text);
                        }
                    }
                }
                if (i == 24)
                {
                    groupBox20.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label87.Text = AuthorList2[x];
                            label81.Text = AuthorList5[x];
                            label86.Text = AuthorList4[i];
                            label85.Text = Convert.ToString((Convert.ToInt32(label81.Text)) * (Convert.ToInt32(label86.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label25.Text);
                        }
                    }
                }
                if (i == 25)
                {
                    groupBox23.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label95.Text = AuthorList2[x];
                            label92.Text = AuthorList5[x];
                            label94.Text = AuthorList4[i];
                            label93.Text = Convert.ToString((Convert.ToInt32(label92.Text)) * (Convert.ToInt32(label94.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label25.Text);
                        }
                    }
                }

            }
            int sumpp = 0;
            int sumqq = 0;
            for (int w =0;w<sumQ.Count;++w)
            {
                sumpp += Convert.ToInt32(sumP[w]);
                sumqq += Convert.ToInt32(sumQ[w]);
            }
            label32.Text = Convert.ToString(sumqq);
            label34.Text = Convert.ToString(sumpp);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label32.Text != "0")
            {
                string sel = "SELECT * FROM `login_save`";
                MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sel, con);
                List<string> AuthorList9 = new List<string>();
                con.Open();
                MySqlDataReader reader0 = cmd.ExecuteReader();
                while (reader0.Read())
                {
                    AuthorList9.Add(reader0.GetString("staffsID"));
                }
                //MessageBox.Show(Convert.ToString(AuthorList9.Count));
                if (AuthorList9.Count == 0)
                {
                    string sql10 = "INSERT INTO `from_save`(`formid`) VALUES ('" + data + "')";
                    MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                    MySqlCommand cmd2 = new MySqlCommand(sql10, con1);

                    con1.Open();
                    cmd2.ExecuteReader();
                    con1.Close();

                    Form9 form9 = new Form9("0");
                    form9.Show();
                    this.Hide();
                }
                else
                {
                    Form7 form7 = new Form7();
                    form7.Show();
                    this.Hide();
                }


            }
            else
            {
                MessageBox.Show("ตระกร้าว่างเปล่า โปรดเลือกสินค้าก่อน");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql8 = "SELECT* FROM `products` WHERE ProductName = '"+ label4.Text + "'";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();
            List<string> name_ID = new List<string>();
            while (reader8.Read())
            {
                name_ID.Add(reader8.GetString("ProductID"));
            }

            
            string Del = "DELETE FROM `basket` WHERE ProductID = '"+ name_ID[0] + "'";
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand comd = new MySqlCommand(Del, connect);
            connect.Open();
            comd.ExecuteReader();
            connect.Close();

            Form6 form6 = new Form6(data);
            this.Hide();
            form6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql8 = "SELECT* FROM `products` WHERE ProductName = '" + label9.Text + "'";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();
            List<string> name_ID = new List<string>();
            while (reader8.Read())
            {
                name_ID.Add(reader8.GetString("ProductID"));
            }


            string Del = "DELETE FROM `basket` WHERE ProductID = '" + name_ID[0] + "'";
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand comd = new MySqlCommand(Del, connect);
            connect.Open();
            comd.ExecuteReader();
            connect.Close();

            Form6 form6 = new Form6(data);
            this.Hide();
            form6.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql8 = "SELECT* FROM `products` WHERE ProductName = '" + label12.Text + "'";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();
            List<string> name_ID = new List<string>();
            while (reader8.Read())
            {
                name_ID.Add(reader8.GetString("ProductID"));
            }


            string Del = "DELETE FROM `basket` WHERE ProductID = '" + name_ID[0] + "'";
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand comd = new MySqlCommand(Del, connect);
            connect.Open();
            comd.ExecuteReader();
            connect.Close();

            Form6 form6 = new Form6(data);
            this.Hide();
            form6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql8 = "SELECT* FROM `products` WHERE ProductName = '" + label15.Text + "'";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();
            List<string> name_ID = new List<string>();
            while (reader8.Read())
            {
                name_ID.Add(reader8.GetString("ProductID"));
            }


            string Del = "DELETE FROM `basket` WHERE ProductID = '" + name_ID[0] + "'";
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand comd = new MySqlCommand(Del, connect);
            connect.Open();
            comd.ExecuteReader();
            connect.Close();

            Form6 form6 = new Form6(data);
            this.Hide();
            form6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sql8 = "SELECT* FROM `products` WHERE ProductName = '" + label21.Text + "'";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();
            List<string> name_ID = new List<string>();
            while (reader8.Read())
            {
                name_ID.Add(reader8.GetString("ProductID"));
            }


            string Del = "DELETE FROM `basket` WHERE ProductID = '" + name_ID[0] + "'";
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand comd = new MySqlCommand(Del, connect);
            connect.Open();
            comd.ExecuteReader();
            connect.Close();

            Form6 form6 = new Form6(data);
            this.Hide();
            form6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string sql8 = "SELECT* FROM `products` WHERE ProductName = '" + label24.Text + "'";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();
            List<string> name_ID = new List<string>();
            while (reader8.Read())
            {
                name_ID.Add(reader8.GetString("ProductID"));
            }


            string Del = "DELETE FROM `basket` WHERE ProductID = '" + name_ID[0] + "'";
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand comd = new MySqlCommand(Del, connect);
            connect.Open();
            comd.ExecuteReader();
            connect.Close();

            Form6 form6 = new Form6(data);
            this.Hide();
            form6.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string sql8 = "SELECT* FROM `products` WHERE ProductName = '" + label27.Text + "'";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();
            List<string> name_ID = new List<string>();
            while (reader8.Read())
            {
                name_ID.Add(reader8.GetString("ProductID"));
            }


            string Del = "DELETE FROM `basket` WHERE ProductID = '" + name_ID[0] + "'";
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand comd = new MySqlCommand(Del, connect);
            connect.Open();
            comd.ExecuteReader();
            connect.Close();

            Form6 form6 = new Form6(data);
            this.Hide();
            form6.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string sql8 = "SELECT* FROM `products` WHERE ProductName = '" + label69.Text + "'";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();
            List<string> name_ID = new List<string>();
            while (reader8.Read())
            {
                name_ID.Add(reader8.GetString("ProductID"));
            }


            string Del = "DELETE FROM `basket` WHERE ProductID = '" + name_ID[0] + "'";
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand comd = new MySqlCommand(Del, connect);
            connect.Open();
            comd.ExecuteReader();
            connect.Close();

            Form6 form6 = new Form6(data);
            this.Hide();
            form6.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string sql8 = "SELECT* FROM `products` WHERE ProductName = '" + label61.Text + "'";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();
            List<string> name_ID = new List<string>();
            while (reader8.Read())
            {
                name_ID.Add(reader8.GetString("ProductID"));
            }


            string Del = "DELETE FROM `basket` WHERE ProductID = '" + name_ID[0] + "'";
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand comd = new MySqlCommand(Del, connect);
            connect.Open();
            comd.ExecuteReader();
            connect.Close();

            Form6 form6 = new Form6(data);
            this.Hide();
            form6.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string sql8 = "SELECT* FROM `products` WHERE ProductName = '" + label53.Text + "'";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();
            List<string> name_ID = new List<string>();
            while (reader8.Read())
            {
                name_ID.Add(reader8.GetString("ProductID"));
            }


            string Del = "DELETE FROM `basket` WHERE ProductID = '" + name_ID[0] + "'";
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand comd = new MySqlCommand(Del, connect);
            connect.Open();
            comd.ExecuteReader();
            connect.Close();

            Form6 form6 = new Form6(data);
            this.Hide();
            form6.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string sql8 = "SELECT* FROM `products` WHERE ProductName = '" + label45.Text + "'";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();
            List<string> name_ID = new List<string>();
            while (reader8.Read())
            {
                name_ID.Add(reader8.GetString("ProductID"));
            }


            string Del = "DELETE FROM `basket` WHERE ProductID = '" + name_ID[0] + "'";
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand comd = new MySqlCommand(Del, connect);
            connect.Open();
            comd.ExecuteReader();
            connect.Close();

            Form6 form6 = new Form6(data);
            this.Hide();
            form6.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string sql8 = "SELECT* FROM `products` WHERE ProductName = '" + label49.Text + "'";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();
            List<string> name_ID = new List<string>();
            while (reader8.Read())
            {
                name_ID.Add(reader8.GetString("ProductID"));
            }


            string Del = "DELETE FROM `basket` WHERE ProductID = '" + name_ID[0] + "'";
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand comd = new MySqlCommand(Del, connect);
            connect.Open();
            comd.ExecuteReader();
            connect.Close();

            Form6 form6 = new Form6(data);
            this.Hide();
            form6.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string sql8 = "SELECT* FROM `products` WHERE ProductName = '" + label57.Text + "'";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();
            List<string> name_ID = new List<string>();
            while (reader8.Read())
            {
                name_ID.Add(reader8.GetString("ProductID"));
            }


            string Del = "DELETE FROM `basket` WHERE ProductID = '" + name_ID[0] + "'";
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand comd = new MySqlCommand(Del, connect);
            connect.Open();
            comd.ExecuteReader();
            connect.Close();

            Form6 form6 = new Form6(data);
            this.Hide();
            form6.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string sql8 = "SELECT* FROM `products` WHERE ProductName = '" + label65.Text + "'";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();
            List<string> name_ID = new List<string>();
            while (reader8.Read())
            {
                name_ID.Add(reader8.GetString("ProductID"));
            }


            string Del = "DELETE FROM `basket` WHERE ProductID = '" + name_ID[0] + "'";
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand comd = new MySqlCommand(Del, connect);
            connect.Open();
            comd.ExecuteReader();
            connect.Close();

            Form6 form6 = new Form6(data);
            this.Hide();
            form6.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string sql8 = "SELECT* FROM `products` WHERE ProductName = '" + label127.Text + "'";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();
            List<string> name_ID = new List<string>();
            while (reader8.Read())
            {
                name_ID.Add(reader8.GetString("ProductID"));
            }


            string Del = "DELETE FROM `basket` WHERE ProductID = '" + name_ID[0] + "'";
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand comd = new MySqlCommand(Del, connect);
            connect.Open();
            comd.ExecuteReader();
            connect.Close();

            Form6 form6 = new Form6(data);
            this.Hide();
            form6.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string sql8 = "SELECT* FROM `products` WHERE ProductName = '" + label107.Text + "'";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();
            List<string> name_ID = new List<string>();
            while (reader8.Read())
            {
                name_ID.Add(reader8.GetString("ProductID"));
            }


            string Del = "DELETE FROM `basket` WHERE ProductID = '" + name_ID[0] + "'";
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand comd = new MySqlCommand(Del, connect);
            connect.Open();
            comd.ExecuteReader();
            connect.Close();

            Form6 form6 = new Form6(data);
            this.Hide();
            form6.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string sql8 = "SELECT* FROM `products` WHERE ProductName = '" + label91.Text + "'";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();
            List<string> name_ID = new List<string>();
            while (reader8.Read())
            {
                name_ID.Add(reader8.GetString("ProductID"));
            }


            string Del = "DELETE FROM `basket` WHERE ProductID = '" + name_ID[0] + "'";
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand comd = new MySqlCommand(Del, connect);
            connect.Open();
            comd.ExecuteReader();
            connect.Close();

            Form6 form6 = new Form6(data);
            this.Hide();
            form6.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string sql8 = "SELECT* FROM `products` WHERE ProductName = '" + label76.Text + "'";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();
            List<string> name_ID = new List<string>();
            while (reader8.Read())
            {
                name_ID.Add(reader8.GetString("ProductID"));
            }


            string Del = "DELETE FROM `basket` WHERE ProductID = '" + name_ID[0] + "'";
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand comd = new MySqlCommand(Del, connect);
            connect.Open();
            comd.ExecuteReader();
            connect.Close();

            Form6 form6 = new Form6(data);
            this.Hide();
            form6.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string sql8 = "SELECT* FROM `products` WHERE ProductName = '" + label80.Text + "'";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();
            List<string> name_ID = new List<string>();
            while (reader8.Read())
            {
                name_ID.Add(reader8.GetString("ProductID"));
            }


            string Del = "DELETE FROM `basket` WHERE ProductID = '" + name_ID[0] + "'";
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand comd = new MySqlCommand(Del, connect);
            connect.Open();
            comd.ExecuteReader();
            connect.Close();

            Form6 form6 = new Form6(data);
            this.Hide();
            form6.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string sql8 = "SELECT* FROM `products` WHERE ProductName = '" + label99.Text + "'";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();
            List<string> name_ID = new List<string>();
            while (reader8.Read())
            {
                name_ID.Add(reader8.GetString("ProductID"));
            }


            string Del = "DELETE FROM `basket` WHERE ProductID = '" + name_ID[0] + "'";
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand comd = new MySqlCommand(Del, connect);
            connect.Open();
            comd.ExecuteReader();
            connect.Close();

            Form6 form6 = new Form6(data);
            this.Hide();
            form6.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string sql8 = "SELECT* FROM `products` WHERE ProductName = '" + label115.Text + "'";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();
            List<string> name_ID = new List<string>();
            while (reader8.Read())
            {
                name_ID.Add(reader8.GetString("ProductID"));
            }


            string Del = "DELETE FROM `basket` WHERE ProductID = '" + name_ID[0] + "'";
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand comd = new MySqlCommand(Del, connect);
            connect.Open();
            comd.ExecuteReader();
            connect.Close();

            Form6 form6 = new Form6(data);
            this.Hide();
            form6.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string sql8 = "SELECT* FROM `products` WHERE ProductName = '" + label131.Text + "'";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();
            List<string> name_ID = new List<string>();
            while (reader8.Read())
            {
                name_ID.Add(reader8.GetString("ProductID"));
            }


            string Del = "DELETE FROM `basket` WHERE ProductID = '" + name_ID[0] + "'";
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand comd = new MySqlCommand(Del, connect);
            connect.Open();
            comd.ExecuteReader();
            connect.Close();

            Form6 form6 = new Form6(data);
            this.Hide();
            form6.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string sql8 = "SELECT* FROM `products` WHERE ProductName = '" + label19.Text + "'";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();
            List<string> name_ID = new List<string>();
            while (reader8.Read())
            {
                name_ID.Add(reader8.GetString("ProductID"));
            }


            string Del = "DELETE FROM `basket` WHERE ProductID = '" + name_ID[0] + "'";
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand comd = new MySqlCommand(Del, connect);
            connect.Open();
            comd.ExecuteReader();
            connect.Close();

            Form6 form6 = new Form6(data);
            this.Hide();
            form6.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            string sql8 = "SELECT* FROM `products` WHERE ProductName = '" + label103.Text + "'";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();
            List<string> name_ID = new List<string>();
            while (reader8.Read())
            {
                name_ID.Add(reader8.GetString("ProductID"));
            }


            string Del = "DELETE FROM `basket` WHERE ProductID = '" + name_ID[0] + "'";
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand comd = new MySqlCommand(Del, connect);
            connect.Open();
            comd.ExecuteReader();
            connect.Close();

            Form6 form6 = new Form6(data);
            this.Hide();
            form6.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            string sql8 = "SELECT* FROM `products` WHERE ProductName = '" + label87.Text + "'";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();
            List<string> name_ID = new List<string>();
            while (reader8.Read())
            {
                name_ID.Add(reader8.GetString("ProductID"));
            }


            string Del = "DELETE FROM `basket` WHERE ProductID = '" + name_ID[0] + "'";
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand comd = new MySqlCommand(Del, connect);
            connect.Open();
            comd.ExecuteReader();
            connect.Close();

            Form6 form6 = new Form6(data);
            this.Hide();
            form6.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string sql8 = "SELECT* FROM `products` WHERE ProductName = '" + label95.Text + "'";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();
            List<string> name_ID = new List<string>();
            while (reader8.Read())
            {
                name_ID.Add(reader8.GetString("ProductID"));
            }


            string Del = "DELETE FROM `basket` WHERE ProductID = '" + name_ID[0] + "'";
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand comd = new MySqlCommand(Del, connect);
            connect.Open();
            comd.ExecuteReader();
            connect.Close();

            Form6 form6 = new Form6(data);
            this.Hide();
            form6.Show();
        }
    }
}
