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
            if (textBox2.Text == new CreatenewaccountForm().u_name &&
                textBox4.Text == new CreatenewaccountForm().password)
            {
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
            else if ((textBox2.Text == string.Empty && textBox4.Text == string.Empty) ||
                (textBox2.Text == string.Empty && textBox4.Text != string.Empty) ||
                (textBox2.Text != string.Empty && textBox4.Text == string.Empty))
            {
                MessageBox.Show("Invalid Username or Password");
            }
                
            else
                MessageBox.Show("You dont have account yet!!! Create one now");
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
