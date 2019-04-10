using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDeskTopApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                if (comboBox1.SelectedItem.ToString() == "Admin")
                {
                    MessageBox.Show("Login Success\nWelcome Admin");
                    textBox1.Text = "username";
                    textBox2.Text = "password";
                }
                else
                {
                    MessageBox.Show("Login Failed");
                    textBox1.Text = "username";
                    textBox2.Text = "password";
                }
            }
            else
            {
                MessageBox.Show("Login Failed");
                textBox1.Text = "username";
                textBox2.Text = "password";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
            
            label5.Text = "You have selected " + comboBox1.SelectedItem.ToString();
        }
    }
}
