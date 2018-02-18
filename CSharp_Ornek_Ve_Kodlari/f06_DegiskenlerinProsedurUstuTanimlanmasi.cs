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
    public partial class f06_DegiskenlerinProsedurUstuTanimlanmasi : Form
    {
        string ad;
        public f06_DegiskenlerinProsedurUstuTanimlanmasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ad = Microsoft.VisualBasic.Interaction.InputBox("Ad Soyad Giriniz", "Bilgi Girişi", "Adım Soyadım", 300, 300);
            textBox1.Text = ad;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = CSharp_Ornek_Ve_Kodlari.Properties.Resources.DegiskeninUstteTanimlanmasi_GlobalDegisken;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Ana Menü
            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;//ilk açılan form
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek = f07_SabitTanimlamaOrnek7
            if (OrtakSinif.GizliFormuAc("f07_SabitTanimlamaOrnek7") == 0)
            {
                f07_SabitTanimlamaOrnek7 YeniForm = new f07_SabitTanimlamaOrnek7();
                YeniForm.Show();
            }
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Önceki Örnek = f05_DegiskenlerYanYana
            if (OrtakSinif.GizliFormuAc("f05_DegiskenlerYanYana") == 0)
            {
                f05_DegiskenlerYanYana YeniForm = new f05_DegiskenlerYanYana();
                YeniForm.Show();
            }
            this.Visible = false;
        }
    }
}
