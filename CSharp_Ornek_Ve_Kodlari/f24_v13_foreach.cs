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
    public partial class f24_v13_foreach : Form
    {
        public f24_v13_foreach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dizi = { "Pazartesi", "Salı", "Çarşamba",
                            "Perşembe", "Cuma", "Cumartesi",
                            "Pazar" };
            foreach(string x in dizi)
            {
                listBox1.Items.Add(x.ToString());
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Ana Menü
            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;//ilk açılan form
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek f25_v13_Math_kullanimi

            if (OrtakSinif.GizliFormuAc("f25_v13_Math_kullanimi") == 0)
            {
                f25_v13_Math_kullanimi YeniForm = new f25_v13_Math_kullanimi();
                YeniForm.Show();
            }
            this.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Önceki Örnek f23_v12_while_dongusu

            if (OrtakSinif.GizliFormuAc("f23_v12_while_dongusu") == 0)
            {
                f23_v12_while_dongusu YeniForm = new f23_v12_while_dongusu();
                YeniForm.Show();
            }
            this.Visible = false;
        }
    }
}
