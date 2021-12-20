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
    public partial class DeliveryForm : Form
    {
        public DeliveryForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("you want to  pay by Visa ",
                        "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                VisaForm f2 = new VisaForm();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("you will pay the fees of it when recieve it with the poster ", "info");
                        
            }
        }
    }
}
