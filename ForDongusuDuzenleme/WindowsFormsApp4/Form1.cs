using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            baslangicDegeri = 0;
            ise = "<=1";
            yapD = "+";
            bD = "0";
            baslangicDegeri2 = 0;
        }
        //
        //
        // Değişkenler
        //
        //
        private int baslangicDegeri, baslangicDegeri2;
        private string ise, yapD, bD;
        private bool ctrlW = false;
        private bool ctrlE = false;
        private bool ctrlR = false;
        //
        //
        // Olaylar
        //
        //
        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TusaBasildiginda(sender, e);
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TusaBasildiginda(sender, e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baslangicDegeri2 = baslangicDegeri;
            listBox1.Items.Clear();
            

            for (; Mantık(ise, baslangicDegeri); Yap(yapD))
            {
                listBox1.Items.Add(baslangicDegeri);
            }


            label1.Text = "";
            baslangicDegeri = baslangicDegeri2;
        }
        //
        //
        // Metotlarım
        //
        //
        private void Yap(string deger)
        {
            if (deger == "+")
            {
                baslangicDegeri++;
            }
            else if (deger == "-")
            {
                baslangicDegeri--;
            }
        }
        private void TusaBasildiginda(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 17)
            {
                ctrlW = false;
                ctrlE = false;
                ctrlR = false;
                label1.Text += " ";
                baslangicDegeri = Convert.ToInt32(bD);
            }
            else if (e.KeyChar == 23 || ctrlW && !ctrlE && !ctrlR)
            {
                if (ctrlW)
                {
                    bD += e.KeyChar;
                }
                else
                {
                    baslangicDegeri = 0;
                    bD = "";
                    ctrlW = true;
                }
            }
            else if (e.KeyChar == 5 || ctrlE && !ctrlW && !ctrlR)
            {
                if (ctrlE)
                {
                    ise += e.KeyChar;
                }
                else
                {
                    ise = "";
                    ctrlE = true;
                }
            }
            else if (e.KeyChar == 18 || ctrlR && !ctrlW && !ctrlE)
            {
                if (ctrlR)
                {
                    yapD += e.KeyChar;
                }
                else
                {
                    yapD = "";
                    ctrlR = true;
                }
            }
            label1.Text += e.KeyChar;
        }
        private bool Mantık(string gelenIslem, int gelenDeger)
        {
            // Gönderilen sayının belirtilen kurala uygun olup olmadığını bulan metot; 

            string sayiTxt = "";
            int sayi;
            string islem = "";
            bool sonuc = false;

            for (int i = 0; i < gelenIslem.Length; i++)
            {
                if (gelenIslem[i] >= 48 && gelenIslem[i] <= 57)
                {
                    sayiTxt += gelenIslem[i];
                }
                else
                {
                    islem += gelenIslem[i];
                }
            }
            sayi = Convert.ToInt32(sayiTxt);


            if(islem.Trim().Length == 1)
            {
                if(gelenIslem[0] == '<')
                {
                    sonuc = gelenDeger < sayi;
                }
                else if (gelenIslem[0] == '>')
                {
                    sonuc = gelenDeger > sayi;
                }
            }
            else
            {
                if (gelenIslem[0] == '=')
                {
                    sonuc = gelenDeger == sayi;
                }
                else if (gelenIslem[0] == '<')
                {
                    sonuc = gelenDeger <= sayi;
                }
                else if (gelenIslem[0] == '>')
                {
                    sonuc = gelenDeger >= sayi;
                }
                else if (gelenIslem[0] == '!')
                {
                        sonuc = gelenDeger != sayi;
                }
            }



            return sonuc;
        }
    }
}
