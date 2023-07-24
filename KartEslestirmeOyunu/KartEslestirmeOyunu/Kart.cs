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
    public partial class Kart : UserControl
    {
        private KartUC _parent = null;
        public Kart()
        {
            InitializeComponent();
        }
        public Kart(KartUC kartUC)
        {
            InitializeComponent();

            _parent = kartUC;
            KartArkaYuzu = ArkaSayfaGuncelle(KartArkaYuzu, true);
            KartArkaYuzu.BackgroundImageLayout = ImageLayout.Stretch;
            this.Controls.Add(KartArkaYuzu);

        }
        private bool _secilimi;
        public bool Secilimi 
        { 
            get
            {
                return _secilimi;
            }
            set
            {
                _secilimi = value;
            }
        }
        public string _kartNo;
        public string KartNo 
        { 
            get
            {
                return _kartNo;
            }
            set
            {
                _kartNo = value;
                KartArkaYuzu = ArkaSayfaGuncelle(KartArkaYuzu, false);
                this.Controls.Clear();
                this.Controls.Add(KartArkaYuzu);
            }
        }
        public string KartName { get; set; }
        public Panel KartArkaYuzu;
        public Font KartNoFont;
        private Image _KartResmi;
        public Image KartResmi
        {
            get
            {
                return _KartResmi;
            }
            set
            {
                _KartResmi = value;
                BackgroundImage = _KartResmi;
            }
        }

        private void Kart_Click(object sender, EventArgs e)
        {
            if (!_parent.TimersOn())
            {
                _secilimi = true;
                Kart k = _parent.karar(this);
                this.Secilimi = k.Secilimi;
                this.KartArkaYuzu.Visible = k.KartArkaYuzu.Visible;
            }
        }
        private Panel ArkaSayfaGuncelle (Panel sayfa, bool olus)
        {
            if (olus)
            {
                sayfa = new Panel();
                sayfa.Dock = DockStyle.Top;
                sayfa.Visible = false;
                sayfa.BackColor = Color.White;
            }

            int aralikYuzde = this.Width / 18;

            if (KartNoFont == null)
            {
                KartNoFont = new Font(new FontFamily("Times New Roman"), 7.5f);
            }

            sayfa.Controls.Clear();

            return sayfa;
        }
    }
}
