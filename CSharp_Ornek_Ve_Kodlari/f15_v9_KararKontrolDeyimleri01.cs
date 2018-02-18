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
    public partial class f15_v9_KararKontrolDeyimleri01 : Form
    {
        public f15_v9_KararKontrolDeyimleri01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text==""|| textBox3.Text == "") { MessageBox.Show("Sayı Giriniz");return;}
            double gecNot;
            int vizeNot = int.Parse(textBox2.Text);
            int finalNot = int.Parse(textBox3.Text);
            gecNot = vizeNot * 0.4 + finalNot * 0.6;
            gecNot = Math.Round(gecNot);

            if(gecNot>50)
            {
                MessageBox.Show("Geçtiniz Tebrikler... "+gecNot.ToString());
            }
            else
            {
                MessageBox.Show("Daha çok çalışmalısınız " + gecNot.ToString());
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Ana Menü
            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;//ilk açılan form
            this.Visible = false;
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            panel1.Visible = false;
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            panel1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek
            if (OrtakSinif.GizliFormuAc("f16_v9_KararKontrol_if_else") == 0)
            {
                f16_v9_KararKontrol_if_else YeniForm = new f16_v9_KararKontrol_if_else();
                YeniForm.Show();
            }
            this.Visible = false;
        }
    }
}
