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
    public partial class f29_v17_Ornek_Uygulamalar_01 : Form
    {
        public f29_v17_Ornek_Uygulamalar_01()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            {
                switch (dateTimePicker1.Value.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        textBox1.Text = "Pazar";
                        break;
                    case DayOfWeek.Monday:
                        textBox1.Text = "Pazartesi";
                        break;
                    case DayOfWeek.Tuesday:
                        textBox1.Text = "Salı";
                        break;
                    case DayOfWeek.Wednesday:
                        textBox1.Text = "Çarşamba";
                        break;
                    case DayOfWeek.Thursday:
                        textBox1.Text = "Perşembe";
                        break;
                    case DayOfWeek.Friday:
                        textBox1.Text = "Cuma";
                        break;
                    case DayOfWeek.Saturday:
                        textBox1.Text = "Cumartesi";
                        break;
                    default:
                        break;
                }
                switch (dateTimePicker1.Value.Month)
                {
                    case 1:
                        textBox2.Text = "Ocak";
                        break;
                    case 2:
                        textBox2.Text = "Şubat";
                        break;
                    case 3:
                        textBox2.Text = "Mart";
                        break;
                    case 4:
                        textBox2.Text = "Nisan";
                        break;
                    case 5:
                        textBox2.Text = "Mayıs";
                        break;
                    case 6:
                        textBox2.Text = "Haziran";
                        break;
                    case 7:
                        textBox2.Text = "Temmuz";
                        break;
                    case 8:
                        textBox2.Text = "Ağustos";
                        break;
                    case 9:
                        textBox2.Text = "Eylül";
                        break;
                    case 10:
                        textBox2.Text = "Ekim";
                        break;
                    case 11:
                        textBox2.Text = "Kasım";
                        break;
                    case 12:
                        textBox2.Text = "Aralık";
                        break;
                }
            }
        }

        private void f29_v17_Ornek_Uygulamalar_01_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Ana Menü
            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;//ilk açılan form
            this.Visible = false;
        }
    }
}
