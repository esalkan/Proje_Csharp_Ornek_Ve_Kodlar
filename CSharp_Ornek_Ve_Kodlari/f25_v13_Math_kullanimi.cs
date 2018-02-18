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
    public partial class f25_v13_Math_kullanimi : Form
    {
        public f25_v13_Math_kullanimi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.E); //"merhaba dünya";
            textBox2.Text = Convert.ToString(Math.PI);

            double Radyan = 30 * Math.PI / 180;
            // 30 dereceyi Radyan cinsinden yazdık
            textBox3.Text = Convert.ToString(Math.Sin(Radyan));
            // 30 derecenin Radyan Karşılığının Sinüsü 0.5 geldi

            Radyan = 45 * Math.PI / 180; //45 derecenin Radyanı
            textBox4.Text = Convert.ToString(Math.Tan(Radyan)); //45 derecenin Tanjant değeri 1

            Radyan = 60 * Math.PI / 180; //60 derecenin Radyanı
            textBox5.Text = Convert.ToString(Math.Cos(Radyan)); //60 derecenin Tanjant değeri 1


            textBox6.Text = Convert.ToString(Math.Exp(3));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox7.Text=="")
            {
                MessageBox.Show("Derece giriniz");
                return;
            }

            int derece;
            double radyan;
            double dereceyi_tekrar_hesapla;
            //int derece
            //dereceyi radyana dönüştürelim
            derece = int.Parse(textBox7.Text);
            radyan = derece * Math.PI / 180;
            textBox8.Text = radyan.ToString();

            //radyanı dereceye dönüştürelim
            dereceyi_tekrar_hesapla = radyan * 180 / Math.PI;
            textBox9.Text = dereceyi_tekrar_hesapla.ToString();

            //sinüs,kosinüs,tanjant ve kotanjantını alalım

            textBox10.Text = Convert.ToString(Math.Sin(radyan));
            textBox11.Text = Convert.ToString(Math.Cos(radyan));
            textBox12.Text = Convert.ToString(Math.Tan(radyan));
            textBox13.Text = Convert.ToString(OrtakSinif.kotanjant(radyan));
            // OrtakSinif.kotanjant şu işlemi yapar: x=1/Math.Tan(radyan) ; return x;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Ana Menü
            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;//ilk açılan form
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool durum = OrtakSinif.PanelAcKapa(panel2);
            if(durum==false) { button5.Text = "Kodu Göster"; }
            else { button5.Text = "Kodu Gizle"; }
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            tabPage1.Focus();
        }
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            tabPage2.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek

            if (OrtakSinif.GizliFormuAc("f26_v14_Kontrol_ve_dongu_komutlari") == 0)
            {
                f26_v14_Kontrol_ve_dongu_komutlari YeniForm = new f26_v14_Kontrol_ve_dongu_komutlari();
                YeniForm.Show();
            }
            this.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Önceki Örnek f24_v13_foreach

            if (OrtakSinif.GizliFormuAc("f24_v13_foreach") == 0)
            {
                f24_v13_foreach YeniForm = new f24_v13_foreach();
                YeniForm.Show();
            }
            this.Visible = false;
        }
    }
}
