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
    public partial class f10_v8_Aritmetik01 : Form
    {
        public f10_v8_Aritmetik01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2;
            if (textBox1.Text == "") { MessageBox.Show("Bir sayı giriniz"); return; }
            else
            {
                textBox1.Text = OrtakSinif.NoktayiVirgule(textBox1.Text);
                sayi1 = Convert.ToDouble(textBox1.Text);
            }
            if (textBox2.Text == "") { MessageBox.Show("Bir sayı giriniz"); return; }
            else
            {
                textBox2.Text = OrtakSinif.NoktayiVirgule(textBox2.Text);//sonuc.Replace(".", ","); //çalışıyor
                sayi2 = Convert.ToDouble(textBox2.Text);
            }

            if (sayi2 == 0) { MessageBox.Show("bölen 0 olamaz!"); return; }
            //float bolme = 0.15F;
            double carpma = (sayi1 * sayi2);

            double sonuc = Math.Round((double) carpma, 4); //çalışıyor 
            //string sonuc = String.Format("{0:f}", carpma); //çalışıyor virgülden sonra 2 haneli
            // MessageBox.Show(sonuc.ToString());
            textBox3.Text = sonuc.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2;
            if (textBox1.Text == "") { MessageBox.Show("Bir sayı giriniz"); return; }
            else
            {
                textBox1.Text = OrtakSinif.NoktayiVirgule(textBox1.Text);
                sayi1 = Convert.ToDouble(textBox1.Text);
            }
            if (textBox2.Text == "") { MessageBox.Show("Bir sayı giriniz"); return; }
            else
            {
                textBox2.Text = OrtakSinif.NoktayiVirgule(textBox2.Text); //sonuc.Replace(".", ","); //çalışıyor
                sayi2 = Convert.ToDouble(textBox2.Text);
            }


            //float bolme = 0.15F;
            double cikarma = (sayi1 - sayi2);

            double sonuc = Math.Round((double) cikarma, 4); //çalışıyor 
            //string sonuc = String.Format("{0:f}", cikarma); //çalışıyor virgülden sonra 2 hane gösteriyor
            // MessageBox.Show(sonuc.ToString());
            textBox3.Text = sonuc.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2;
            if (textBox1.Text == "") { MessageBox.Show("Bir sayı giriniz"); return; }
            else
            {
                textBox1.Text = OrtakSinif.NoktayiVirgule(textBox1.Text);
                sayi1 = Convert.ToDouble(textBox1.Text);
            }
            if (textBox2.Text == "") { MessageBox.Show("Bir sayı giriniz"); return; }
            else
            {
                textBox2.Text = OrtakSinif.NoktayiVirgule(textBox2.Text);//sonuc.Replace(".", ","); //çalışıyor
                /* Eğer Sinif ve Fonksiyon oluşturma derslerine yetişebilirsem, sizinle "OrtakSinif.NoktayiVirgule"
                 * sınıf ve metodunu nasıl oluşturduğumu paylaşacağım 
                 */
                sayi2 = Convert.ToDouble(textBox2.Text);
            }

            if (sayi2==0) { MessageBox.Show("bölen 0 olamaz!");return; }
            //float bolme = 0.15F;
            double bolme =(sayi1/sayi2);


            double sonuc = Math.Round((double) bolme,4); //çalışıyor 
            //string sonuc = String.Format("{0:f}", bolme); //çalışıyor virgülden sonra 2 hane gösteriyor
           //MessageBox.Show(sonuc.ToString());
            textBox3.Text = sonuc.ToString(); 
        }
        private void button4_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2;
            if (textBox1.Text == "") { MessageBox.Show("Bir sayı giriniz"); return; }
            else
            {
                textBox1.Text = OrtakSinif.NoktayiVirgule(textBox1.Text);//sonuc.Replace(".", ","); //çalışıyor
                sayi1 = Convert.ToDouble(textBox1.Text);
            }
            if (textBox2.Text == "") { MessageBox.Show("Bir sayı giriniz"); return; }
            else
            {
                textBox2.Text = OrtakSinif.NoktayiVirgule(textBox2.Text);
                sayi2 = Convert.ToDouble(textBox2.Text);
            }


            //float bolme = 0.15F;
            double toplama = (sayi1 + sayi2);


            double sonuc = Math.Round((double) toplama, 4); //çalışıyor 
            //string sonuc = String.Format("{0:f}", toplama); //çalışıyor; virgülden sonra 2 haneli
            // MessageBox.Show(sonuc.ToString());
            textBox3.Text = sonuc.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Ana Menü
            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;//ilk açılan form
            this.Visible = false;
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            panel1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek f11_v8_Aritmetik02
            if (OrtakSinif.GizliFormuAc("f11_v8_Aritmetik02") == 0)
            {
                f11_v8_Aritmetik02 YeniForm = new f11_v8_Aritmetik02();
                YeniForm.Show();
            }
            this.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek f09_v7_veri_tipleri
            if (OrtakSinif.GizliFormuAc("f09_v7_veri_tipleri") == 0)
            {
                f09_v7_veri_tipleri YeniForm = new f09_v7_veri_tipleri();
                YeniForm.Show();
            }
            this.Visible = false;
        }
    }
}
