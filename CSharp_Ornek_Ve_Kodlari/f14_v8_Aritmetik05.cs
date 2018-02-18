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
    public partial class f14_v8_Aritmetik05 : Form
    {
        public f14_v8_Aritmetik05()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = 10;
            int sayi2 = 10;
            sayi1 = sayi1 + 5;
            int toplam = sayi1 + sayi2;
            textBox1.Text = Convert.ToString(toplam);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Ana Menü
            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;//ilk açılan form
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek
            if (OrtakSinif.GizliFormuAc("f15_v9_KararKontrolDeyimleri01") == 0)
            {
                f15_v9_KararKontrolDeyimleri01 YeniForm = new f15_v9_KararKontrolDeyimleri01();
                YeniForm.Show();
            }
            this.Visible = false;
        }
    }
}
