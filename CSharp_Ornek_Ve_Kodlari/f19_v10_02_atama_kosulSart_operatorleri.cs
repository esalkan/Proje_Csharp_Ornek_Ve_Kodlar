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
    public partial class f19_v10_02_atama_kosulSart_operatorleri : Form
    {
        public f19_v10_02_atama_kosulSart_operatorleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y;
            if(textBox1.Text==""||textBox2.Text=="")
            {
                MessageBox.Show("Lütfen Sayı Giriniz");
                return;
            }

            //x ve y değerlerini kutulardan alalım
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            // x'in yeni değeri
            x += y; // veya x = x+y
            textBox3.Text = x.ToString();

            //x ve y değerlerini kutulardan alalım
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            // x'in yeni değeri
            x -= y; // veya x = x-y
            textBox4.Text = x.ToString();

            //x ve y değerlerini kutulardan alalım
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            // x'in yeni değeri
            x *= y; // veya x = x*y
            textBox5.Text = x.ToString();

            //x değerini kutudan alalım
            x = int.Parse(textBox1.Text);
            // x'in yeni değeri
            x++; // veya x = x+1
            textBox6.Text = x.ToString();

            //x değerini kutudan alalım
            x = int.Parse(textBox1.Text);
            // x'in yeni değeri
            x--; // veya x = x-1
            textBox7.Text = x.ToString();

            //x ve y değerlerini kutulardan alalım
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            // x'in yeni değeri
            x %= y; // veya x = x%y
            textBox8.Text = x.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Ana Menü
            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;//ilk açılan form
            this.Visible = false;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            panel1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek f20_v10_03_sart_ifadeler

            if (OrtakSinif.GizliFormuAc("f20_v10_03_sart_ifadeler") == 0)
            {
                f20_v10_03_sart_ifadeler YeniForm = new f20_v10_03_sart_ifadeler();
                YeniForm.Show();
            }
            this.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Önceki Örnek f18_v10_01_switch

            if (OrtakSinif.GizliFormuAc("f18_v10_01_switch") == 0)
            {
                f18_v10_01_switch YeniForm = new f18_v10_01_switch();
                YeniForm.Show();
            }
            this.Visible = false;
        }
    }
}
