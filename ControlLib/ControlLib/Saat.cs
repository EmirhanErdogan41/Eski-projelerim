using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControlLib
{
    public partial class Saat : UserControl
    {
        public enum Boyutlar
        {
            None,
            Kucuk,
            Orta,
            Buyuk
        }
        public Saat()
        {
            InitializeComponent();
            AkrepUzunlugu = this.Width / 2 / 50 * 20;
            YelkovanUzunlugu = this.Width / 2 / 50 * 30;
            SaniyeUzunlugu = this.Width / 2 / 50 * 46;
            AkrepPen = new Pen(Color.Black, 5f);
            YelkovanPen = new Pen(Color.Black, 3f);
            SaniyePen = new Pen(Color.Red, 1f);

        }

        public PointF MerkezNoktasi
        {
            get
            {
                return new PointF(Convert.ToSingle(this.Width / 2), Convert.ToSingle(this.Height / 2));
            }
        }
        public int AkrepUzunlugu { get; set; }
        public int YelkovanUzunlugu { get; set; }
        public int SaniyeUzunlugu { get; set; }
        public Pen AkrepPen { get; set; }
        public Pen YelkovanPen { get; set; }
        public Pen SaniyePen { get; set; }
	private bool _boyutlandirilsin;
        public bool Boyutlandirilsin
        {
            get
            {
                return _boyutlandirilsin;
            }
            set
            {
                _boyutlandirilsin = value;
                saatBoyutuToolStripMenuItem.Visible = value;
            }
        }
        private Boyutlar _boyutu;
        public Boyutlar Boyutu 
        { 
            get
            {
                return this._boyutu;
            }
            set
            {
                this._boyutu = value;
                if (value == Boyutlar.None)
                {
                    AkrepUzunlugu = this.Width / 2 / 50 * 20;
                    YelkovanUzunlugu = this.Width / 2 / 50 * 30;
                    SaniyeUzunlugu = this.Width / 2 / 50 * 46;
                    AkrepPen = new Pen(Color.Black, 5f);
                    YelkovanPen = new Pen(Color.Black, 3f);
                    SaniyePen = new Pen(Color.Red, 1f);
                }
                else if(value == Boyutlar.Kucuk)
                {
                    this.Width = 60;
                    this.Height = 60;

                    AkrepPen.Width = 2;
                    YelkovanPen.Width = 2;
                    SaniyePen.Width = 1;

                    AkrepUzunlugu = 10;
                    YelkovanUzunlugu = 15;
                    SaniyeUzunlugu = 25;
                }
                else if(value == Boyutlar.Orta)
                {
                    this.Width = 120;
                    this.Height = 120;

                    AkrepPen.Width = 5;
                    YelkovanPen.Width = 4;
                    SaniyePen.Width = 2;

                    AkrepUzunlugu = 20;
                    YelkovanUzunlugu = 30;
                    SaniyeUzunlugu = 50;
                }
                else if (value == Boyutlar.Buyuk)
                {
                    this.Width = 240;
                    this.Height = 240;

                    AkrepPen.Width = 7;
                    YelkovanPen.Width = 6;
                    SaniyePen.Width = 3;

                    AkrepUzunlugu = 40;
                    YelkovanUzunlugu = 60;
                    SaniyeUzunlugu = 100;
                }
            }
        }
























        private void Timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Saat_Paint(object sender, PaintEventArgs e)
        {
            int saniyeDerece = DateTime.Now.Second * 6;
            int yelkovanDerece = DateTime.Now.Minute * 6;
            int akrepDerece = DateTime.Now.Hour * 30 + (yelkovanDerece/12);

            double snx = MerkezNoktasi.X + (SaniyeUzunlugu * Math.Sin(saniyeDerece * Math.PI / 180));
            double sny = MerkezNoktasi.Y - (SaniyeUzunlugu * Math.Cos(saniyeDerece * Math.PI / 180));

            double dx = MerkezNoktasi.X + (YelkovanUzunlugu * Math.Sin(yelkovanDerece * Math.PI / 180));
            double dy = MerkezNoktasi.Y - (YelkovanUzunlugu * Math.Cos(yelkovanDerece * Math.PI / 180));

            double sax = MerkezNoktasi.X + (AkrepUzunlugu * Math.Sin(akrepDerece * Math.PI / 180));
            double say = MerkezNoktasi.Y - (AkrepUzunlugu * Math.Cos(akrepDerece * Math.PI / 180));

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawLine(AkrepPen, MerkezNoktasi.X, MerkezNoktasi.Y, Convert.ToSingle(sax), Convert.ToSingle(say));
            e.Graphics.DrawLine(YelkovanPen, MerkezNoktasi.X, MerkezNoktasi.Y, Convert.ToSingle(dx), Convert.ToSingle(dy));
            e.Graphics.DrawLine(SaniyePen, MerkezNoktasi.X, MerkezNoktasi.Y, Convert.ToSingle(snx), Convert.ToSingle(sny));
        }

        private void Saat_SizeChanged(object sender, EventArgs e)
        {
            if (this.Width != this.Height)
            {
                this.Height = this.Width;
            }
            AkrepUzunlugu = this.Width / 2 / 50 * 20;
            YelkovanUzunlugu = this.Width / 2 / 50 * 30;
            SaniyeUzunlugu = this.Width / 2 / 50 * 46;
        }

        private void Saat_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
            
        }

        private void StandartToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            if (item.Text == "Standart")
            {
                this.BackgroundImage = Properties.Resources.Standart;

                AkrepPen.Color = Color.Black;
                YelkovanPen.Color = Color.Black;
                SaniyePen.Color = Color.Red;
            }
            else if (item.Text == "Standart Kuş")
            {
                this.BackgroundImage = Properties.Resources.Standart_Kus;

                AkrepPen.Color = Color.Black;
                YelkovanPen.Color = Color.Black;
                SaniyePen.Color = Color.Red;
            }
            else if (item.Text == "Romen")
            {
                this.BackgroundImage = Properties.Resources.Romen;

                AkrepPen.Color = Color.Black;
                YelkovanPen.Color = Color.Black;
                SaniyePen.Color = Color.Red;
            }
            else if (item.Text == "Romen Kuş")
            {
                this.BackgroundImage = Properties.Resources.Romen_Bird;

                AkrepPen.Color = Color.Black;
                YelkovanPen.Color = Color.Black;
                SaniyePen.Color = Color.Red;
            }
            else if (item.Text == "Sayılar")
            {
                this.BackgroundImage = Properties.Resources.Sayılar;

                AkrepPen.Color = Color.Black;
                YelkovanPen.Color = Color.Black;
                SaniyePen.Color = Color.Red;
            }
            else if (item.Text == "Tahta")
            {
                this.BackgroundImage = Properties.Resources.Tahta;

                AkrepPen.Color = Color.DarkGray;
                YelkovanPen.Color = Color.DarkGray;
                SaniyePen.Color = Color.Orange;
            }
            else if (item.Text == "Ağaç")
            {
                this.BackgroundImage = Properties.Resources.Agac;

                AkrepPen.Color = Color.DarkGray;
                YelkovanPen.Color = Color.DarkGray;
                SaniyePen.Color = Color.Orange;
            }
            else if (item.Text == "Budak")
            {
                this.BackgroundImage = Properties.Resources.Budak;

                AkrepPen.Color = Color.Black;
                YelkovanPen.Color = Color.Black;
                SaniyePen.Color = Color.Red;
            }
            else if (item.Text == "Çark")
            {
                this.BackgroundImage = Properties.Resources.Cark;

                AkrepPen.Color = Color.DarkGray;
                YelkovanPen.Color = Color.DarkGray;
                SaniyePen.Color = Color.Red;
            }
            else if (item.Text == "Kafes")
            {
                this.BackgroundImage = Properties.Resources.Kafes;

                AkrepPen.Color = Color.Black;
                YelkovanPen.Color = Color.Black;
                SaniyePen.Color = Color.Red;
            }
            else if (item.Text == "London")
            {
                this.BackgroundImage = Properties.Resources.London;

                AkrepPen.Color = Color.DarkGray;
                YelkovanPen.Color = Color.DarkGray;
                SaniyePen.Color = Color.Black;
            }
        }
        private void KucukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            if (item.Text == "Küçük")
            {
                Boyutu = Boyutlar.Kucuk;
            }
            else if (item.Text == "Orta")
            {
                Boyutu = Boyutlar.Orta;
            }
            else if (item.Text == "Büyük")
            {
                Boyutu = Boyutlar.Buyuk;
            }
        }
    }
}
