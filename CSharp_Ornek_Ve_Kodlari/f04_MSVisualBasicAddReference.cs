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
    public partial class f04_MSVisualBasicAddReference : Form
    {
        public f04_MSVisualBasicAddReference()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = Microsoft.VisualBasic.Interaction.InputBox("Adınızı giriniz:", "Öğrenci Bilgi Girişi", "", 300, 300);
            string AdiSagdanAl = Microsoft.VisualBasic.Strings.Right(ad, 4);
            MessageBox.Show("Adınızın sağdan son 4 harfi: " + AdiSagdanAl);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Ana Menü
            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;//ilk açılan form
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = CSharp_Ornek_Ve_Kodlari.Properties.Resources.add_reference;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = CSharp_Ornek_Ve_Kodlari.Properties.Resources.add_reference_VisualBasic;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = CSharp_Ornek_Ve_Kodlari.Properties.Resources.MSVB_Interaction_InpotBox2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Örnek 5
            if (OrtakSinif.GizliFormuAc("DegiskenlerYanYana") == 0)
            {
                f05_DegiskenlerYanYana YeniForm = new f05_DegiskenlerYanYana();
                YeniForm.Show();
            }
            this.Visible = false;
        }
    }
}
