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
    public partial class f17_v9_if_elseif : Form
    {
        public f17_v9_if_elseif()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string karsilamaMesaji = " Umut";
            int saat = DateTime.Now.Hour;
            if(saat>=8&&saat<12)
            {
                karsilamaMesaji = karsilamaMesaji.Insert(0, "Günaydın ");
            }
            else if(saat>=12&&saat<16)
            {
                karsilamaMesaji = karsilamaMesaji.Insert(0, "İyi günler ");
            }
            else if (saat >= 16 && saat < 20)
            {
                karsilamaMesaji = karsilamaMesaji.Insert(0, "İyi akşamlar ");
            }
            else if(saat>=20&& saat<23)
            {
                karsilamaMesaji = karsilamaMesaji.Insert(0, "İyi geceler ");
            }
            else
            {
                karsilamaMesaji = karsilamaMesaji.Insert(0, "Merhaba ");
                karsilamaMesaji = karsilamaMesaji + " saat ders çalışmak için pek uygun değil";
            }
            textBox1.Text = karsilamaMesaji;
        }
        private void picturebox1_MouseHover(object sender, EventArgs e)
        {
            panel1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Ana Menü
            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;//ilk açılan form
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek f18_v10_01_switch

            if (OrtakSinif.GizliFormuAc("f18_v10_01_switch") == 0)
            {
                f18_v10_01_switch YeniForm = new f18_v10_01_switch();
                YeniForm.Show();
            }
            this.Visible = false;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Önceki Örnek f16_v9_KararKontrol_if_else

            if (OrtakSinif.GizliFormuAc("f16_v9_KararKontrol_if_else") == 0)
            {
                f16_v9_KararKontrol_if_else YeniForm = new f16_v9_KararKontrol_if_else();
                YeniForm.Show();
            }
            this.Visible = false;
        }
    }
}
