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
    public partial class f29_v17_Ornek_Uygulamalar_02 : Form
    {
        public f29_v17_Ornek_Uygulamalar_02()
        {
            InitializeComponent();
        }

        int sayi = 1;

        private void f29_v17_Ornek_Uygulamalar_02_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(0);
            comboBox1.Items.Add(1);
            comboBox1.Items.Add(2);
            comboBox1.Items.Add(3);
            comboBox1.Items.Add(4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = comboBox1.SelectedIndex;
            switch (b)
            {
                case 0:
                    sayi = sayi + a;
                    label1.Text = "SONUÇ" + " " + sayi.ToString() + " " + " Sayıların toplamını alır.";
                    break;
                case 1:
                    sayi = sayi * a;
                    label1.Text = "SONUÇ" + " " + sayi.ToString() + " " + " Sayıların çarpımını alır.";
                    break;
                case 2:
                    sayi = sayi / a;
                    label1.Text = "SONUÇ" + " " + sayi.ToString() + " " + " Sayıların bölümünü alır.";
                    break;
                case 3:
                    sayi = sayi - a;
                    label1.Text = "SONUÇ" + " " + sayi.ToString() + " " + " farkını alır.";
                    break;
                case 4:
                    label1.Text = "SONUÇ" + " " + " 0 ile 4 arasında sayı giriniz...";
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Önceki Örnek f29_v17_Ornek_Uygulamalar_01

            if (OrtakSinif.GizliFormuAc("f29_v17_Ornek_Uygulamalar_01") == 0)
            {
                f29_v17_Ornek_Uygulamalar_01 YeniForm = new f29_v17_Ornek_Uygulamalar_01();
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

    }

}

