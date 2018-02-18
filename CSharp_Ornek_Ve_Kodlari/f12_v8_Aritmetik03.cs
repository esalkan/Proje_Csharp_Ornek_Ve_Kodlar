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
    public partial class f12_v8_Aritmetik03 : Form
    {
        public f12_v8_Aritmetik03()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Ana Menü
            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;//ilk açılan form
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bolunen, bolen, bolum, kalan;
            if(textBox1.Text==""||textBox2.Text=="")
            {
                MessageBox.Show("Sayı giriniz!");
                return;
            }
            bolunen = Convert.ToInt32(textBox1.Text);
            bolen = Convert.ToInt32(textBox2.Text);
            kalan = bolunen % bolen; //MOD
            bolum = (bolunen - kalan) / bolen;
            textBox3.Text = bolum.ToString();// bölme işlemi sonucu
            textBox4.Text = kalan.ToString();//mod
            textBox5.Text = Convert.ToString(bolen * bolum);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek
            if (OrtakSinif.GizliFormuAc("f13_v8_Aritmetik04") == 0)
            {
                f13_v8_Aritmetik04 YeniForm = new f13_v8_Aritmetik04();
                YeniForm.Show();
            }
            this.Visible = false;
        }
    }
}
