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
    public partial class f26_v14_Kontrol_ve_dongu_komutlari : Form
    {
        public f26_v14_Kontrol_ve_dongu_komutlari()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Bu örnetke Microsoft.VisualBasic.Interaction.InputBox kullanmak için Proje>"Başvuru Ekle" ya da "Add Reference"
            // menüsünden Microsoft VisualBasic'i eklemeniz lazım.
            // ayrıca OrtakSinif.IsNumeric(değer) fonksiyonunu kendimiz oluşturduk.
            // Bundan önceki örneklerde InputBox'tan gelen verinin sadece boş olup olmadığını kontrol ediyorduk.
            // Veri kısmına harf girilirse gene program hata veriyordu. 
            // Bundan sonraki örneklerde InputBox'tan gelen verilerin sayısal olup olmadığını kontrol etmek için
            // daha iyisini bulana kadar OrtakSinif.IsNumeric(string InputBoxtanGelen) fonksiyonunu kullanabiliriz.
            int gelir = 0;
            string InputBoxtanGelen = Microsoft.VisualBasic.Interaction.InputBox("Maaşınızı Girin", "Maaş Bilgisi", "", 120, 120);
            if (OrtakSinif.IsNumeric(InputBoxtanGelen) == false)
            {
                MessageBox.Show("Lütfen sayısal bir veri giriniz");
                return;
            }
            else
            {
               gelir = Convert.ToInt32(InputBoxtanGelen);
            }
            if(gelir>=5000) { MessageBox.Show("gelir düzeyi yüksek");}
            else if(gelir>=2500) { MessageBox.Show("Orta gelirli"); }
            else if(gelir>=1500) { MessageBox.Show("Yaşayabilecek kadar geliri var"); }
            else { MessageBox.Show("Üzülme yıkılmadık ayaktayız. Hayat devam ediyor. Daha iyisini yapabiliriz :) "); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Önceki Örnek f25_v13_Math_kullanimi

            if (OrtakSinif.GizliFormuAc("f25_v13_Math_kullanimi") == 0)
            {
                f25_v13_Math_kullanimi YeniForm = new f25_v13_Math_kullanimi();
                YeniForm.Show();
            }
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Ana Menü
            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;//ilk açılan form
            this.Visible = false;
        }
    }
}
