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
    public partial class f09_v7_veri_tipleri : Form
    {

        public f09_v7_veri_tipleri()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Ana Menü
            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;//ilk açılan form
            this.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://social.msdn.microsoft.com/Forums/tr-TR/379a88e0-ebd5-4666-9b73-e16f77698a38/c-deikenler-veri-tipleri?forum=csharptr");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrtakSinif.GizliFormlar();
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            panel1.Focus();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek = f10_v8_Aritmetik01
            if (OrtakSinif.GizliFormuAc("f10_v8_Aritmetik01") == 0)
            {
                f10_v8_Aritmetik01 YeniForm = new f10_v8_Aritmetik01();
                YeniForm.Show();
            }
            this.Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Önceki Örnek = f07_SabitTanimlamaOrnek7.cs
            if (OrtakSinif.GizliFormuAc("f07_SabitTanimlamaOrnek7") == 0)
            {
                f07_SabitTanimlamaOrnek7 YeniForm = new f07_SabitTanimlamaOrnek7();
                YeniForm.Show();
            }
            this.Visible = false;
        }
    }
}
