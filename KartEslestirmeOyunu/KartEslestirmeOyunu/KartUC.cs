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
   
    public partial class KartUC : UserControl
    {
        public KartUC()
        {
            InitializeComponent();
            this.Controls.Add(KartKonumu);
            KartlarArasindakiBosluk = 30;
        }
        public bool OyunBittiMi = false;
        public int KartSayisi { get; set; }
        public Panel KartKonumu = new Panel();
        private Kart AktifKart;
    
        public List<Kart> Kartlar = new List<Kart>();
        private Kart GelenKart;
        public int KartlarArasindakiBosluk;
        private bool Time1 
        { 
            get
            {
                return timer1.Enabled;
            }
            set
            {
                timer1.Enabled = value;
            }
        }
        private bool Time2 
        {
            get
            {
                return timer2.Enabled;
            }
            set
            {
                timer2.Enabled = value;
            }
        }
        public bool TimersOn()
        {
            bool ret = Time1 || Time2;
            return ret;
        }

        private int AktifKartIndex (Kart aktif)
        {
            int ret = -1;

            for (int i = 0; i < KartKonumu.Controls.Count; i++)
            {
                if (KartKonumu.Controls[i] is Kart)
                {
                    if ((Kart)KartKonumu.Controls[i] == aktif)
                    {
                        ret = i;
                    }
                }
            }
            return ret;
        }

        public List<Kart> seciliKartlar()
        {
            List<Kart> ret = new List<Kart>();
            for (int i = 0; i < KartKonumu.Controls.Count; i++)
            {
                if (KartKonumu.Controls[i] is Kart)
                {
                    Kart co = (Kart)KartKonumu.Controls[i];

                    if (co.Secilimi)
                    {
                        ret.Add(co);
                    }
                }
            }
            return ret;
        }

        public void KartEkle(int kartSayisi, List<string> names, List<Image> arkaplanResimleri, Image kartResmi)
        {
            for (int i = 0; i < kartSayisi; i++)
            {
                Kart mevcutKart = new Kart(this);
                Kart mevcutKartinEsi = new Kart(this);

                mevcutKart.KartNo = i.ToString();
                mevcutKart.KartName = names[i];
                mevcutKart.KartArkaYuzu.BackgroundImage = arkaplanResimleri[i];
                mevcutKart.KartResmi = kartResmi;
                mevcutKart.Width = 200;
                mevcutKart.Height = 300;

                mevcutKartinEsi.KartNo = i.ToString();
                mevcutKartinEsi.KartName = names[i] + "Esi";
                mevcutKartinEsi.KartArkaYuzu.BackgroundImage = arkaplanResimleri[i];
                mevcutKartinEsi.KartResmi = kartResmi;
                mevcutKartinEsi.Width = 200;
                mevcutKartinEsi.Height = 300;


                Kartlar.Add(mevcutKart);
                Kartlar.Add(mevcutKartinEsi);
            }
        }
        private List<Kart> SayilariRandomSirala(List<Kart> gKarts)
        {
            List<Kart> ret = new List<Kart>();
            Random rnd = new Random();

            for (int i = 0; i < gKarts.Count; )
            {
                int aktifRandomSayi = rnd.Next(0, gKarts.Count);

                ret.Add(gKarts[aktifRandomSayi]);
                gKarts.RemoveAt(aktifRandomSayi);
            }
            return ret;
        }
        public void KartKaristir(List<Kart> karts)
        {
            List<Kart> ret = SayilariRandomSirala(karts);
            Kartlar = ret;
        }
        public void KartlariKontroleEkle(List<Kart> karts)
        {
            for (int i = 0; i < karts.Count; i++)
            {
                KartKonumu.Controls.Add(karts[i]);
            }

            for (int i = 0; i < KartKonumu.Controls.Count; i++)
            {
                if (KartKonumu.Controls[i] is Kart)
                {
                    KartKonumu.Controls[i].Width = 200;
                    KartKonumu.Controls[i].Height = 200;
                }
            }
        }
        public void KartlariDiz(int[] gXYKartSayisi, int kartlarArasindakiMesafe)
        {
            int ArasindakiMesafe = kartlarArasindakiMesafe;
            int satiraEklenenKart = 0;
            int[] xYKartSayisi = gXYKartSayisi;
            // bool kartlariDiz;
            int[] sonKonumXY = {0, 0};

            List<Kart> kartAraList = new List<Kart>();
            for (int i = 0; i < KartKonumu.Controls.Count; i++)
            {
                Kart k = (Kart)KartKonumu.Controls[i];

                k.Left = sonKonumXY[0];
                k.Top = sonKonumXY[1];

                if (satiraEklenenKart < xYKartSayisi[0]-1)
                {
                    sonKonumXY[0] += k.Width + kartlarArasindakiMesafe;
                    satiraEklenenKart++;
                }
                else
                {
                    sonKonumXY[0] = 0;
                    sonKonumXY[1] += k.Height + kartlarArasindakiMesafe;

                    satiraEklenenKart = 0;
                }
                kartAraList.Add(k);
            }
            for (int i = 0; i < kartAraList.Count; i++)
            {
                KartKonumu.Controls.Add(kartAraList[i]);
            }
            if (KartKonumu.Controls.Count != 0)
            {
                KartKonumu.Width = (KartKonumu.Controls[0].Width * xYKartSayisi[0]) + (kartlarArasindakiMesafe * (xYKartSayisi[0] - 1));
                KartKonumu.Height = (KartKonumu.Controls[0].Height * xYKartSayisi[1]) + (kartlarArasindakiMesafe * (xYKartSayisi[1] - 1));
            }
            


            //int[] sonKonumXY = { this.Width / (xYKartSayisi[0]), this.Height / (xYKartSayisi[1]+4)};

            //for (int i = 0; i < this.Controls.Count; i++)
            //{
            //    if (this.Controls[i] is Kart)
            //    {
            //        kartlariDiz = this.Width >= (this.Controls[i].Width * xYKartSayisi[0] + (kartlarArasindakiMesafe * (xYKartSayisi[0] - 1))) && this.Height >= (this.Controls[i].Height * xYKartSayisi[1] + (kartlarArasindakiMesafe * (xYKartSayisi[1] - 1)));
            //        if (kartlariDiz)
            //        {
            //            if (satiraEklenenKart <= xYKartSayisi[0])
            //            {
            //                this.Controls[i].Left = sonKonumXY[0];
            //                this.Controls[i].Top = sonKonumXY[1];

            //                sonKonumXY[0] += this.Controls[i].Width + kartlarArasindakiMesafe;
            //                satiraEklenenKart++;
            //            }
            //            else
            //            {
            //                satiraEklenenKart = 1;
            //                sonKonumXY[0] = this.Width / (xYKartSayisi[0]);
            //                sonKonumXY[1] += this.Controls[i].Height + kartlarArasindakiMesafe;
            //                this.Controls[i].Left = sonKonumXY[0];
            //                this.Controls[i].Top = sonKonumXY[1];
            //                sonKonumXY[0] += this.Controls[i].Width + kartlarArasindakiMesafe;
            //            }
            //        }
            //        else
            //        {
            //            for (int j = 0; j < this.Controls.Count; j++)
            //            {
            //                this.Controls[j].Width /= 2;
            //                this.Controls[j].Height /= 2;
            //            }
            //            kartlarArasindakiMesafe /= 2;
            //            i--;
            //        }
            //    }
            //}
        }
        public void KatıKadarKartlariKucult(double kat)
        {
            for (int i = KartKonumu.Controls.Count-1; i >= 0; i--)
            {
                Kart k = (Kart)KartKonumu.Controls[i];

                k.Width = Convert.ToInt32(k.Width / kat);
                k.Height = Convert.ToInt32(k.Height / kat);

                KartKonumu.Controls.RemoveAt(i);
                KartKonumu.Controls.Add(k);
            }
            KartlarArasindakiBosluk = Convert.ToInt32(KartlarArasindakiBosluk / kat);
            int s = Convert.ToInt32(Math.Sqrt(KartKonumu.Controls.Count));
            int[] konum = { s, s };

            KartlariDiz(konum, KartlarArasindakiBosluk);
        }
        public void KartlariOrtala(int formWidth, int formHeight)
        {
            formWidth = formWidth / 2;
            formHeight = formHeight / 2;

            KartKonumu.Left = formWidth - (KartKonumu.Width / 2);
            KartKonumu.Top = formHeight - (KartKonumu.Height / 2);
        }
        public void reset()
        {
            KartKonumu.Controls.Clear();
            Kartlar.Clear();
        }
        public void kur(List<string> kartIsımleri, List<Image> kartResimleri, Image kartResmi)
        {
            KartSayisi = kartIsımleri.Count - 1;
            int[] s = new int[2];
            s[0] = Convert.ToInt32(Math.Sqrt(KartSayisi));
            s[1] = s[0];

            KartEkle(KartSayisi, kartIsımleri, kartResimleri, kartResmi);
            KartKaristir(Kartlar);
            KartlariKontroleEkle(Kartlar);
            KartlariDiz(s, KartlarArasindakiBosluk);
        }
        public Kart karar(Kart gKart)
        {
            List<Kart> sK = seciliKartlar();

            if (timer1.Enabled || timer2.Enabled)
            {

            }
            else if (sK.Count == 1)
            {
                AktifKart = gKart;
                gKart.KartArkaYuzu.Visible = true;
            }
            else if (AktifKart == gKart)
            {
                gKart.KartArkaYuzu.Visible = false;
                gKart.Secilimi = false;
            }
            else if (AktifKart != null && AktifKart.KartNo == gKart.KartNo)
            {
                gKart.KartArkaYuzu.Visible = true;
                GelenKart = gKart;
                timer1.Enabled = true;
            }
            else if (AktifKart != gKart)
            {
                gKart.KartArkaYuzu.Visible = true;
                GelenKart = gKart;
                timer2.Enabled = true;
            }
            return gKart;
        }
        
        private void GelenKartıAta(Kart ayarliKart)
        {
            for (int i = 0; i < KartKonumu.Controls.Count; i++)
            {
                if (KartKonumu.Controls[i] is Kart)
                {
                    Kart k = (Kart)KartKonumu.Controls[i];

                    if (k == GelenKart)
                    {
                        k = ayarliKart;
                        break;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Kart ayar = GelenKart;

            int kIndex = AktifKartIndex(AktifKart);
            //this.Controls.RemoveAt(kIndex);
            KartKonumu.Controls.RemoveAt(kIndex);

            AktifKart.Secilimi = false;
            AktifKart.Visible = false;

            //this.Controls.Add(AktifKart);
            KartKonumu.Controls.Add(AktifKart);

            ayar.Secilimi = false;
            ayar.Visible = false;

            GelenKartıAta(ayar);

            timer1.Enabled = false;

            bool mi = true;

            for (int i = 0; i < KartKonumu.Controls.Count; i++)
            {
                if (KartKonumu.Controls[i].Visible)
                {
                    mi = false;
                    break;
                }

            }
            this.OyunBittiMi = mi;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Kart ayar = GelenKart;


            int kIndex = AktifKartIndex(AktifKart);

            AktifKart.Secilimi = false;
            AktifKart.KartArkaYuzu.Visible = false;

            //this.Controls.RemoveAt(kIndex);
            //this.Controls.Add(AktifKart);
            KartKonumu.Controls.RemoveAt(kIndex);
            KartKonumu.Controls.Add(AktifKart);

            AktifKart = null;
            ayar.KartArkaYuzu.Visible = false;
            ayar.Secilimi = false;

            GelenKartıAta(ayar);

            timer2.Enabled = false;

        }

        private void KartUC_Resize(object sender, EventArgs e)
        {
            int[] s = new int[2];
            s[0] = Convert.ToInt32(Math.Sqrt(KartSayisi));
            s[1] = s[0];

            KartlariDiz(s, KartlarArasindakiBosluk);
        }
    }
}
