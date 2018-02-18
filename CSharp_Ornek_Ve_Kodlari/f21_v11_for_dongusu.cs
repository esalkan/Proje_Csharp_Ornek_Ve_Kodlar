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
    public partial class f21_v11_for_dongusu : Form
    {
        public f21_v11_for_dongusu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = 21;
            for(int i=0;i<N;i++)
            {
                textBox1.Text = i.ToString();
            }
            for (int i = 0; i <= N; i++)
            {
                textBox2.Text = i.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Ana Menü
            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;//ilk açılan form
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek

            if (OrtakSinif.GizliFormuAc("f22_v11_for_dongusu_icice") == 0)
            {
                f22_v11_for_dongusu_icice YeniForm = new f22_v11_for_dongusu_icice();
                YeniForm.Show();
            }
            this.Visible = false;

        }
    }
}
