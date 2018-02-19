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
    public partial class f27_v15_Diziler : Form
    {
        public f27_v15_Diziler()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Ana Menü
            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;//ilk açılan form
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Önceki Örnek f26_v14_Kontrol_ve_dongu_komutlari

            if (OrtakSinif.GizliFormuAc("f26_v14_Kontrol_ve_dongu_komutlari") == 0)
            {
                f26_v14_Kontrol_ve_dongu_komutlari YeniForm = new f26_v14_Kontrol_ve_dongu_komutlari();
                YeniForm.Show();
            }
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //byte i; //ismail hocanın örneğinde byte i; yazılmış yalnız bu ifade çalışmamakta. bu nedenle komut kaldırıldı.
            int[] dizi1 = new int[5];
            {
                for (int i = 0; i < 5; i++)

                    dizi1[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Yazılı Notunu Giriniz", "Bilgi Girişi", "", 10, 10));

                for (int i = 0; i < 5; i++)
                {
                    listBox1.Items.Add(dizi1[i]);
                }
            }
        }
        
        // ÖRNEK SORU 2 KODLARI
        string[] dersler = new string[4] { "Visual BASIC.NET", "C# NET", "ASP.NET", "3D GRAFİK ANİMASYON" };

        private void f27_v15_Diziler_Load(object sender, EventArgs e)
        {
            // ÖRNEK SORU 2 KODLARI
            comboBox1.Items.Add(dersler[0]);
            comboBox1.Items.Add(dersler[1]);
            comboBox1.Items.Add(dersler[2]);
            comboBox1.Items.Add(dersler[3]);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                textBox1.Text = dersler[0];
            if (comboBox1.SelectedIndex == 1)
                textBox1.Text = dersler[1];
            if (comboBox1.SelectedIndex == 2)
                textBox1.Text = dersler[2];
            if (comboBox1.SelectedIndex == 3)
                textBox1.Text = dersler[3];
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
