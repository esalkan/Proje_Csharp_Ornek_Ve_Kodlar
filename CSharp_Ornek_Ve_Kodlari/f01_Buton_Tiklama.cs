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
    public partial class f01_Buton_Tiklama : Form
    {
        
        //string test;
        public f01_Buton_Tiklama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Umut";
            textBox2.Text = textBox1.Text + "Sürmeli";
            textBox3.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek = f02_Mesaj_Kutusu_String_Yansitma
            if (OrtakSinif.GizliFormuAc("f02_Mesaj_Kutusu_String_Yansitma") == 0)
            {
                f02_Mesaj_Kutusu_String_Yansitma YeniForm = new f02_Mesaj_Kutusu_String_Yansitma();
                YeniForm.Show();
            }
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Ana Menü

            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;
            this.Visible=false;



        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(test);
        }
    }
}
