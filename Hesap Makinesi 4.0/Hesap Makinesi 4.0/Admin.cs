using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hesap_Makinesi_4._0
{
    public partial class Admin : Form
    {


        public Admin()
        {
            InitializeComponent();

            string[] sonIslem;
            string kayıtGelen = Properties.Settings.Default.SonIslemler;

            sonIslem = kayıtGelen.Split('t');

            for(int i = 0; i < sonIslem.Length; i++)
            {
                listBox1.Items.Add(sonIslem[i].Trim());
            }



            radioButton1.Checked = Properties.Settings.Default.Klavye;
            radioButton2.Checked = Properties.Settings.Default.Tuslar;
            radioButton3.Checked = Properties.Settings.Default.Ikiside;
            checkBox2.Checked = Properties.Settings.Default.KilitliMi;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.KilitliMi = checkBox2.Checked;
            groupBox1.Visible = checkBox2.Checked;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Klavye = radioButton1.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Tuslar = radioButton2.Checked;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Ikiside = radioButton3.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string kayıtGelen = Properties.Settings.Default.SonIslemler;
            string[] sonIslem = kayıtGelen.Split('t');

            for (int i = 0; i < sonIslem.Length; i++)
            {
                listBox1.Items.Add(sonIslem[i].Trim());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Properties.Settings.Default.SonIslemler = "";
            Properties.Settings.Default.Save();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
