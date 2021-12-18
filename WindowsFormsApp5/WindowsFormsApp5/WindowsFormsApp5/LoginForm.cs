using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lost_and_found_proj
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "youssab" && textBox4.Text == "123")
            {
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
            else if (textBox2.Text == "" && textBox4.Text == "")
                MessageBox.Show("Please enter username & Password");
            else if (textBox2.Text == "mario" && textBox4.Text == "")
                MessageBox.Show("Please enter your Password");
            else if (textBox2.Text == "" && textBox4.Text == "123")
                MessageBox.Show("Please enter  Username");
            else
                MessageBox.Show("Invalid Username & Password");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreatenewaccountForm f = new CreatenewaccountForm();
            f.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgetForm f  = new forgetForm();
            f.Show();
            this.Hide();
        }
    }
}
