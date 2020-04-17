using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffe_house
{
    public partial class Form3 : Form
    {
        static int num = 1;
        public Form3()
        {
            InitializeComponent();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

            num = Convert.ToInt32(label1.Text);                  //erferjfneirfjeirj
            num += 1;
            label1.Text = Convert.ToString(num);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        public void pictureBox6_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();

            /*
            try
            {
                // Build connection string
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "localhost";   // update me
                builder.UserID = "test";              // update me
                builder.Password = "12345678";      // update me
                builder.InitialCatalog = "master";

                // Connect to SQL
                MessageBox.Show("Connecting to SQL Server ... ");
                using (SqlConnection connection = new SqlConnection("host=localhost; users=test; password=12345678; database=testdata"))
                {
                    connection.Open();
                    MessageBox.Show("Done.");
                }
            }
            catch
            {
                Console.WriteLine("error1");
            }

            Console.WriteLine("All done. Press any key to finish...");
            */




            /*string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test;";
            string query = "";
            // Which could be translated manually to :
            // INSERT INTO user(`id`, `first_name`, `last_name`, `address`) VALUES (NULL, 'Bruce', 'Wayne', 'Wayne Manor')

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("User succesfully registered");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }*/



            /*try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "localhost.database.windows.net";
                builder.UserID = "test";
                builder.Password = "12345678";
                builder.InitialCatalog = "testdata";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT TOP 20 pc.Name as CategoryName, p.name as ProductName ");
                    sb.Append("FROM [SalesLT].[ProductCategory] pc ");
                    sb.Append("JOIN [SalesLT].[Product] p ");
                    sb.Append("ON pc.productcategoryid = p.productcategoryid;");
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("55555 {0} {1}", reader.GetString(0), reader.GetString(1));
                            }
                            Console.WriteLine("efwerf");
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();*/


            /*MySqlConnection conn = new MySqlConnection("Data Source=localhost;database=mm");
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT id, name FROM mytable", conn);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            da.InsertCommand = new MySqlCommand("INSERT INTO mytable (id, name) " +
            "VALUES (@id, @name)", conn);
            da.UpdateCommand = new MySqlCommand("UPDATE mytable SET id=@id, name=@name " +
            "WHERE id=@oldId", conn);
            da.DeleteCommand = new MySqlCommand("DELETE FROM mytable WHERE id=@id", conn);

            da.InsertCommand.Parameters.Add("@id", MySqlDbType.VarChar, 5, "id");
            da.InsertCommand.Parameters.Add("@name", MySqlDbType.VarChar, 40, "name");

            da.UpdateCommand.Parameters.Add("@id", MySqlDbType.VarChar, 5, "id");
            da.UpdateCommand.Parameters.Add("@name", MySqlDbType.VarChar, 40, "name");
            da.UpdateCommand.Parameters.Add("@oldId", MySqlDbType.VarChar, 5, "id").SourceVersion = DataRowVersion.Original;

            da.DeleteCommand.Parameters.Add("@id", MySqlDbType.VarChar, 5, "id").SourceVersion = DataRowVersion.Original;
            */

            /*string sql = "SECECT * FROM products";
            MySqlConnection con1 = new MySqlConnection(@"host=localhost;users=root;password=12345678;database=vvv");
            MySqlConnection conn = new MySqlConnection("server=myserver");
            MySqlCommand cmd = new MySqlCommand("SECECT * FROM products");

            conn.Open();
            //MySqlDataReader asd = cmd.ExecuteReader();
            while (true)
            {
                MessageBox.Show(Convert.ToString(con1));
            }*/
            /*
            try
            {
                string mySqlConnection = "datasource=db;port=3306;username=usr;password=Pswd";
                //MySqlConnection mySqlConn = new MySqlConnection(mySqlConnection);
                //MySqlDataAdapter myDataAdapter = new MySqlDataAdapter(mySqlConnection);
                //myDataAdapter.SelectCommand = new MySqlCommand(" Select * database.edata ;", mySqlConn);
                //MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);

                MySqlConnection mySqlConn = new MySqlConnection(mySqlConnection);
                MySqlCommand cmd = new MySqlCommand("Select * from database.edata");
                cmd.Connection = mySqlConn;
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter(cmd);

                mySqlConn.Open();
                DataSet ds = new DataSet();
                MessageBox.Show("Connected to Database");
                mySqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }


        /*string connStr = "server=server;user=user;database=db;password=*****;";
        MySqlConnection conn = new MySqlConnection(connStr);
        conn.Open();

        string sql = "SELECT this FROM that";
        MySqlCommand cmd = new MySqlCommand(sql, conn);
        using (MySqlDataReader rdr = cmd.ExecuteReader())
        {
            while (rdr.Read())
            {
                 iterate once per row 
            }
        }*/


    
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            num = Convert.ToInt32(label1.Text);
            if (num != 1)
            {                                              
                num -= 1;
                label1.Text = Convert.ToString(num);
            }
        }
    }
}
