
namespace WindowsFormsApp1
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.saat1 = new ControlLib.Saat();
            this.SuspendLayout();
            // 
            // saat1
            // 
            this.saat1.AkrepUzunlugu = 60;
            this.saat1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saat1.BackgroundImage")));
            this.saat1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saat1.Boyutlandirilsin = false;
            this.saat1.Boyutu = ControlLib.Saat.Boyutlar.None;
            this.saat1.Location = new System.Drawing.Point(349, 105);
            this.saat1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saat1.Name = "saat1";
            this.saat1.SaniyeUzunlugu = 138;
            this.saat1.Size = new System.Drawing.Size(300, 300);
            this.saat1.TabIndex = 0;
            this.saat1.YelkovanUzunlugu = 90;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.saat1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLib.Saat saat1;
    }
}

