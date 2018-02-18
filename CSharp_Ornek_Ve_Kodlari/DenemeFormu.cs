using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
//
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace CSharp_Ornek_Ve_Kodlari
{
    public partial class DenemeFormu : Form
    {
        //[DllImport("kernel32.dll", SetLastError = true)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //static extern bool AllocConsole();
        //const int SW_HIDE = 0;
        //const int SW_SHOW = 5;
        public DenemeFormu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrtakSinif.GizliFormlar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ana Menü
            OrtakSinif.GizliFormuAc("AnaPencere"); //Application.OpenForms[0].Visible = true;//ilk açılan form
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //OrtakSinif.merhaba(); //Konsol "merhaba" ÇALIŞMIYOR
            //CSharp_Ornek_Ve_Kodlari.Properties.Resources.

        }
        /*
        private void DenemeFormu_Load(object sender, EventArgs e)
        {
            AllocConsole();
            Console.WriteLine("merhaba");
            Console.ReadLine();
            this.Hide();
        }
        */

        private void button4_Click(object sender, EventArgs e)
        {
            /* sadece cmd'yi çalıştırıyor
            string strCmdText;
            strCmdText = "dir /p"; //"/C copy /b Image1.jpg + Archive.rar Image2.jpg";
            var x=System.Diagnostics.Process.Start("CMD.exe");
            x.WriteLine("dir /p");
            //Console.WriteLine("dir /p \n\r");
            */
            /* KOMUT ALMIYOR 
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal; //.Hidden
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "dir /p"; //"/C copy /b Image1.jpg + Archive.rar Image2.jpg";
            process.StartInfo = startInfo;
            process.Start();
            */
            //using System.Diagnostics;


            /*
            var proc1 = new ProcessStartInfo();
            string anyCommand="dir /p";
            proc1.UseShellExecute = true;

            //proc1.WorkingDirectory = @"C:\Windows\System32";
            çalışıyor ama windows/system32/ altında 
            proc1.FileName = @"cmd.exe"; //"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Normal; //.Hidden
            Process.Start(proc1);
            */
            /* çalışıyor: farklı çalıştır system32 klasöründe başlıyor
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal; //.Hidden
            startInfo.Verb = "runas";// yeni eklendi
            startInfo.FileName = @"cmd.exe";
            startInfo.Arguments = "/c dir /p"; //"/C copy /b Image1.jpg + Archive.rar Image2.jpg";
            process.StartInfo = startInfo;
            process.Start();
            */
            //System.Diagnostics.Process konsol = new System.Diagnostics.Process();
            //System.Diagnostics.Process process = new System.Diagnostics.Process();
            //MessageBox.Show(Convert.ToString(x));


        }

        private void button5_Click(object sender, EventArgs e)
        //private string GetMacAddress()
        {

            string[,] macAddresses =new string[10,2];// = string.Empty;
                                                      //string pasifMacAdresses="";
                                                      //IDictionary<string, string> TipiVeDegeri;

            int i = 0;
            
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                i++;
                string tipi = nic.NetworkInterfaceType.ToString();
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    macAddresses[0,0] = tipi;
                    macAddresses[0,1] = nic.GetPhysicalAddress().ToString();//(nic.GetPhysicalAddress().ToString()==null?"null": nic.GetPhysicalAddress().ToString());
                    listBox1.Items.Add(macAddresses[0,0] +":"+ macAddresses[0,1]);

                }
                else
                {
                    macAddresses[i,0] = tipi;
                    macAddresses[i, 1] = nic.GetPhysicalAddress().ToString();// (nic.GetPhysicalAddress().ToString() == null ? "null" : nic.GetPhysicalAddress().ToString());
                    listBox1.Items.Add(macAddresses[i,0] + ":" + macAddresses[i,1]);

                }
            }
            

        }
                
                /*
        {
            const int MIN_MAC_ADDR_LENGTH = 12;
            string macAddress = string.Empty;
            long maxSpeed = -1;

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                log.Debug(
                    "Found MAC Address: " + nic.GetPhysicalAddress() +
                    " Type: " + nic.NetworkInterfaceType);

                string tempMac = nic.GetPhysicalAddress().ToString();
                if (nic.Speed > maxSpeed &&
                    !string.IsNullOrEmpty(tempMac) &&
                    tempMac.Length >= MIN_MAC_ADDR_LENGTH)
                {
                    log.Debug("New Max Speed = " + nic.Speed + ", MAC: " + tempMac);
                    maxSpeed = nic.Speed;
                    macAddress = tempMac;
                }
            }

            //return macAddress;
            textBox1.Text = macAddress;
        }
        */
    }
}
