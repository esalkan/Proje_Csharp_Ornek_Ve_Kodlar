using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Ornek_Ve_Kodlari
{
    public partial class f11_v8_Aritmetik02 : Form
    {
        public f11_v8_Aritmetik02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(textBox1.Text==""||textBox2.Text=="") { MessageBox.Show("sayı giriniz");return; }

            textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Ana Menü
            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;//ilk açılan form
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek f12_v8_Aritmetik03
            if (OrtakSinif.GizliFormuAc("f12_v8_Aritmetik03") == 0)
            {
                f12_v8_Aritmetik03 YeniForm = new f12_v8_Aritmetik03();
                YeniForm.Show();
            }
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Önceki Örnek f10_v8_Aritmetik01
            if (OrtakSinif.GizliFormuAc("f10_v8_Aritmetik01") == 0)
            {
                f10_v8_Aritmetik01 YeniForm = new f10_v8_Aritmetik01();
                YeniForm.Show();
            }
            this.Visible = false;
        }
    }
}
