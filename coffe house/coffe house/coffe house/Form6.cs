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
        public Form6()
        {
            InitializeComponent();
            groupBox1.Visible = groupBox1.Visible;
            groupBox2.Visible = groupBox2.Visible;
            groupBox3.Visible = groupBox3.Visible;
            groupBox4.Visible = groupBox4.Visible;
            groupBox6.Visible = groupBox6.Visible; 
            groupBox7.Visible = groupBox7.Visible;
            groupBox8.Visible = groupBox8.Visible;
            label32.Text = "";
            label34.Text = "";

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
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
        }
    }
}
