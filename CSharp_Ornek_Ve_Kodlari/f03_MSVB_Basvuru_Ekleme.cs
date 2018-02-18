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
    public partial class f03_MSVB_Basvuru_Ekleme : Form
    {
        public f03_MSVB_Basvuru_Ekleme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = Microsoft.VisualBasic.Interaction.InputBox("Ad giriniz", "Öğrenci Bilgisi", "Kimsin", 300, 300);
            string sonuc_ozet = Microsoft.VisualBasic.Strings.Left(ad, 6);
            int bir = 6;
            MessageBox.Show(sonuc_ozet + " girilenden soldan itibaren " + bir.ToString() + " tanesi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = Properties.Resources.add_reference;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = Properties.Resources.add_reference_VisualBasic;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = Properties.Resources.MSVB_Interaction_InpotBox;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Ana Menü
            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;//ilk açılan form
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
