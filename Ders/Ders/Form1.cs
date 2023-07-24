using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sonuc = Convert.ToDouble(textBox1.Text);

            if (rdb5.Checked)
            {
                sonuc = (sonuc * 95) / 100;
            }
            else if (rdb10.Checked)
            {
                sonuc = (sonuc * 90) / 100;
            }
            else if (rdb20.Checked)
            {
                sonuc = (sonuc * 80) / 100;
            }






            lblSonFiyat.Text = "Son Fiyatı:" + sonuc;
        }
    }
}
