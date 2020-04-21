﻿using MySql.Data.MySqlClient;
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
    public partial class Form8 : Form
    {
        public Form8()
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

            var random = new Random();
            int randomnumber = random.Next(00000, 99999);
            label44.Text = "#" + Convert.ToString(randomnumber);

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
            for (int i = 0; i < AuthorList3.Count; ++i)
            {
                if (i == 0)
                {
                    groupBox1.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label4.Text = AuthorList2[x];
                            label36.Text = AuthorList5[x];
                            label5.Text = AuthorList4[i];
                            label6.Text = Convert.ToString((Convert.ToInt32(label5.Text)) * (Convert.ToInt32(label36.Text)));
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
                            label48.Text = AuthorList5[x];
                            label8.Text = AuthorList4[i];
                            label7.Text = Convert.ToString((Convert.ToInt32(label8.Text)) * (Convert.ToInt32(label48.Text)));
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
                            label49.Text = AuthorList5[x];
                            label11.Text = AuthorList4[i];
                            label10.Text = Convert.ToString((Convert.ToInt32(label11.Text)) * (Convert.ToInt32(label49.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label10.Text);
                        }
                    }
                }
                if (i == 3)
                {
                    groupBox5.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label18.Text = AuthorList2[x];
                            label50.Text = AuthorList5[x];
                            label17.Text = AuthorList4[i];
                            label16.Text = Convert.ToString((Convert.ToInt32(label50.Text)) * (Convert.ToInt32(label17.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label16.Text);
                        }
                    }
                }
                if (i == 4)
                {
                    groupBox4.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label15.Text = AuthorList2[x];
                            label51.Text = AuthorList5[x];
                            label14.Text = AuthorList4[i];
                            label13.Text = Convert.ToString((Convert.ToInt32(label51.Text)) * (Convert.ToInt32(label14.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label13.Text);
                        }
                    }
                }
                if (i == 5)
                {
                    groupBox6.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label21.Text = AuthorList2[x];
                            label52.Text = AuthorList5[x];
                            label20.Text = AuthorList4[i];
                            label19.Text = Convert.ToString((Convert.ToInt32(label52.Text)) * (Convert.ToInt32(label20.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label19.Text);
                        }
                    }
                }
                if (i == 6)
                {
                    groupBox7.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            label24.Text = AuthorList2[x];
                            label53.Text = AuthorList5[x];
                            label23.Text = AuthorList4[i];
                            label22.Text = Convert.ToString((Convert.ToInt32(label53.Text)) * (Convert.ToInt32(label23.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(label22.Text);
                        }
                    }
                }
            }
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            int sumpp = 0;
            int sumqq = 0;
            for (int w = 0; w < sumQ.Count; ++w)
            {
                sumpp += Convert.ToInt32(sumP[w]);
                sumqq += Convert.ToInt32(sumQ[w]);
            }
            label32.Text = Convert.ToString(sumqq);
            label34.Text = Convert.ToString(sumpp);


            string sql7 = "SELECT * FROM `memorymenber`";
            MySqlConnection con7 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd7 = new MySqlCommand(sql7, con7);

            con7.Open();
            MySqlDataReader reader7 = cmd7.ExecuteReader();
            List<string> medid = new List<string>();
            while (reader7.Read())
            {
                medid.Add(reader7.GetString("medid"));
            }


            string sql8 = "SELECT * FROM `customers`";
            MySqlConnection con8 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd8 = new MySqlCommand(sql8, con8);

            con8.Open();
            MySqlDataReader reader8 = cmd8.ExecuteReader();
            List<string> CustomerID= new List<string>();
            List<string> CustomerName = new List<string>();
            List<string> CustomerType = new List<string>();
            List<string> CustomerTelNo = new List<string>();
            List<string> Gender = new List<string>();
            while (reader8.Read())
            {
                CustomerID.Add(reader8.GetString("CustomerID"));
                CustomerName.Add(reader8.GetString("CustomerName"));
                CustomerType.Add(reader8.GetString("CustomerType"));
                CustomerTelNo.Add(reader8.GetString("CustomerTelNo"));
                Gender.Add(reader8.GetString("Gender"));
            }
            MessageBox.Show("มาถึงแล้ว");
            for (int v =0; v < CustomerID.Count; ++v)
            {
                MessageBox.Show("--"+medid[0]+"=="+CustomerID[v]+"--");
                if (medid[0] == CustomerID[v])
                {
                    label39.Text = CustomerType[v];
                    label45.Text = CustomerName[v];
                    label46.Text = Gender[v];
                    label47.Text = CustomerTelNo[v];
                }
            }
            

            string sql6 = "DELETE FROM `memorymenber` WHERE medid";
            MySqlConnection con6 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd6 = new MySqlCommand(sql6, con6);

            con6.Open();
            cmd6.ExecuteReader();
            MessageBox.Show("ลบ");
            con6.Close();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
