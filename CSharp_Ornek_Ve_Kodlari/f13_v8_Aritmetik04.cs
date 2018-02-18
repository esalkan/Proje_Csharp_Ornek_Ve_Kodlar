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
    public partial class f13_v8_Aritmetik04 : Form
    {
        public f13_v8_Aritmetik04()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = 10;
            int sayi2 = 10;
            int toplam = sayi1 + sayi2;
            textBox1.Text = Convert.ToString(toplam);
            panel1.BackgroundImage = Properties.Resources.f13_v8_Aritmetik04_1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1 = 10;
            int sayi2 = 10;
            sayi1++;
            // sayi1 in o anki değeri kullanılır kullanıldıktan sonra
            // değeri 1 arttırılır 
            int toplam = sayi1 + sayi2;
            textBox1.Text = Convert.ToString(toplam);
            panel1.BackgroundImage = Properties.Resources.f13_v8_Aritmetik04_2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1 = 10;
            int sayi2 = 10;
            ++sayi1;
            // sayi1 in değerini bir arttırır ve ++sayi1'i kullanan ifadeye yeni değeri getirir.
            int toplam = sayi1 + sayi2;
            textBox1.Text = Convert.ToString(toplam);
            panel1.BackgroundImage = Properties.Resources.f13_v8_Aritmetik04_3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1 = 10;
            int sayi2 = 10;
            sayi1--;
            // sayi1 in o anki değeri kullanılır kullanıldıktan sonra
            // değeri 1 eksiltir.
            int toplam = sayi1 + sayi2;
            textBox1.Text = Convert.ToString(toplam);
            panel1.BackgroundImage = Properties.Resources.f13_v8_Aritmetik04_4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi1 = 10;
            int sayi2 = 10;
            sayi1--;
            // sayi1 in değerini bir eksiltir ve --sayi1'i kullanan ifadeye yeni değeri getirir.
            int toplam = sayi1 + sayi2;
            textBox1.Text = Convert.ToString(toplam);
            panel1.BackgroundImage = Properties.Resources.f13_v8_Aritmetik04_5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Ana Menü
            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;//ilk açılan form
            this.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek
            if (OrtakSinif.GizliFormuAc("f14_v8_Aritmetik05") == 0)
            {
                f14_v8_Aritmetik05 YeniForm = new f14_v8_Aritmetik05();
                YeniForm.Show();
            }
            this.Visible = false;
        }
    }
}
