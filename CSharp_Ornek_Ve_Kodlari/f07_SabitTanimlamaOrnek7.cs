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
    public partial class f07_SabitTanimlamaOrnek7 : Form
    {
        const string adi = "Umut SÜRMELİ";
        const int yasi = 38;
        public f07_SabitTanimlamaOrnek7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sabit sürekli aynı değeri üzerinde tutan değişkendir.
            /* Uygulamanın çalışması boyunca değişmeyen bir değer kullanılacaksa
             * o zaman sabit değişken kullanılmalıdır.
             */
            textBox1.Text = Convert.ToString("Adı: " + adi + "; Yaşı:" + yasi);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Ana Menü
            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;//ilk açılan form
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek = f09_v7_veri_tipleri
            if (OrtakSinif.GizliFormuAc("f09_v7_veri_tipleri") == 0)
            {
                f09_v7_veri_tipleri YeniForm = new f09_v7_veri_tipleri();
                YeniForm.Show();
            }
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Önceki Örnek = f06_DegiskenlerinProsedurUstuTanimlanmasi
            if (OrtakSinif.GizliFormuAc("f06_DegiskenlerinProsedurUstuTanimlanmasi") == 0)
            {
                f06_DegiskenlerinProsedurUstuTanimlanmasi YeniForm = new f06_DegiskenlerinProsedurUstuTanimlanmasi();
                YeniForm.Show();
            }
            this.Visible = false;
        }
    }
}
