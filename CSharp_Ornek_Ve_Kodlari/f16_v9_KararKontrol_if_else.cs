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
    public partial class f16_v9_KararKontrol_if_else : Form
    {
        public f16_v9_KararKontrol_if_else()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Ana Menü
            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;//ilk açılan form
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek f17_v9_if_elseif
            if (OrtakSinif.GizliFormuAc("f17_v9_if_elseif") == 0)
            {
                f17_v9_if_elseif YeniForm = new f17_v9_if_elseif();
                YeniForm.Show();
            }
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Bir sayı giriniz.");
                return;
            }

            int sayi = Convert.ToInt32(textBox1.Text);

            if (sayi % 2 == 0)
                MessageBox.Show("Girdiğiniz sayı ÇİFT SAYIDIR");
            else
                MessageBox.Show("Girdiğiniz sayı TEK SAYIDIR");

               
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Önceki Örnek f15_v9_KararKontrolDeyimleri01
            if (OrtakSinif.GizliFormuAc("f15_v9_KararKontrolDeyimleri01") == 0)
            {
                f15_v9_KararKontrolDeyimleri01 YeniForm = new f15_v9_KararKontrolDeyimleri01();
                YeniForm.Show();
            }
            this.Visible = false;
        }
    }
}
