using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartEslestirmeOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int sure = 0, suren = 0;

        private void Kur16()
        {
            kartUC1.reset();
            kartUC1.OyunBittiMi = false;
            kartUC1.KartlarArasindakiBosluk = 30;
            List<string> kartAd = new List<string>();
            List<Image> kartImage = new List<Image>();
            kartImage.Add(Properties.Resources.ay);
            kartImage.Add(Properties.Resources.dağ);
            kartImage.Add(Properties.Resources.gece);
            kartImage.Add(Properties.Resources.gol);
            kartImage.Add(Properties.Resources.gunBatimi);
            kartImage.Add(Properties.Resources.kayik);
            kartImage.Add(Properties.Resources.kiraz);
            kartImage.Add(Properties.Resources.nehir);

            for (int i = 0; i < 9; i++)
            {
                kartAd.Add("Kart" + i);
            }

            kartUC1.kur(kartAd, kartImage, Properties.Resources.Agac);
            kartUC1.KatıKadarKartlariKucult(2);
            kartUC1.KartlariOrtala(this.Width, this.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            butonsKapa();
            Kur16();
        }
        void butonsKapa()
        {
            panel1.Visible = false;

            kartUC1.Visible = true;
            timer1.Enabled = true;
            label1.Visible = true;
        }

        private void kartUC1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (kartUC1.OyunBittiMi)
            {
                panel1.Visible = true;
                button2.Text = "Tekrar Oyna";
                kartUC1.Visible = false;
                label1.Visible = false;
                suren = sure;
                label2.Text = "Süren: " + suren;
                sure = 0;
                timer1.Enabled = false;
            }

            sure += 1;
            label1.Text = "Süre: " + sure;
        }
    }
}
