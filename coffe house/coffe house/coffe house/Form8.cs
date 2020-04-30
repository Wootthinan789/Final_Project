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
    public partial class Form8 : Form
    {
        string cumid = "";
        int randomnumber = 0;                           //randomnumber
        int sumpp = 0;                                  //summore Price basket
        int sumqq = 0;                                  //summore Quantity basket
        List<string> AuthorList3 = new List<string>();  //ProductID basket
        List<string> AuthorList4 = new List<string>();  //Quantity basket
        List<string> AuthorList = new List<string>();   //ProductID products
        List<string> AuthorList2 = new List<string>();  //ProductName products
        List<string> AuthorList5 = new List<string>();  //Price products
        List<string> CustomerID = new List<string>();   //customersID
        List<string> CustomerName = new List<string>(); //customersName
        List<string> CustomerType = new List<string>(); //customersType
        List<string> CustomerTelNo = new List<string>();//customersTelNo
        List<string> Gender = new List<string>();       //customersGerder
        List<string> sumQ = new List<string>();         //sumQuantity
        List<string> sumP = new List<string>();         //sumProductID

        public Form8()
        {
            InitializeComponent();
            groupBox1.Visible = groupBox1.Visible;
            groupBox2.Visible = groupBox2.Visible;
            groupBox3.Visible = groupBox3.Visible;
            groupBox4.Visible = groupBox4.Visible;
            groupBox5.Visible = groupBox5.Visible;
            groupBox6.Visible = groupBox6.Visible;
            groupBox7.Visible = groupBox7.Visible;
            groupBo7.Visible = groupBo7.Visible;
            groupBo8.Visible = false;
            groupBo9.Visible = false;
            groupBo1.Visible = false;
            groupBo2.Visible = false;
            groupBo3.Visible = false;
            groupBo4.Visible = false;
            groupBo5.Visible = false;
            groupBo6.Visible = false;
            groupBo17.Visible = false;
            groupBo18.Visible = false;
            groupBo19.Visible = false;
            groupBo20.Visible = false;
            groupBo21.Visible = false;
            groupBo22.Visible = false;
            groupBo23.Visible = false;
            groupBo24.Visible = false;
            groupBo25.Visible = false;
            groupBo26.Visible = false;
            label32.Text = "";
            label34.Text = "";
            label57.Text = ""+dateTimePicker1.Value;

            var random = new Random();
            randomnumber = random.Next(00000, 99999);
            label44.Text = "#" + Convert.ToString(randomnumber);

            string sql3 = "SELECT * FROM `basket`";
            MySqlConnection con3 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd1 = new MySqlCommand(sql3, con3);

            con3.Open();
            MySqlDataReader reader3 = cmd1.ExecuteReader();
            
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
            
            while (reader2.Read())
            {
                AuthorList.Add(reader2.GetString("ProductID"));
                AuthorList2.Add(reader2.GetString("ProductName"));
                AuthorList5.Add(reader2.GetString("Price"));
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < AuthorList3.Count; ++i)
            {
                //MessageBox.Show("aa"+Convert.ToString(AuthorList3.Count));
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
                if (i == 7)
                {
                    groupBo7.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            labe71.Text = AuthorList2[x];
                            labe72.Text = AuthorList5[x];
                            labe73.Text = AuthorList4[i];
                            labe74.Text = Convert.ToString((Convert.ToInt32(labe72.Text)) * (Convert.ToInt32(labe73.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(labe74.Text);
                        }
                    }
                }
                if (i == 8)
                {
                    groupBo8.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            labe81.Text = AuthorList2[x];
                            labe82.Text = AuthorList5[x];
                            labe83.Text = AuthorList4[i];
                            labe84.Text = Convert.ToString((Convert.ToInt32(labe82.Text)) * (Convert.ToInt32(labe83.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(labe84.Text);
                        }
                    }
                }
                if (i == 9)
                {
                    groupBo9.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            labe91.Text = AuthorList2[x];
                            labe92.Text = AuthorList5[x];
                            labe93.Text = AuthorList4[i];
                            labe94.Text = Convert.ToString((Convert.ToInt32(labe92.Text)) * (Convert.ToInt32(labe93.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(labe94.Text);
                        }
                    }
                }
                if (i == 10)
                {
                    groupBo1.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            labe11.Text = AuthorList2[x];
                            labe12.Text = AuthorList5[x];
                            labe13.Text = AuthorList4[i];
                            labe14.Text = Convert.ToString((Convert.ToInt32(labe12.Text)) * (Convert.ToInt32(labe13.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(labe14.Text);
                        }
                    }
                }
                if (i == 11)
                {
                    groupBo2.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            labe21.Text = AuthorList2[x];
                            labe22.Text = AuthorList5[x];
                            labe23.Text = AuthorList4[i];
                            labe24.Text = Convert.ToString((Convert.ToInt32(labe22.Text)) * (Convert.ToInt32(labe23.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(labe24.Text);
                        }
                    }
                }
                if (i == 12)
                {
                    groupBo3.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            labe31.Text = AuthorList2[x];
                            labe32.Text = AuthorList5[x];
                            labe33.Text = AuthorList4[i];
                            labe34.Text = Convert.ToString((Convert.ToInt32(labe32.Text)) * (Convert.ToInt32(labe33.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(labe34.Text);
                        }
                    }
                }
                if (i == 13)
                {
                    groupBo4.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            labe41.Text = AuthorList2[x];
                            labe42.Text = AuthorList5[x];
                            labe43.Text = AuthorList4[i];
                            labe44.Text = Convert.ToString((Convert.ToInt32(labe42.Text)) * (Convert.ToInt32(labe43.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(labe44.Text);
                        }
                    }
                }
                if (i == 14)
                {
                    groupBo5.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            labe51.Text = AuthorList2[x];
                            labe52.Text = AuthorList5[x];
                            labe53.Text = AuthorList4[i];
                            labe54.Text = Convert.ToString((Convert.ToInt32(labe52.Text)) * (Convert.ToInt32(labe53.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(labe54.Text);
                        }
                    }
                }
                if (i == 15)
                {
                    groupBo6.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            labe61.Text = AuthorList2[x];
                            labe62.Text = AuthorList5[x];
                            labe63.Text = AuthorList4[i];
                            labe64.Text = Convert.ToString((Convert.ToInt32(labe62.Text)) * (Convert.ToInt32(labe63.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(labe64.Text);
                        }
                    }
                }
                if (i == 16)
                {
                    groupBo17.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            labe171.Text = AuthorList2[x];
                            labe172.Text = AuthorList5[x];
                            labe173.Text = AuthorList4[i];
                            labe174.Text = Convert.ToString((Convert.ToInt32(labe172.Text)) * (Convert.ToInt32(labe173.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(labe174.Text);
                        }
                    }
                }
                if (i == 17)
                {
                    groupBo18.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            labe181.Text = AuthorList2[x];
                            labe182.Text = AuthorList5[x];
                            labe183.Text = AuthorList4[i];
                            labe184.Text = Convert.ToString((Convert.ToInt32(labe182.Text)) * (Convert.ToInt32(labe183.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(labe184.Text);
                        }
                    }
                }
                if (i == 18)
                {
                    groupBo19.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            labe191.Text = AuthorList2[x];
                            labe192.Text = AuthorList5[x];
                            labe193.Text = AuthorList4[i];
                            labe194.Text = Convert.ToString((Convert.ToInt32(labe192.Text)) * (Convert.ToInt32(labe193.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(labe194.Text);
                        }
                    }
                }
                if (i == 19)
                {
                    groupBo20.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            labe201.Text = AuthorList2[x];
                            labe202.Text = AuthorList5[x];
                            labe203.Text = AuthorList4[i];
                            labe204.Text = Convert.ToString((Convert.ToInt32(labe202.Text)) * (Convert.ToInt32(labe203.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(labe204.Text);
                        }
                    }
                }
                if (i == 20)
                {
                    groupBo21.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            labe211.Text = AuthorList2[x];
                            labe212.Text = AuthorList5[x];
                            labe213.Text = AuthorList4[i];
                            labe214.Text = Convert.ToString((Convert.ToInt32(labe212.Text)) * (Convert.ToInt32(labe213.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(labe214.Text);
                        }
                    }
                }
                if (i == 21)
                {
                    groupBo22.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            labe221.Text = AuthorList2[x];
                            labe222.Text = AuthorList5[x];
                            labe223.Text = AuthorList4[i];
                            labe224.Text = Convert.ToString((Convert.ToInt32(labe222.Text)) * (Convert.ToInt32(labe223.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(labe224.Text);
                        }
                    }
                }
                if (i == 22)
                {
                    groupBo23.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            labe231.Text = AuthorList2[x];
                            labe232.Text = AuthorList5[x];
                            labe233.Text = AuthorList4[i];
                            labe234.Text = Convert.ToString((Convert.ToInt32(labe232.Text)) * (Convert.ToInt32(labe233.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(labe234.Text);
                        }
                    }
                }
                if (i == 23)
                {
                    groupBo24.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            labe241.Text = AuthorList2[x];
                            labe242.Text = AuthorList5[x];
                            labe243.Text = AuthorList4[i];
                            labe244.Text = Convert.ToString((Convert.ToInt32(labe242.Text)) * (Convert.ToInt32(labe243.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(labe244.Text);
                        }
                    }
                }
                if (i == 24)
                {
                    groupBo25.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            labe251.Text = AuthorList2[x];
                            labe252.Text = AuthorList5[x];
                            labe253.Text = AuthorList4[i];
                            labe254.Text = Convert.ToString((Convert.ToInt32(labe252.Text)) * (Convert.ToInt32(labe253.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(labe254.Text);
                        }
                    }
                }
                if (i == 25)
                {
                    groupBo26.Visible = true;
                    for (int x = 0; x < AuthorList.Count; ++x)
                    {
                        if (AuthorList3[i] == AuthorList[x])
                        {
                            labe261.Text = AuthorList2[x];
                            labe262.Text = AuthorList5[x];
                            labe263.Text = AuthorList4[i];
                            labe264.Text = Convert.ToString((Convert.ToInt32(labe262.Text)) * (Convert.ToInt32(labe263.Text)));
                            sumQ.Add(AuthorList4[i]);
                            sumP.Add(labe264.Text);
                        }
                    }
                }
            }
            
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
            
            while (reader8.Read())
            {
                CustomerID.Add(reader8.GetString("CustomerID"));
                CustomerName.Add(reader8.GetString("CustomerName"));
                CustomerType.Add(reader8.GetString("CustomerType"));
                CustomerTelNo.Add(reader8.GetString("CustomerTelNo"));
                Gender.Add(reader8.GetString("Gender"));
            }

            for (int v =0; v < CustomerID.Count; ++v)
            {
                string x = CustomerID[v];
                if (medid[0] == x)
                {
                    label39.Text = CustomerType[v];
                    label45.Text = CustomerName[v];
                    label46.Text = Gender[v];
                    label47.Text = CustomerTelNo[v];
                    cumid = CustomerID[v];
                }
                
            }
            


            
            string sql6 = "DELETE FROM `memorymenber` WHERE medid";
            MySqlConnection con6 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd6 = new MySqlCommand(sql6, con6);

            con6.Open();
            cmd6.ExecuteReader();
            //MessageBox.Show("ลบ");
            con6.Close();
            


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> staffs = new List<string>();                       //staffs
            string sqlstaffs = "SELECT * FROM `staffs`";
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd = new MySqlCommand(sqlstaffs, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                staffs.Add(reader.GetString("StaffID"));
            }


            List<string> login_save = new List<string>();                   //login_save
            string sqllogin_save = "SELECT * FROM `login_save`";
            MySqlConnection con1 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd1 = new MySqlCommand(sqllogin_save, con1);
            con1.Open();
            MySqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                login_save.Add(reader1.GetString("staffsID"));
            }

            var random2 = new Random();
            int SaleDetailID = random2.Next(10000, 99999);
            for (int a = 0; a<AuthorList3.Count; ++a)
            {
                try
                {
                    //MessageBox.Show(Convert.ToString(Convert.ToInt32(sumQ[a]) ,Convert.ToInt32(sumP[a])));
                    string amount = Convert.ToString(Convert.ToInt32(sumP[a]));
                    string Pricee = Convert.ToString(Convert.ToInt32(sumP[a])/ Convert.ToInt32(sumQ[a]));
                    string sale_detail = "INSERT INTO `sale_details`(`SaleDetailID`, `SaleID`, `ProductID`, `Price`, `Quantity`, `Amount`) VALUES('" + SaleDetailID + "','" + randomnumber + "','" + AuthorList3[a] + "','" + Pricee + "','" + AuthorList4[a] + "','" + amount + "')";
                    MySqlConnection con2 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
                    MySqlCommand cmd2 = new MySqlCommand(sale_detail, con2);
                    con2.Open();
                    cmd2.ExecuteReader();
                    con2.Close();
                }
                catch
                {
                    SaleDetailID = random2.Next(10000, 99999);
                    //MessageBox.Show(Convert.ToString(SaleDetailID));
                    a -= 1;
                }
            }
            MessageBox.Show("เสร็จสิ้น","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            string sale = "INSERT INTO `sales`(`SaleID`, `SaleDateTime`, `CustomerID`, `StaffID`, `GrandTotal`) VALUES ('"+ randomnumber + "','"+ dateTimePicker1.Value+ "','"+ cumid + "','"+ login_save[0] + "','"+ sumpp + "')";
            MySqlConnection con3 = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand cmd3 = new MySqlCommand(sale, con3);
            con3.Open();
            cmd3.ExecuteReader();
            con3.Close();




            string Del = "DELETE FROM `basket` WHERE ProductID";
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1;port=3306;username=test;password=12345678;database=testdata");
            MySqlCommand comd = new MySqlCommand(Del, connect);
            connect.Open();
            comd.ExecuteReader();
            connect.Close();

            this.Close();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
