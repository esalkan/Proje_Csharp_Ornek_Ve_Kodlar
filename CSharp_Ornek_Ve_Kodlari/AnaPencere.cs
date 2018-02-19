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
    public partial class AnaPencere : Form
    {
        

        public AnaPencere()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(OrtakSinif.GizliFormuAc("f01_Buton_Tiklama")==0)
            {
                f01_Buton_Tiklama YeniForm = new f01_Buton_Tiklama();
                YeniForm.Show();
            }
            this.Visible = false;

        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = "textBox1.Text, Focus(), string değişkenlerin yan yana yazdırılması (birbirine eklenmesi)";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (OrtakSinif.GizliFormuAc("f02_Mesaj_Kutusu_String_Yansitma") == 0)
            {
                f02_Mesaj_Kutusu_String_Yansitma YeniForm = new f02_Mesaj_Kutusu_String_Yansitma();
                YeniForm.Show();
            }
            this.Visible = false;
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = "MessageBox.Show(), Degisken.ToString() kullanımıyla sayısal değişkenlerin MessageBox.Show içine eklenmesi";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (OrtakSinif.GizliFormuAc("f03_MSVB_Basvuru_Ekleme") == 0)
            {
                f03_MSVB_Basvuru_Ekleme YeniForm = new f03_MSVB_Basvuru_Ekleme();
                YeniForm.Show();
            }
            this.Visible = false;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = "Değişken Tanımlama";
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (OrtakSinif.GizliFormuAc("f04_MSVisualBasicAddReference") == 0)
            {
                f04_MSVisualBasicAddReference YeniForm = new f04_MSVisualBasicAddReference();
                YeniForm.Show();
            }
            this.Visible = false;
        }
        private void button4_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = "Add reference, Başvuru ekle, Microsoft.VisualBasic.InterAction.InpotBox kullanımı";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (OrtakSinif.GizliFormuAc("f05_DegiskenlerYanYana") == 0)
            {
                f05_DegiskenlerYanYana YeniForm = new f05_DegiskenlerYanYana();
                YeniForm.Show();
            }
            this.Visible = false;
        }
        private void button5_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = "Değişkenlerin yan yana bir satırda tanımlanması: String Degisken1,Degisken2;";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (OrtakSinif.GizliFormuAc("f06_DegiskenlerinProsedurUstuTanimlanmasi") == 0)
            {
                f06_DegiskenlerinProsedurUstuTanimlanmasi YeniForm = new f06_DegiskenlerinProsedurUstuTanimlanmasi();
                YeniForm.Show();
            }
            this.Visible = false;
        }
        private void button6_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = "Değişkenlerin form içindeki prosedürlerin üstünde tanımlanması; Böylece aynı değişkeni" +
                " birden çok prosedürde kullanabiliriz. (6. Video örneğidir)";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            if (OrtakSinif.GizliFormuAc("f07_SabitTanimlamaOrnek7") == 0)
            {
                f07_SabitTanimlamaOrnek7 YeniForm = new f07_SabitTanimlamaOrnek7();
                YeniForm.Show();
            }
            this.Visible = false;
        }
        private void button7_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = "Sabit değişkenlerin kullanılması \r\n Convert.ToString() kullanımı. \r\n 6. videonun son örneği";

        }
        /* Veri Tipleri */
        private void button8_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek
            if (OrtakSinif.GizliFormuAc("f09_v7_veri_tipleri") == 0)
            {
                f09_v7_veri_tipleri YeniForm = new f09_v7_veri_tipleri();
                YeniForm.Show();
            }
            this.Visible = false;
        }
        private void button8_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = "C# veri tipleri hakkında bilgi...";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek
            if (OrtakSinif.GizliFormuAc("DenemeFormu") == 0)
            {
                DenemeFormu YeniForm = new DenemeFormu();
                YeniForm.Show();
            }
            this.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek
            if (OrtakSinif.GizliFormuAc("f10_v8_Aritmetik01") == 0)
            {
                f10_v8_Aritmetik01 YeniForm = new f10_v8_Aritmetik01();
                YeniForm.Show();
            }
            this.Visible = false;
        }
        private void button10_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = "Aritmetik işlemlerde birçok deneme yaptıktan sonra, ondalıklı işlemlerde doğru sonuç elde etmek için \n";
            richTextBox1.Text += " double veri tipini kullanmak zorunda kaldım. Ayrıca sonucun gene doğru görüntülenebilmesi için \n";
            richTextBox1.Text += "kullanıcının girdiği değerlerde \" . \" yı Replace metoduyla \" , \" e dönüştürdüm. \n";
            richTextBox1.Text += "Bu örnek 8. ders videosundaki ilk örneğe göre yapılmıştır. \n";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek
            if (OrtakSinif.GizliFormuAc("f11_v8_Aritmetik02") == 0)
            {
                f11_v8_Aritmetik02 YeniForm = new f11_v8_Aritmetik02();
                YeniForm.Show();
            }
            this.Visible = false;
        }
        private void button11_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = "Tek bir satırda  aritmetik işlem yaptırmak. 8. video\'daki 2. örnek; \n";


        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek
            if (OrtakSinif.GizliFormuAc("f12_v8_Aritmetik03") == 0)
            {
                f12_v8_Aritmetik03 YeniForm = new f12_v8_Aritmetik03();
                YeniForm.Show();
            }
            this.Visible = false;
        }
        private void button12_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = "Mod alma; Bölme işleminde kalanı bulmak. 8. video\'daki 3. örnek; \n";


        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek
            if (OrtakSinif.GizliFormuAc("f13_v8_Aritmetik04") == 0)
            {
                f13_v8_Aritmetik04 YeniForm = new f13_v8_Aritmetik04();
                YeniForm.Show();
            }
            this.Visible = false;
        }

        private void button13_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = "degisken++; ++degisken; degisken--; --degisken; terimlerinin kullanımı " +
                "\n Sayı değerini bir bir arttırma ya da eksiltme. (video 8)";


        }
        private void button14_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek
            if (OrtakSinif.GizliFormuAc("f14_v8_Aritmetik05") == 0)
            {
                f14_v8_Aritmetik05 YeniForm = new f14_v8_Aritmetik05();
                YeniForm.Show();
            }
            this.Visible = false;
        }

        private void button14_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = "degisken=degisken+5;" +
                "\n Sayı değerini istenilen değer kadar arttırma (video 8)";


        }

        private void button15_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek
            if (OrtakSinif.GizliFormuAc("f15_v9_KararKontrolDeyimleri01") == 0)
            {
                f15_v9_KararKontrolDeyimleri01 YeniForm = new f15_v9_KararKontrolDeyimleri01();
                YeniForm.Show();
            }
            this.Visible = false;
        }
        private void button15_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = "Karar ve kontrol deyimleri;" +
                "\n if() {} else {} kullanımı (video 9)" +
                "\n int.Parse(textBox2.Text);";


        }

        private void button16_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek
            if (OrtakSinif.GizliFormuAc("f16_v9_KararKontrol_if_else") == 0)
            {
                f16_v9_KararKontrol_if_else YeniForm = new f16_v9_KararKontrol_if_else();
                YeniForm.Show();
            }
            this.Visible = false;
        }
        private void button16_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = "Küme parantezi olmadan if else kullanımı (video 9)";


        }

        private void button17_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek
            if (OrtakSinif.GizliFormuAc("f17_v9_if_elseif") == 0)
            {
                f17_v9_if_elseif YeniForm = new f17_v9_if_elseif();
                YeniForm.Show();
            }
            this.Visible = false;
        }
        private void button17_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = "if(), else if() ,else kullanımı (video 9); \n DateTime.Now.Hour; " +
                "\n karsilamaMesaji.Insert(0, \"İyi akşamlar \");";


        }

        private void button18_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek

            if (OrtakSinif.GizliFormuAc("f18_v10_01_switch") == 0)
            {
                f18_v10_01_switch YeniForm = new f18_v10_01_switch();
                YeniForm.Show();
            }
            this.Visible = false;

        }

        private void button18_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = "Switch karar kontrol ifadesinin kullanımı (10.video) ";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek

            if (OrtakSinif.GizliFormuAc("f19_v10_02_atama_kosulSart_operatorleri") == 0)
            {
                f19_v10_02_atama_kosulSart_operatorleri YeniForm = new f19_v10_02_atama_kosulSart_operatorleri();
                YeniForm.Show();
            }
            this.Visible = false;

        }
        private void button19_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = "x+=y; x%=y; şeklinde kullanılan atama operatörleri örnekleri (10.video) ";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek

            if (OrtakSinif.GizliFormuAc("f20_v10_03_sart_ifadeler") == 0)
            {
                f20_v10_03_sart_ifadeler YeniForm = new f20_v10_03_sart_ifadeler();
                YeniForm.Show();
            }
            this.Visible = false;

        }
        private void button20_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = "<,>, ==,!=, &&, || şeklinde kullanılan şart operatörleri (10.video) ";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek

            if (OrtakSinif.GizliFormuAc("f21_v11_for_dongusu") == 0)
            {
                f21_v11_for_dongusu YeniForm = new f21_v11_for_dongusu();
                YeniForm.Show();
            }
            this.Visible = false;

        }
        private void button21_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = "for döngüsü; for döngüsünde < ve <= kullanmanın farkı (11.video) ";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek

            if (OrtakSinif.GizliFormuAc("f22_v11_for_dongusu_icice") == 0)
            {
                f22_v11_for_dongusu_icice YeniForm = new f22_v11_for_dongusu_icice();
                YeniForm.Show();
            }
            this.Visible = false;

        }
        private void button22_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = "for döngüsü; iç içe for döngüsü kullanım örğeni (11.video) ";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek

            if (OrtakSinif.GizliFormuAc("f23_v12_while_dongusu") == 0)
            {
                f23_v12_while_dongusu YeniForm = new f23_v12_while_dongusu();
                YeniForm.Show();
            }
            this.Visible = false;

        }
        private void button23_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = "while döngüsü ve do while döngüsü:" +
                "\n while döngüsünde koşul kontrol edilir koşul sağlandığı sürece kod işletilir " +
                "\n do while döngüsünde önce bir kere kod işletilir sonra koşul sağlandığı sürece kod işletilir" +
                "\n (12.video) ";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek

            if (OrtakSinif.GizliFormuAc("f24_v13_foreach") == 0)
            {
                f24_v13_foreach YeniForm = new f24_v13_foreach();
                YeniForm.Show();
            }
            this.Visible = false;

        }
        private void button24_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = "foreach döngüsü  (13.video) ";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek

            if (OrtakSinif.GizliFormuAc("f25_v13_Math_kullanimi") == 0)
            {
                f25_v13_Math_kullanimi YeniForm = new f25_v13_Math_kullanimi();
                YeniForm.Show();
            }
            this.Visible = false;

        }
        private void button25_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = "Math sınıfı kullanımından örnekler. Math sınıfı trigonometrik fonksiyonlar kullanılırken bildiğimiz değerlere ulaşmak için" +
                "\n [sin(30)= 0.5 gibi], Math.Sin(30) yazmak yerine Math.Sin(30DereceninRadyanDegeri) şeklinde kullanmamız gerektiğini göreceğiz. " +
                "\n (13.video) ";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek

            if (OrtakSinif.GizliFormuAc("f26_v14_Kontrol_ve_dongu_komutlari") == 0)
            {
                f26_v14_Kontrol_ve_dongu_komutlari YeniForm = new f26_v14_Kontrol_ve_dongu_komutlari();
                YeniForm.Show();
            }
            this.Visible = false;

        }
        private void button26_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = "Kontrol ve döngü komuları. (video 14)";

        }

        private void button27_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek f27_v15_Diziler

            if (OrtakSinif.GizliFormuAc("f27_v15_Diziler") == 0)
            {
                f27_v15_Diziler YeniForm = new f27_v15_Diziler();
                YeniForm.Show();
            }
            this.Visible = false;
        }

        private void button27_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = "V15 Diziler konusu işlenmiştir. ";
        }
        private void button26_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = "Kontrol ve döngü komuları. (video 14)";

        }
    }
}
