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
    public partial class f20_v10_03_sart_ifadeler : Form
    {
        public f20_v10_03_sart_ifadeler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""|| textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Lütfen birer sayı giriniz");
                return;
            }
            int x, y, a, b;
            string olumlu = "Koşul Sağlandı.";
            string olumsuz = "Koşul Sağlanamadı!";
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            a = Convert.ToInt32(textBox3.Text);
            b = Convert.ToInt32(textBox4.Text);

            if (x == y) textBox5.Text = olumlu; // x y'ye eşit olmalı
            else textBox5.Text = olumsuz;

            if (x != y) textBox6.Text = olumlu; // x y'den farklı olmalı
            else textBox5.Text = olumsuz;

            if (x > y) textBox7.Text = olumlu; // x y'den büyük olmalı
            else textBox7.Text = olumsuz;

            if (x < y) textBox8.Text = olumlu; //x y'den küçük olmalı
            else textBox8.Text = olumsuz;

            if (x >= y) textBox9.Text = olumlu; // x y'den büyük ya da y'ye eşit olmalı
            else textBox9.Text = olumsuz;

            if (x <= y) textBox10.Text = olumlu; // x y'den küçük ya da y'ye eşit olmalı
            else textBox10.Text = olumsuz;

            if (x > y||a<b) textBox11.Text = olumlu; //x y'den büyük veya a b'den küçük olmalı
            else textBox11.Text = olumsuz;

            if(x<y&&a>b) textBox12.Text = olumlu; //x y'den küçük ve a b'den büyük olmalı
            else textBox12.Text = olumsuz;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Ana Menü
            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;//ilk açılan form
            this.Visible = false;
        }

        private void picturebox1_MouseHover(object sender, EventArgs e)
        {
            panel1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           bool panelDurum = OrtakSinif.PanelAcKapa(panel1);
            if(panelDurum==false) { button4.Text = "Kodu Göster"; }
            else { button4.Text = "Kodu Gizle"; }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek

            if (OrtakSinif.GizliFormuAc("f21_v11_for_dongusu") == 0)
            {
                f21_v11_for_dongusu YeniForm = new f21_v11_for_dongusu();
                YeniForm.Show();
            }
            this.Visible = false;

        }
    }
}
