
namespace ControlLib
{
    partial class Saat
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.arkaPlanResmiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StandartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standartKuşToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romenKuşToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sayılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tahtaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ağaçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.budakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kafesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.londonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saatBoyutuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.küçükToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ortaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.büyükToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkaPlanResmiToolStripMenuItem,
            this.saatBoyutuToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 48);
            // 
            // arkaPlanResmiToolStripMenuItem
            // 
            this.arkaPlanResmiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StandartToolStripMenuItem,
            this.standartKuşToolStripMenuItem,
            this.romenToolStripMenuItem,
            this.romenKuşToolStripMenuItem,
            this.sayılarToolStripMenuItem,
            this.tahtaToolStripMenuItem,
            this.ağaçToolStripMenuItem,
            this.budakToolStripMenuItem,
            this.çarkToolStripMenuItem,
            this.kafesToolStripMenuItem,
            this.londonToolStripMenuItem});
            this.arkaPlanResmiToolStripMenuItem.Name = "arkaPlanResmiToolStripMenuItem";
            this.arkaPlanResmiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arkaPlanResmiToolStripMenuItem.Text = "Arka Plan Resmi";
            // 
            // StandartToolStripMenuItem
            // 
            this.StandartToolStripMenuItem.Image = global::ControlLib.Properties.Resources.Standart;
            this.StandartToolStripMenuItem.Name = "StandartToolStripMenuItem";
            this.StandartToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.StandartToolStripMenuItem.Text = "Standart";
            this.StandartToolStripMenuItem.Click += new System.EventHandler(this.StandartToolStripMenuItem_Click_1);
            // 
            // standartKuşToolStripMenuItem
            // 
            this.standartKuşToolStripMenuItem.Image = global::ControlLib.Properties.Resources.Standart_Kus;
            this.standartKuşToolStripMenuItem.Name = "standartKuşToolStripMenuItem";
            this.standartKuşToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.standartKuşToolStripMenuItem.Text = "Standart Kuş";
            this.standartKuşToolStripMenuItem.Click += new System.EventHandler(this.StandartToolStripMenuItem_Click_1);
            // 
            // romenToolStripMenuItem
            // 
            this.romenToolStripMenuItem.Image = global::ControlLib.Properties.Resources.Romen;
            this.romenToolStripMenuItem.Name = "romenToolStripMenuItem";
            this.romenToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.romenToolStripMenuItem.Text = "Romen";
            this.romenToolStripMenuItem.Click += new System.EventHandler(this.StandartToolStripMenuItem_Click_1);
            // 
            // romenKuşToolStripMenuItem
            // 
            this.romenKuşToolStripMenuItem.Image = global::ControlLib.Properties.Resources.Romen_Bird;
            this.romenKuşToolStripMenuItem.Name = "romenKuşToolStripMenuItem";
            this.romenKuşToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.romenKuşToolStripMenuItem.Text = "Romen Kuş";
            this.romenKuşToolStripMenuItem.Click += new System.EventHandler(this.StandartToolStripMenuItem_Click_1);
            // 
            // sayılarToolStripMenuItem
            // 
            this.sayılarToolStripMenuItem.Image = global::ControlLib.Properties.Resources.Sayılar;
            this.sayılarToolStripMenuItem.Name = "sayılarToolStripMenuItem";
            this.sayılarToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.sayılarToolStripMenuItem.Text = "Sayılar";
            this.sayılarToolStripMenuItem.Click += new System.EventHandler(this.StandartToolStripMenuItem_Click_1);
            // 
            // tahtaToolStripMenuItem
            // 
            this.tahtaToolStripMenuItem.Image = global::ControlLib.Properties.Resources.Tahta;
            this.tahtaToolStripMenuItem.Name = "tahtaToolStripMenuItem";
            this.tahtaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.tahtaToolStripMenuItem.Text = "Tahta";
            this.tahtaToolStripMenuItem.Click += new System.EventHandler(this.StandartToolStripMenuItem_Click_1);
            // 
            // ağaçToolStripMenuItem
            // 
            this.ağaçToolStripMenuItem.Image = global::ControlLib.Properties.Resources.Agac;
            this.ağaçToolStripMenuItem.Name = "ağaçToolStripMenuItem";
            this.ağaçToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.ağaçToolStripMenuItem.Text = "Ağaç";
            this.ağaçToolStripMenuItem.Click += new System.EventHandler(this.StandartToolStripMenuItem_Click_1);
            // 
            // budakToolStripMenuItem
            // 
            this.budakToolStripMenuItem.Image = global::ControlLib.Properties.Resources.Budak;
            this.budakToolStripMenuItem.Name = "budakToolStripMenuItem";
            this.budakToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.budakToolStripMenuItem.Text = "Budak";
            this.budakToolStripMenuItem.Click += new System.EventHandler(this.StandartToolStripMenuItem_Click_1);
            // 
            // çarkToolStripMenuItem
            // 
            this.çarkToolStripMenuItem.Image = global::ControlLib.Properties.Resources.Cark;
            this.çarkToolStripMenuItem.Name = "çarkToolStripMenuItem";
            this.çarkToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.çarkToolStripMenuItem.Text = "Çark";
            this.çarkToolStripMenuItem.Click += new System.EventHandler(this.StandartToolStripMenuItem_Click_1);
            // 
            // kafesToolStripMenuItem
            // 
            this.kafesToolStripMenuItem.Image = global::ControlLib.Properties.Resources.Kafes;
            this.kafesToolStripMenuItem.Name = "kafesToolStripMenuItem";
            this.kafesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.kafesToolStripMenuItem.Text = "Kafes";
            this.kafesToolStripMenuItem.Click += new System.EventHandler(this.StandartToolStripMenuItem_Click_1);
            // 
            // londonToolStripMenuItem
            // 
            this.londonToolStripMenuItem.Image = global::ControlLib.Properties.Resources.London;
            this.londonToolStripMenuItem.Name = "londonToolStripMenuItem";
            this.londonToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.londonToolStripMenuItem.Text = "London";
            this.londonToolStripMenuItem.Click += new System.EventHandler(this.StandartToolStripMenuItem_Click_1);
            // 
            // saatBoyutuToolStripMenuItem
            // 
            this.saatBoyutuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.küçükToolStripMenuItem,
            this.ortaToolStripMenuItem,
            this.büyükToolStripMenuItem});
            this.saatBoyutuToolStripMenuItem.Name = "saatBoyutuToolStripMenuItem";
            this.saatBoyutuToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.saatBoyutuToolStripMenuItem.Text = "Saat Boyutu";
            // 
            // küçükToolStripMenuItem
            // 
            this.küçükToolStripMenuItem.Name = "küçükToolStripMenuItem";
            this.küçükToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.küçükToolStripMenuItem.Text = "Küçük";
            this.küçükToolStripMenuItem.Click += new System.EventHandler(this.KucukToolStripMenuItem_Click);
            // 
            // ortaToolStripMenuItem
            // 
            this.ortaToolStripMenuItem.Name = "ortaToolStripMenuItem";
            this.ortaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ortaToolStripMenuItem.Text = "Orta";
            this.ortaToolStripMenuItem.Click += new System.EventHandler(this.KucukToolStripMenuItem_Click);
            // 
            // büyükToolStripMenuItem
            // 
            this.büyükToolStripMenuItem.Name = "büyükToolStripMenuItem";
            this.büyükToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.büyükToolStripMenuItem.Text = "Büyük";
            this.büyükToolStripMenuItem.Click += new System.EventHandler(this.KucukToolStripMenuItem_Click);
            // 
            // Saat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControlLib.Properties.Resources.Standart;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoubleBuffered = true;
            this.Name = "Saat";
            this.Size = new System.Drawing.Size(200, 200);
            this.SizeChanged += new System.EventHandler(this.Saat_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Saat_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Saat_MouseClick);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkaPlanResmiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saatBoyutuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StandartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standartKuşToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romenKuşToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sayılarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tahtaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ağaçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem budakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kafesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem londonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem küçükToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ortaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem büyükToolStripMenuItem;
    }
}
