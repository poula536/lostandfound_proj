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
    public partial class CostForm : Form
    {
        public static string price="10 LE ";
        public string price_ = price ;

        public static string comb_box;
       // public string c_box_mess = comb_box;
        public CostForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = string.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox2.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comb_box = comboBox2.Text;
            if (comboBox2.Text == "بطاقه رقم قومي")
            {
                MessageBox.Show("your cost while be 10 L.E");
                price = "10.00 LE ";
            }
            else if (comboBox2.Text == "بطاقه تحقيق شخصيه")
            {
                MessageBox.Show("your cost while be 5 L.E");
                price = "5.00 LE ";
            }
            else if (comboBox2.Text == "كارنيهات نوادي-كارنيهات انشطه مختلفه")
            {
                MessageBox.Show("your cost while be 5 L.E");
                price = "5.00 LE ";
            }
            else if (comboBox2.Text == "كارت فيزا - بطاقه ائتمان مختلفه")
            {
                MessageBox.Show("your cost while be 10 L.E");
                price = "10.00 LE ";
            }
            else if (comboBox2.Text == "رخصه قياده - سلاح - اخري ")
            {
                MessageBox.Show("your cost while be 10 L.E");
                price = "10.00 LE ";
            }
            else if (comboBox2.Text == "جواز سفر مصري ")
            {
                MessageBox.Show("your cost while be 10 L.E");
                price = "10.00 LE ";
            }
            else if (comboBox2.Text == "جواز سفر اجنبي ")
            {
                MessageBox.Show("your cost while be 15 L.E");
                price = "15.00 LE ";
            }
            else if (comboBox2.Text == "تحقيق شخصيه -عسكري - شرطه - امن قومي - رقابه اداريه")
            {
                MessageBox.Show("you don't pay any think this for free");
                price = " FREE ";
            }
            else
                MessageBox.Show("Please Choose at first!");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            comboBox1.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "القاهرة")
            {
                MessageBox.Show("شارع الحجاز خلف قسم النزهه مصر الجديده");
            }
            else if (comboBox1.Text == "الجيزه")
            {
                MessageBox.Show("امام محطه مترو خلف كشري زيزو");
            }
            else if (comboBox1.Text == "الاسكندرية")
            {
                MessageBox.Show("ش محمود سالمة – محطة مصر");
            }
            else if (comboBox1.Text == "بني سويف")
            {
                MessageBox.Show("ش صفية زغلول – محطة سكك الحديد");
            }
            else if (comboBox1.Text == "الاسماعلية")
            {
                MessageBox.Show("ش الحرية – ميدان عرابي");
            }
            else if (comboBox1.Text == "الوادي الجديد")
            {
               MessageBox.Show("خلف سينما هيبس – بجوار مكتب بريد الخارجة");
            }
            else if (comboBox1.Text == "قنا")
            {
                MessageBox.Show(" ش سفينة متفرع من ش فاوي");
            }
            else if (comboBox1.Text == "طور")
            {
                MessageBox.Show(" طور سيناء – مبني مجمع المصالح ");
            }
            else if (comboBox1.Text == "اسوان")
            {
                MessageBox.Show("ش كورنيش النيل ) البوستة القديمة (");
            }
            else if (comboBox1.Text == "اسيوط")
            {
                MessageBox.Show("أمام فندق بدر");
            }
            else if (comboBox1.Text == "القليوبية")
            {
                MessageBox.Show("مركز حركة بريد بنها محطة");
            }
            else if (comboBox1.Text == "شمال سيناء")
            {
                MessageBox.Show("يناء – ش ابو بكر الصديق – بجوار بريد العريش ");
            }
            else if (comboBox1.Text == "الغردفة")
            {
                MessageBox.Show("ش الحجاز خلف قسم ثان الغردقة – حفر الباطن ");
            }
            else if (comboBox1.Text == "السويس")
            {
                MessageBox.Show("مدينة الصباح عمارة 5 بجوار مسجد سيدنا حمزه");
            }
            else if (comboBox1.Text == "الفيوم")
            {
                MessageBox.Show("منشيه وصفي");
            }
            else if (comboBox1.Text == "كفر الشيخ")
            {
                MessageBox.Show(" النبوي المهندس – بجوار جامع الخياط");
            }
            else if (comboBox1.Text == "كفر الشيخ")
            {
                MessageBox.Show(" النبوي المهندس – بجوار جامع الخياط");
            }
            else if (comboBox1.Text == "مرسي مطروح")
            {
                MessageBox.Show("ش الجالء بجوار قسم شرطة مطروح");
            }
            else if (comboBox1.Text == "بورسعيد")
            {
                MessageBox.Show("  ش األمين واألنصار");
            }
            else if (comboBox1.Text == "دمياط")
            {
                MessageBox.Show("ش التحرير أمام مبني السنترال القديم");
            }
            else if (comboBox1.Text == "طنطا ")
            {
                MessageBox.Show("ش المديرية بجوار السكة الحديد - أمام المعهد الديني");
            }
            else if (comboBox1.Text == "سوهاج ")
            {
                MessageBox.Show("ش كورنيش النيل");
            }
            else if (comboBox1.Text == "دمنهور")
            {
                MessageBox.Show("ميدان المحطة");
            }
            else if (comboBox1.Text == "المنيا")
            {
                MessageBox.Show("  ش سعد زغلول – مبني محطة السكك الحديد");
            }
            else if (comboBox1.Text == "الشرقية")
            {
                MessageBox.Show("بجوار مطافي الزقازيق – أمام كوبري السوارس");
            }
            else if (comboBox1.Text == "شبين  الكوم")
            {
                MessageBox.Show("ش نصر من ش طلعت حرب البر الشرقي بجوار األتوبيس");
            }
            else if (comboBox1.Text == "المنصورة")
            {
                MessageBox.Show("ميدان المحطة - سيدي سعد - المشايه السفلي");
            }
            
            else
            {
                MessageBox.Show("Please choose at first!");
            }
        }

        private void button_visa_Click(object sender, EventArgs e)
        {
            if (comb_box == null)
                MessageBox.Show("Select first");
            else
            {
                this.Hide();
                DeliveryForm visa = new DeliveryForm();
                visa.Show();
            } 
        }
    }
}
