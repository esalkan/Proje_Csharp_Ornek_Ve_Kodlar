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
    public partial class f23_v12_while_dongusu : Form
    {
        public f23_v12_while_dongusu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 1;
            while(toplam<=555)
            {
                toplam++;
            }
            textBox1.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int toplam = 1;
            do
            {
                toplam++;
            }
            while (toplam <= 555);
            label1.Text = toplam.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Ana Menü
            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;//ilk açılan form
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek f24_v13_foreach

            if (OrtakSinif.GizliFormuAc("f24_v13_foreach") == 0)
            {
                f24_v13_foreach YeniForm = new f24_v13_foreach();
                YeniForm.Show();
            }
            this.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Önceki Örnek f22_v11_for_dongusu_icice

            if (OrtakSinif.GizliFormuAc("f22_v11_for_dongusu_icice") == 0)
            {
                f22_v11_for_dongusu_icice YeniForm = new f22_v11_for_dongusu_icice();
                YeniForm.Show();
            }
            this.Visible = false;
        }
    }
}
