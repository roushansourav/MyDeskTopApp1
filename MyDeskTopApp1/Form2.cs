﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = a + b;
            textBox3.Text =c.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = a - b;
            textBox3.Text = c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = a * b;
            textBox3.Text = c.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = a / b;
            textBox3.Text = c.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            textBox1.Text = numericUpDown1.Value.ToString();

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            
            textBox2.Text = numericUpDown2.Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
