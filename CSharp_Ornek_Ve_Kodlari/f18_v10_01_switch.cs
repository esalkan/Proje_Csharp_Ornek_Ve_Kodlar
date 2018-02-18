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
    public partial class f18_v10_01_switch : Form
    {
        private int renkSayac = 0;
        public f18_v10_01_switch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text=="") { MessageBox.Show("Lütfen önce saati seçiniz!");return;}
            renkSayac++;
            if(renkSayac%2==0) { this.button1.ForeColor = System.Drawing.Color.Red; }
            else { this.button1.ForeColor = System.Drawing.Color.DarkBlue; }

            string karsilamaMesaji = " DEU İMYO ya hoşgeldiniz!";
            int saat = int.Parse(comboBox1.Text);
            
            switch(saat)
            {
                case 11:
                    karsilamaMesaji = karsilamaMesaji.Insert(0, "Günaydın, ");
                    this.button1.Text = karsilamaMesaji;
                    break;
                case 12:
                    karsilamaMesaji = karsilamaMesaji.Insert(0, "İyi günler, ");
                    this.button1.Text = karsilamaMesaji;
                    break;
                case 17:
                    karsilamaMesaji = karsilamaMesaji.Insert(0, "İyi akşamlar, ");
                    this.button1.Text = karsilamaMesaji;
                    break;
                default:
                    karsilamaMesaji = karsilamaMesaji.Insert(0, "Merhaba, ");
                    this.button1.Text = karsilamaMesaji;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Sonraki Örnek

            if (OrtakSinif.GizliFormuAc("f19_v10_02_atama_kosulSart_operatorleri") == 0)
            {
                f19_v10_02_atama_kosulSart_operatorleri YeniForm = new f19_v10_02_atama_kosulSart_operatorleri();
                YeniForm.Show();
            }
            this.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Ana Menü
            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;//ilk açılan form
            this.Visible = false;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            panel1.Focus();
        }
    }
}
