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
        public Form9()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
        }
    }
}
