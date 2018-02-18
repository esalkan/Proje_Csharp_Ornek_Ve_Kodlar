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
    public partial class f22_v11_for_dongusu_icice : Form
    {
        public f22_v11_for_dongusu_icice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int x=1; x<=3;x=x+=1)
            {
                for(int k=1;k<=3;k=k+=1)
                {
                    for(int y=1;y<=3;y+=1)
                    {
                        listBox1.Items.Add(" " + x + "  " + k + "  " + y);
                    }
                }
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

            if (OrtakSinif.GizliFormuAc("f23_v12_while_dongusu") == 0)
            {
                f23_v12_while_dongusu YeniForm = new f23_v12_while_dongusu();
                YeniForm.Show();
            }
            this.Visible = false;

        }
    }
}
