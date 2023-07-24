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
    public partial class Form1 : Form
    {
        Admin admin = new Admin();

        public Form1()
        {
            InitializeComponent();
            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // "=" Tuşu
            string denklem = textBox1.Text, sonuc;

            denklem = denklem.Replace("×", "*");
            denklem = denklem.Replace("÷", "/");
            denklem = denklem.Replace(".", ",");

            MatIslem matIslem = new MatIslem();
            textBox1.Text = sonuc = matIslem.Cevap(denklem).ToString();
            Kaydet(denklem + "=" + sonuc);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 26)
            {
                admin.Show();
            }            
            else if (Properties.Settings.Default.Ikiside)
            {
                e.Handled = true;
            }
            else if (Properties.Settings.Default.Klavye)
            {
                e.Handled = true;
            }
            else
            {                
                if (e.KeyChar >= 40 && e.KeyChar <= 57)
                {
                    if(textBox1.Text == "")
                    {

                    }
                    if (e.KeyChar >= 42 && e.KeyChar <= 46 )
                    {                        
                    char txt1 = textBox1.Text[textBox1.Text.Length-1];

                        if(txt1 >= 42 && txt1 <= 46)
                        {
                            e.Handled = true;
                        }
                    }
                }
                else if (e.KeyChar == 8)
                {

                }
                else if (e.KeyChar == 13)
                {
                    button3_Click(sender, e);
                }
                else
                {
                    e.Handled = true;
                }
            }


        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Ikiside)
            {
            }
            else if (Properties.Settings.Default.Tuslar)
            {
            }
            else
            {
                Button gelenBtn = (Button)sender;
                textBox1.Text += gelenBtn.Text;
            }
        }
        private void Kaydet(string gelen)
        {
            string depo = Properties.Settings.Default.SonIslemler;
            if (depo == "")
            {
                depo = gelen + "t";
            }
            else
            {
                string[] kayıtEdilmis;
                string[] kayıtEdilecek = new string[20];
                kayıtEdilecek[0] = gelen + "t ";

                kayıtEdilmis = depo.Split('t');

                for (int i = 0; i < 19; i++)
                {
                    if(kayıtEdilmis[i] == "")
                    {
                        break;
                    }

                    kayıtEdilecek[i + 1] = kayıtEdilmis[i] + "t ";
                }
                depo = string.Join("", kayıtEdilecek);
            }
            Properties.Settings.Default.SonIslemler = depo.Trim();
            Properties.Settings.Default.Save();
        }
    }
}
