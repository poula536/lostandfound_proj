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
    public partial class CreatenewaccountForm : Form
    {
        private static string user_name,pass;
        public string u_name = user_name;
        public string password = pass;
        public CreatenewaccountForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user_name = textBox_firstname.Text;
            pass = textBox_password.Text;
            MessageBox.Show("your data is saved","Account created");
            LoginForm f = new LoginForm();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
            this.Hide();
        }
    }
}
