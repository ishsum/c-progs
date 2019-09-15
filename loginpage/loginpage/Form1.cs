using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginpage
{
    public partial class Form1 : Form
    {
        int cnt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="BootCamp" && textBox2.Text=="nptel")
            {
                MessageBox.Show("Welcome to c# Aplications");

            }
            else
            {
                cnt++;
                MessageBox.Show("Invalid Login");
                textBox1.Text = "";
                textBox2.Text = "";
                if (cnt==3)
                {
                    Application.Exit();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.AccessibleName = "Sign In";
        }
    }
}
