using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CSharp_Ornek_Ve_Kodlari
{

    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        //var AnaForm = new Form4();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var AnaForm = new AnaPencere();
            Application.Run(AnaForm);

        }
    }
    static class OrtakSinif
    {
        /* [ konsol */
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        //const int SW_HIDE = 0;
        //const int SW_SHOW = 5;
        /* konsol ] */
        static public int KorunacakGizliFormlarAdedi = 4;
        static public void Nedir(object Nesne)
        {
            MessageBox.Show(Nesne.ToString());
            //OrtakSinif.NesneNedir = Nesne.ToString();
            // Void "RETURN" içeremez işlem gerçekleştirir//return Nesne.ToString();
        }
        static public bool PanelAcKapa(object panelNesnesi)
        {
            Panel panel = panelNesnesi as Panel;
            if(panel.Visible==false) { panel.Visible = true;panel.Focus(); return true; }
            else { panel.Visible = false; return false; }
        }
        static public void EskiGizliFormuKapat(int AcikGizliFormlarAdedi,string KorunacakForm,string KorunacakAnaForm="AnaPencere")
        {
            int KapanacakFormlarAdedi = AcikGizliFormlarAdedi - KorunacakGizliFormlarAdedi;
            if (AcikGizliFormlarAdedi > KorunacakGizliFormlarAdedi)
            {
                for (int i = 0; i < KapanacakFormlarAdedi; i++)
                {
                    if(Application.OpenForms[i].Name!=KorunacakAnaForm&&Application.OpenForms[i].Name != KorunacakForm)
                    {
                        Application.OpenForms[i].Close();
                    }
                }
            }
        }
        static public int GizliFormuAc(string FormAdi)
        {

            int AcikFormlarSayisi = Application.OpenForms.Count;
            int FormAdiBulundu = 0;
            for(int i=0;i<AcikFormlarSayisi;i++)
            {
                if(Application.OpenForms[i].Name==FormAdi)
                {
                    Application.OpenForms[i].Visible = true;
                    FormAdiBulundu++;
                }
            }
            if(FormAdiBulundu==0)
            {
                //MessageBox.Show("Gizli " + FormAdi + " bulunamadı. Önceden çalıştırdığınıza emin misiniz?");
                
            }
            OrtakSinif.EskiGizliFormuKapat(AcikFormlarSayisi,FormAdi);
            return FormAdiBulundu;

            
        }
        static public void GizliFormlar()
        {
            string FormAdlari="";
            int AcikFormlarSayisi = Application.OpenForms.Count;
            for (int i = 0; i < AcikFormlarSayisi; i++)
            {
                FormAdlari = FormAdlari + " "+i.ToString()+"." + Application.OpenForms[i].Name;
            }
            MessageBox.Show(FormAdlari);

        }
        // [Matematik fonksiyonları bunun altına kopyala
        static public double kotanjant(double radyan)
        {
            if(radyan==0)
            {
                MessageBox.Show("0 radyanın kotanjantı tanımsızdır");
                return 0;
            }
            double Tanjant = Math.Tan(radyan);
            double Kotanjant = 1 / Tanjant;
            return Kotanjant;
        }
        //TextBoxu Sayisal işleme hazırla
        static public string NoktayiVirgule(string deger)
        {
            deger = deger.Replace(".", ",");
            return deger;
        }
        static public void merhaba()
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
        public static bool IsNumeric(this string value)
        {
            //Kaynaktan anladığım kadarıyla TryParse kullanmak için MS Visual Basic başvurusu eklenmiş olmalı.
            double Sonuc = 0;
            return double.TryParse(value, out Sonuc);
        }


    }
}
