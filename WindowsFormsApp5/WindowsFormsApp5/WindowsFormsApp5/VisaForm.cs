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
    public partial class VisaForm : Form
    {


        public VisaForm()
        {
            InitializeComponent();
            label1.Text = "Payment amount " + new CostForm().price_.ToString();
            button1.Text = "Pay " + new CostForm().price_.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your payment is completed");
            this.Hide();
            new CostForm().Show();

        }
    }
}
