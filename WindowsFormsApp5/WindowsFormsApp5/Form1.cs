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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1" && textBox2.Text == new CreatenewaccountForm().u_name
                 && comboBox1.Text=="القاهرة"&& textBox4.Text == "ID" )
            {
                DialogResult result = MessageBox.Show("you want to  transport it to your home",
                        "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
              if (result == DialogResult.Yes)

                {
                    DeliveryForm f2 = new DeliveryForm();
                    f2.Show();
                    this.Hide();
                    
                }
                else
                {
                    DialogResult results = MessageBox.Show("we will bring it at tanta post office on 15/12/2021 and it will cost you 10 L.E \n " +
                        "you will pay the fees of this in post office ",
                                       "Found it ");

                }
            }
            else
            {
                MessageBox.Show("Please try again later","Not Found");
            }
        }

            private void button3_Click(object sender, EventArgs e)
        {
            CostForm f2 = new CostForm();
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm f2 = new LoginForm();
            f2.Show();
            this.Hide();
        }
    }
}
