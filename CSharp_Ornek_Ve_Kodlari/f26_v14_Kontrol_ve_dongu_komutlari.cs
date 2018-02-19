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
    public partial class f26_v14_Kontrol_ve_dongu_komutlari : Form
    {
        public f26_v14_Kontrol_ve_dongu_komutlari()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Bu örnetke Microsoft.VisualBasic.Interaction.InputBox kullanmak için Proje>"Başvuru Ekle" ya da "Add Reference"
            // menüsünden Microsoft VisualBasic'i eklemeniz lazım.
            // ayrıca OrtakSinif.IsNumeric(değer) fonksiyonunu kendimiz oluşturduk.
            // Bundan önceki örneklerde InputBox'tan gelen verinin sadece boş olup olmadığını kontrol ediyorduk.
            // Veri kısmına harf girilirse gene program hata veriyordu. 
            // Bundan sonraki örneklerde InputBox'tan gelen verilerin sayısal olup olmadığını kontrol etmek için
            // daha iyisini bulana kadar OrtakSinif.IsNumeric(string InputBoxtanGelen) fonksiyonunu kullanabiliriz.
            Double gelir = 0;
            string InputBoxtanGelen = Microsoft.VisualBasic.Interaction.InputBox("Maaşınızı Girin", "Maaş Bilgisi", "", 120, 120);
            if (OrtakSinif.IsNumeric(InputBoxtanGelen) == false)
            {
                MessageBox.Show("Lütfen sayısal bir veri giriniz");
                return;
            }
            else
            {
               gelir = Convert.ToDouble(InputBoxtanGelen);
            }
            if(gelir>=5000) { MessageBox.Show("gelir düzeyi yüksek");}
            else if(gelir>=2500) { MessageBox.Show("Orta gelirli"); }
            else if(gelir>=1500) { MessageBox.Show("Yaşayabilecek kadar geliri var"); }
            else { MessageBox.Show("Üzülme yıkılmadık ayaktayız. Hayat devam ediyor. Daha iyisini yapabiliriz :) "); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Önceki Örnek f25_v13_Math_kullanimi

            if (OrtakSinif.GizliFormuAc("f25_v13_Math_kullanimi") == 0)
            {
                f25_v13_Math_kullanimi YeniForm = new f25_v13_Math_kullanimi();
                YeniForm.Show();
            }
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Ana Menü
            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;//ilk açılan form
            this.Visible = false;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            this.panel1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int N = 10;
            for (int i = 0; i <= N; i++)
            {
                listBox1.Items.Add(i);
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            // 10 dan 1 e  saydırmak istersek
            int N = 1;
            for(int i=10;i>=N;i-=1) //burda i-=1 yerine i-- de kullanabilirdik
            {
                listBox2.Items.Add(i);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string DegeriKontrolEt = textBox1.Text;
            if(OrtakSinif.IsNumeric(DegeriKontrolEt)==false) { MessageBox.Show("Sayısal bir değer girmelisiniz!");return; }
            int deger = Convert.ToInt16(DegeriKontrolEt);
            switch(deger)
            {
                case 1:
                    MessageBox.Show("Bugün Pazartesi");
                    break;
                case 2:
                    MessageBox.Show("Bugün Salı");
                    break;
                case 3:
                    MessageBox.Show("Bugün Çarşamba");
                    break;
                case 4:
                    MessageBox.Show("Bugün Perşembe");
                    break;
                case 5:
                    MessageBox.Show("Bugün Cuma");
                    break;
                case 6:
                    MessageBox.Show("Bugün Cumartesi");
                    break;
                case 7:
                    MessageBox.Show("Bugün Pazar");
                    break;
                default:
                    MessageBox.Show("Hafta yedi gündür yeniden sayı girin!");
                    textBox1.Focus();
                    break;
            }
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            panel2.Focus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string BaslangicDegeri = Microsoft.VisualBasic.Interaction.InputBox("Başlangıç Değeri Giriniz", "", "", 100, 100);
            string BitisDegeri = Microsoft.VisualBasic.Interaction.InputBox("Bitiş Değeri Giriniz", "", "", 100, 100);

            //sayısal değilse programı "return" ile durduralım
            //OrtakSinif bizim oluşturduğumuz sınıftır Sınıf ya da Nesne tanımlama konularına gelince açıklamasını yapacağız
            if (OrtakSinif.IsNumeric(BaslangicDegeri) == false) { MessageBox.Show("Başlangıç Değeri sayısal olmalıdır!"); return; }
            if (OrtakSinif.IsNumeric(BitisDegeri) == false) { MessageBox.Show("Bitiş Değeri sayısal olmalıdır!"); return; }
            //girilenler sayısal ise program burdan devam edecektir

            //Buradan sonrası alışılagelen kodlar olacaktır.

            //Bu örnekte başlangıç değerinin büyük ve bitiş değerinin küçük olmasını istiyoruz.
            //Büyükten küçüğe döngüyü çalıştıracağız.
            int b = Convert.ToInt32(BaslangicDegeri); //Başlangıç değeri
            int N = Convert.ToInt32(BitisDegeri);
            if (b <= N) { MessageBox.Show("Lütfen başlangıç değeri, bitiş değerinden büyük olsun"); return; }
            OrtakSinif.ListBoxTemizle(listBox3);
            for (int i = b; i >= N; i--)
            {
                listBox3.Items.Add(i);
               
            }



        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            panel4.Focus();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel3.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OrtakSinif.ListBoxTemizle(listBox3);
        }
<<<<<<< HEAD
=======

        private void button2_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek f27_v15_Diziler

            if (OrtakSinif.GizliFormuAc("f27_v15_Diziler") == 0)
            {
                f27_v15_Diziler YeniForm = new f27_v15_Diziler();
                YeniForm.Show();
            }
            this.Visible = false;
        }
>>>>>>> e42f2320591ea5ada5a914ebef002616eeb60af1
    }
}
