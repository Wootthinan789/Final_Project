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
    public partial class Form9 : Form
    {
        static List<string> staffID = new List<string>();
        static string forsave = "";
        public Form9()
        {
            InitializeComponent();
            List<string> formsave = new List<string>();
            string sql3 = "SELECT * FROM `from_save`";
            MySqlConnection con3 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd1 = new MySqlCommand(sql3, con3);

            con3.Open();
            MySqlDataReader reader4 = cmd1.ExecuteReader();

            while (reader4.Read())
            {
                formsave.Add(reader4.GetString("formid"));
            }
            forsave = formsave[0];

            string del = "DELETE FROM `from_save` WHERE formid";
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(del, con);

            con.Open();
            cmd.ExecuteReader();
            con.Close();


            comboBox1.Text = "Staff";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql3 = "SELECT * FROM `staffs`";
            MySqlConnection con3 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd1 = new MySqlCommand(sql3, con3);

            con3.Open();
            MySqlDataReader reader3 = cmd1.ExecuteReader();
            List<string> StaffID = new List<string>();
            List<string> StaffCode = new List<string>();
            List<string> StaffName = new List<string>();
            List<string> Gender = new List<string>();
            List<string> StaffPassword = new List<string>();
            List<string> StaffLevel = new List<string>();
            while (reader3.Read())
            {
                StaffID.Add(reader3.GetString("StaffID"));
                StaffCode.Add(reader3.GetString("StaffCode"));
                StaffName.Add(reader3.GetString("StaffName"));
                Gender.Add(reader3.GetString("Gender"));
                StaffPassword.Add(reader3.GetString("StaffPassword"));
                StaffLevel.Add(reader3.GetString("StaffLevel"));
            }
            int checkloop = 0;
            for(int i = 0; i<StaffID.Count;++i)
            {
                if (StaffLevel[i] == "Staff")
                {
                    if (textBox2.Text == StaffName[i])
                    {
                        //MessageBox.Show("ผ่าน staffName , Staff");
                        if (textBox1.Text == StaffPassword[i])
                        {
<<<<<<< HEAD
                            MessageBox.Show("ผ่าน StaffPassword , Staff");
                            checkloop = 1;
                            string insert = "INSERT INTO `login_save`(`staffsID`) VALUES ('" + StaffID[i] + "')";
                            MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                            MySqlCommand cmd = new MySqlCommand(insert, con1);

                            con1.Open();
                            cmd.ExecuteReader();
                            con1.Close();
                           
                            checkloop = 1;
                            staffID.Add(StaffID[i]);
                            ////////////////////////////////////////////////////////////////////////////////////
                            if (forsave == "1")
                            {
                                Form1 form1 = new Form1();
                                form1.Hide();
                                form1.Show();
                            }
                            if (forsave == "2")
                            {
                                Form2 form2 = new Form2();
                                form2.Hide();
                                form2.Show();
=======
                            //MessageBox.Show("ผ่าน StaffPassword , Staff");
                            if (checkform == "0") 
                            {
                                checkloop = 1;
                                string insert = "INSERT INTO `login_save`(`staffsID`) VALUES ('" + StaffID[i] + "')";
                                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                                MySqlCommand cmd = new MySqlCommand(insert, con1);

                                con1.Open();
                                cmd.ExecuteReader();
                                con1.Close();

                                checkloop = 1;
                                staffID.Add(StaffID[i]);
                                ////////////////////////////////////////////////////////////////////////////////////
                                if (forsave == "1")
                                {
                                    //Form1 form1 = new Form1();
                                    //form1.Hide();
                                    Form1 form1s = new Form1();
                                    form1s.ShowInTaskbar = false;
                                    form1s.Show();
                                    //form1s.ShowDialog();
                                    //Form1 parentForm = (Form1)Owner;
                                    //parentForm.Close();
                                    this.Close();
                                }
                                if (forsave == "2")
                                {
                                    Form2 form2s = new Form2();
                                    form2s.ShowInTaskbar = false;
                                    form2s.Show();
                                    this.Close();
                                }
                                if (forsave == "3")
                                {
                                    Form3 form3s = new Form3();
                                    form3s.ShowInTaskbar = false;
                                    form3s.Show();
                                    this.Close();
                                }


                                Form7 form7 = new Form7();
                                form7.Show();
                                this.Close();
                                ////////////////////////////////////////////////////////////////////////////////////
>>>>>>> 6fc7818ca239d7e8f369de95b44befe05fea0ae5
                            }
                            if (forsave == "3")
                            {
<<<<<<< HEAD
                                Form3 form3 = new Form3();
                                form3.Hide();
                                form3.Show();
                            }
=======
                                //checkloop = 1;
                                string insert = "INSERT INTO `login_save`(`staffsID`) VALUES ('" + StaffID[i] + "')";
                                MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                                MySqlCommand cmd = new MySqlCommand(insert, con1);
>>>>>>> 6fc7818ca239d7e8f369de95b44befe05fea0ae5


<<<<<<< HEAD
                            Form7 form7 = new Form7();
                            form7.Show();
                            this.Hide();
                            ////////////////////////////////////////////////////////////////////////////////////
=======
                                checkloop = 1;
                                staffID.Add(StaffID[i]);
                                ////////////////////////////////////////////////////////////////////////////////////
                                if (forsave == "1")
                                {
                                    Form1 form1s = new Form1();
                                    form1s.ShowInTaskbar = false;
                                    form1s.Show();
                                    this.Close();

                                }
                                if (forsave == "2")
                                {
                                    Form2 form2s = new Form2();
                                    form2s.ShowInTaskbar = false;
                                    form2s.Show();
                                    this.Close();
                                }
                                if (forsave == "3")
                                {
                                    Form3 form3s = new Form3();
                                    form3s.ShowInTaskbar = false;
                                    form3s.Show();
                                    this.Close();
                                }
                            }
>>>>>>> 6fc7818ca239d7e8f369de95b44befe05fea0ae5
                        }
                        else
                        {

                        }
                    }
                    else
                    {

                    }
                }
                if (StaffLevel[i] == "Manager")
                {
                    if (textBox2.Text == StaffName[i])
                    {
                        //MessageBox.Show("ผ่าน staffName , Manager");
                        if (textBox1.Text == StaffPassword[i])
                        {
                            checkloop = 1;
                            //MessageBox.Show("ผ่าน StaffPassword , Manager");
                            
                            Form10 form10 = new Form10();
                            form10.Show();
                            this.Close();
                        }
                        else
                        {

                        }
                    }
                    else
                    {

                    }
                }
                if (StaffLevel[i] == "Admin")
                {
                    if (textBox2.Text == StaffName[i])
                    {
                        MessageBox.Show("ผ่าน staffName , Admin");
                        if (textBox1.Text == StaffPassword[i])
                        {
                            MessageBox.Show("ผ่าน StaffPassword , Admin");
                            checkloop = 1;
                        }
                        else
                        {

                        }
                    }
                    else
                    {

                    }
                }

            }
            if(checkloop == 0)
            {
                MessageBox.Show("ID,ชื่อ หรือรหัสผ่านไม่ถูกต้อง");
            }



            /*
            if (radioButton1.Checked)
            {
                string A = textBox2.Text;
                string B = textBox1.Text;
                Form10 form10 = new Form10();
                form10.Hide();
                if (A == "Admin")
                {
                    if (B == "123456")
                    {
                        this.Hide();
                        form10.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Password ของท่านไม่ถูกต้อง", "คำเตือน");
                    }
                }
                else
                {
                    MessageBox.Show("Username ของท่านไม่ถูกต้อง", "คำเตือน");
                }
            }
            if (radioButton2.Checked)
            {
                string A = textBox2.Text;
                string B = textBox1.Text;
                Form7 form7 = new Form7();
                form7.Hide();
                if (A == "Admin")
                {
                    if (B == "123456")
                    {
                        this.Hide();
                        form7.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Password ของท่านไม่ถูกต้อง", "คำเตือน");
                    }
                }
                else
                {
                    MessageBox.Show("Username ของท่านไม่ถูกต้อง", "คำเตือน");
                }
            }
            */
        }
    }
}
