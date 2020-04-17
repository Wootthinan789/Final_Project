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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();


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



            string sql = "SECECT * FROM products";
            MySqlConnection conn = new MySqlConnection("Data Source=localhost;database=test");
            MySqlConnection con1 = new MySqlConnection(" host=localhost; users=root; password=12345678; database=vvv");
            var con2 = new MySqlConnection("host=localhost;user=root;password=12345678;database=vvv");
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            con1.Open();
            MySqlDataReader asd = cmd.ExecuteReader();
            while (asd.Read())
            {
                MessageBox.Show(asd.GetString("ProductID"));
            }
            */



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


        }
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
            {                                                //erferjfneirfjeirj
                num -= 1;
                label1.Text = Convert.ToString(num);
            }
        }
    }
}
