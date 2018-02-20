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
    public partial class f31_v19_Uygulama_Ornekleri_04_02 : Form
    {
        public f31_v19_Uygulama_Ornekleri_04_02()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Ana Menü
            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;//ilk açılan form
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 1;
            do
            {
                MessageBox.Show("Sayı Değeri : " + count);
                label2.Text = Convert.ToString("Sayı Değeri : " + " " + count);
                count = count + 1;
            } while (count <= 10);
        }

    }
}
