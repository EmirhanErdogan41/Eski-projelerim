
namespace Ders
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rdb0 = new System.Windows.Forms.RadioButton();
            this.rdb5 = new System.Windows.Forms.RadioButton();
            this.rdb10 = new System.Windows.Forms.RadioButton();
            this.rdb20 = new System.Windows.Forms.RadioButton();
            this.lblSonFiyat = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etiket fiyatı";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(366, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 30);
            this.textBox1.TabIndex = 1;
            // 
            // rdb0
            // 
            this.rdb0.AutoSize = true;
            this.rdb0.Checked = true;
            this.rdb0.Location = new System.Drawing.Point(591, 106);
            this.rdb0.Name = "rdb0";
            this.rdb0.Size = new System.Drawing.Size(126, 29);
            this.rdb0.TabIndex = 2;
            this.rdb0.TabStop = true;
            this.rdb0.Text = "İndirim yok";
            this.rdb0.UseVisualStyleBackColor = true;
            // 
            // rdb5
            // 
            this.rdb5.AutoSize = true;
            this.rdb5.Location = new System.Drawing.Point(591, 141);
            this.rdb5.Name = "rdb5";
            this.rdb5.Size = new System.Drawing.Size(62, 29);
            this.rdb5.TabIndex = 3;
            this.rdb5.Text = "%5";
            this.rdb5.UseVisualStyleBackColor = true;
            // 
            // rdb10
            // 
            this.rdb10.AutoSize = true;
            this.rdb10.Location = new System.Drawing.Point(591, 176);
            this.rdb10.Name = "rdb10";
            this.rdb10.Size = new System.Drawing.Size(73, 29);
            this.rdb10.TabIndex = 4;
            this.rdb10.Text = "%10";
            this.rdb10.UseVisualStyleBackColor = true;
            // 
            // rdb20
            // 
            this.rdb20.AutoSize = true;
            this.rdb20.Location = new System.Drawing.Point(591, 211);
            this.rdb20.Name = "rdb20";
            this.rdb20.Size = new System.Drawing.Size(73, 29);
            this.rdb20.TabIndex = 5;
            this.rdb20.Text = "%20";
            this.rdb20.UseVisualStyleBackColor = true;
            // 
            // lblSonFiyat
            // 
            this.lblSonFiyat.AutoSize = true;
            this.lblSonFiyat.Location = new System.Drawing.Point(232, 166);
            this.lblSonFiyat.Name = "lblSonFiyat";
            this.lblSonFiyat.Size = new System.Drawing.Size(98, 25);
            this.lblSonFiyat.TabIndex = 6;
            this.lblSonFiyat.Text = "Son fiyatı:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(283, 268);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(236, 67);
            this.btnHesapla.TabIndex = 7;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 459);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblSonFiyat);
            this.Controls.Add(this.rdb20);
            this.Controls.Add(this.rdb10);
            this.Controls.Add(this.rdb5);
            this.Controls.Add(this.rdb0);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rdb0;
        private System.Windows.Forms.RadioButton rdb5;
        private System.Windows.Forms.RadioButton rdb10;
        private System.Windows.Forms.RadioButton rdb20;
        private System.Windows.Forms.Label lblSonFiyat;
        private System.Windows.Forms.Button btnHesapla;
    }
}

