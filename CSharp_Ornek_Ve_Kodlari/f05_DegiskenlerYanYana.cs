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
    public partial class f05_DegiskenlerYanYana : Form
    {
        public f05_DegiskenlerYanYana()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string AD1, AD2;
            AD1 = Microsoft.VisualBasic.Interaction.InputBox("1. adı gir", "Bilgi Girişi", "", 300, 300);
            AD2 = Microsoft.VisualBasic.Interaction.InputBox("2. adı gir", "Bilgi Girişi", "", 300, 300);
            textBox1.Text = AD1 + " " + AD2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Ana Menü
            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;//ilk açılan form
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = CSharp_Ornek_Ve_Kodlari.Properties.Resources.DegiskenlerYanYana;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek
            if (OrtakSinif.GizliFormuAc("DegiskenlerinProsedurUstuTanimlanmasi") == 0)
            {
                f06_DegiskenlerinProsedurUstuTanimlanmasi YeniForm = new f06_DegiskenlerinProsedurUstuTanimlanmasi();
                YeniForm.Show();
            }
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
