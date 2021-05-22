using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pc_samp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ServerIP = "127.0.0.1:7777 ";//put your ip and port in this line
            string SPHash = ""; //PASSWORD
            string GTAPath = Registry.CurrentUser.OpenSubKey(@"Software\\SAMP").GetValue("gta_sa_exe").ToString();
            GTAPath = GTAPath.Substring(0, GTAPath.LastIndexOf(@"\") + 1);
            string[] ImaCheat1 = Directory.GetDirectories(GTAPath, "cleo");
            string[] ImaCheat2 = Directory.GetFiles(GTAPath, "CLEO.asi");
            string[] ImaCheat3 = Directory.GetFiles(GTAPath, "d3d9.dll");
            string[] ImaCheat4 = Directory.GetFiles(GTAPath, "SAMPFUNCS.asi");
            string[] ImaCheat5 = Directory.GetDirectories(GTAPath, "mod_sa");
            string[] ImaCheat6 = Directory.GetDirectories(GTAPath, "OverLight_Mod");
            string[] ImaCheat7 = Directory.GetFiles(GTAPath, "vorbishooked.dll");
            if (((ImaCheat1.Length > 0) || (ImaCheat2.Length > 0)) || ((ImaCheat3.Length > 0) || (ImaCheat4.Length > 0)))
            {
                MessageBox.Show("HAPUS DULU CHEATNYA!!!!!", "CHEAT DITEMUKAN!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if ((ImaCheat5.Length > 0) || (ImaCheat6.Length > 0))
            {
                MessageBox.Show("HAPUS DULU CHEATNYA!!!!!", "CHEAT DITEMUKAN!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (ImaCheat7.Length > 0)
            {
                MessageBox.Show("HAPUS DULU CHEATNYA!!!!!", "CHEAT DITEMUKAN!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                Registry.CurrentUser.OpenSubKey(@"Software\SAMP", true).SetValue("PlayerName", textBox1.Text);
                Process.Start(GTAPath + "samp.exe", ServerIP + SPHash);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
