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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            string sql3 = "SELECT * FROM `customers`";
            MySqlConnection con3 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd1 = new MySqlCommand(sql3, con3);

            con3.Open();
            MySqlDataReader reader3 = cmd1.ExecuteReader();
            List<string> CustomerID = new List<string>();
            List<string> CustomerName = new List<string>();
            List<string> Gender = new List<string>();
            List<string> CustomerType = new List<string>();
            List<string> CustomerTelNo = new List<string>();
            while (reader3.Read())
            {
                CustomerID.Add(reader3.GetString("CustomerID"));
                CustomerName.Add(reader3.GetString("CustomerName"));
                Gender.Add(reader3.GetString("Gender"));
                CustomerType.Add(reader3.GetString("CustomerType"));
                CustomerTelNo.Add(reader3.GetString("CustomerTelNo"));
            }
            int checkloop = 0;
            for (int i = 0; i<CustomerID.Count; ++i)
            {
                if (CustomerTelNo[i] == textBox1.Text)
                {
                    button1.Text = "ok";
                    textBox2.Text = CustomerName[i];
                    comboBox1.Text = Gender[i];
                    comboBox2.Text = CustomerType[i];
                    textBox5.Text = CustomerTelNo[i];
                    textBox3.Text = CustomerID[i];
                    checkloop = 1;
                }
            }
            if (checkloop == 0)
            {
                MessageBox.Show("ไม่มีข้อมูล โปรดสมัคร");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO memorymenber (medid) VALUES ('" + textBox3.Text + "')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteReader();
                MessageBox.Show("เพิ่มแล้ว");
                Form8 form8 = new Form8();
                form8.Show();
                this.Hide();
                con1.Close();
            }
            catch
            {
                MessageBox.Show("มีบ้างอย่างไม่ถูกต้อง");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            string sql3 = "SELECT * FROM `customers`";
            MySqlConnection con3 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd1 = new MySqlCommand(sql3, con3);

            con3.Open();
            MySqlDataReader reader3 = cmd1.ExecuteReader();
            List<string> CustomerID = new List<string>();
            List<string> CustomerName = new List<string>();
            List<string> Gender = new List<string>();
            List<string> CustomerType = new List<string>();
            List<string> CustomerTelNo = new List<string>();
            while (reader3.Read())
            {
                CustomerID.Add(reader3.GetString("CustomerID"));
                CustomerName.Add(reader3.GetString("CustomerName"));
                Gender.Add(reader3.GetString("Gender"));
                CustomerType.Add(reader3.GetString("CustomerType"));
                CustomerTelNo.Add(reader3.GetString("CustomerTelNo"));
            }
            int checkloop = 0;
            for (int i = 0; i < CustomerID.Count; ++i)
            {
                if (CustomerID[i] == "123456")
                {
                    button1.Text = "ok";
                    textBox2.Text = CustomerName[i];
                    comboBox1.Text = Gender[i];
                    comboBox2.Text = CustomerType[i];
                    textBox5.Text = CustomerTelNo[i];
                    textBox3.Text = CustomerID[i];
                    //checkloop = 1;
                    string sql = "INSERT INTO memorymenber (medid) VALUES ('" + textBox3.Text + "')"; //VALUES ('"+text.text+"','"+text.text+"','"+text.text+"')
                    MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                    MySqlCommand cmd = new MySqlCommand(sql, con1);

                    con1.Open();
                    cmd.ExecuteReader();
                    MessageBox.Show("เพิ่มแล้ว");
                    Form8 form8 = new Form8();
                    form8.Show();
                    this.Hide();
                    con1.Close();
                }
            }
            if (checkloop == 0)
            {
               // MessageBox.Show("มีบางอย่างไม่ถูกต้อง");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
            try
            {
                var random = new Random();
                int randomnumber = random.Next(100000, 999999);
                textBox3.Text = Convert.ToString(randomnumber);

                string sql = "INSERT INTO `customers`(`CustomerID`, `CustomerName`, `Gender`, `CustomerType`, `CustomerTelNo`) VALUES ('"+randomnumber+"','"+textBox2.Text+"','"+comboBox1.Text[0]+"','"+comboBox2.Text+"','"+textBox5.Text+"')";
                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd = new MySqlCommand(sql, con1);

                string sql3 = "INSERT INTO memorymenber (medid) VALUES ('" + textBox3.Text + "')";
                MySqlConnection con3 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                MySqlCommand cmd3 = new MySqlCommand(sql3, con3);

                con3.Open();
                cmd3.ExecuteReader();
                con3.Close();

                con1.Open();
                cmd.ExecuteReader();
                MessageBox.Show("เพิ่มแล้ว");
                Form8 form8 = new Form8();
                form8.Show();
                this.Hide();
                con1.Close();
            }
            catch
            {
                MessageBox.Show("โปรดกรอกข้อมูลให้ถูกต้อง");
            }
        }
    }
}
