
namespace SpotifyDemo
{
    partial class KullaniciGrisi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKullanici = new System.Windows.Forms.Button();
            this.lblKullaniciSifre = new System.Windows.Forms.Label();
            this.LblKullaniciAd = new System.Windows.Forms.Label();
            this.tbxKullaniciSifre = new System.Windows.Forms.TextBox();
            this.tbxKullaniciAd = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.btnKullanici);
            this.groupBox1.Controls.Add(this.lblKullaniciSifre);
            this.groupBox1.Controls.Add(this.LblKullaniciAd);
            this.groupBox1.Controls.Add(this.tbxKullaniciSifre);
            this.groupBox1.Controls.Add(this.tbxKullaniciAd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(187, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 390);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Giriş";
            // 
            // btnKullanici
            // 
            this.btnKullanici.Location = new System.Drawing.Point(186, 268);
            this.btnKullanici.Name = "btnKullanici";
            this.btnKullanici.Size = new System.Drawing.Size(209, 37);
            this.btnKullanici.TabIndex = 5;
            this.btnKullanici.Text = "Giriş Yap";
            this.btnKullanici.UseVisualStyleBackColor = true;
            this.btnKullanici.Click += new System.EventHandler(this.btnKullanici_Click);
            // 
            // lblKullaniciSifre
            // 
            this.lblKullaniciSifre.AutoSize = true;
            this.lblKullaniciSifre.Location = new System.Drawing.Point(6, 183);
            this.lblKullaniciSifre.Name = "lblKullaniciSifre";
            this.lblKullaniciSifre.Size = new System.Drawing.Size(75, 31);
            this.lblKullaniciSifre.TabIndex = 4;
            this.lblKullaniciSifre.Text = "Şifre";
            // 
            // LblKullaniciAd
            // 
            this.LblKullaniciAd.AutoSize = true;
            this.LblKullaniciAd.Location = new System.Drawing.Point(6, 87);
            this.LblKullaniciAd.Name = "LblKullaniciAd";
            this.LblKullaniciAd.Size = new System.Drawing.Size(174, 31);
            this.LblKullaniciAd.TabIndex = 3;
            this.LblKullaniciAd.Text = "Kullanıcı Adı";
            // 
            // tbxKullaniciSifre
            // 
            this.tbxKullaniciSifre.Location = new System.Drawing.Point(186, 176);
            this.tbxKullaniciSifre.Name = "tbxKullaniciSifre";
            this.tbxKullaniciSifre.Size = new System.Drawing.Size(209, 38);
            this.tbxKullaniciSifre.TabIndex = 2;
            // 
            // tbxKullaniciAd
            // 
            this.tbxKullaniciAd.Location = new System.Drawing.Point(186, 84);
            this.tbxKullaniciAd.Name = "tbxKullaniciAd";
            this.tbxKullaniciAd.Size = new System.Drawing.Size(209, 38);
            this.tbxKullaniciAd.TabIndex = 1;
            // 
            // KullaniciGrisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "KullaniciGrisi";
            this.Text = "KullaniciGrisi";
            this.Load += new System.EventHandler(this.KullaniciGrisi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKullanici;
        private System.Windows.Forms.Label lblKullaniciSifre;
        private System.Windows.Forms.Label LblKullaniciAd;
        private System.Windows.Forms.TextBox tbxKullaniciSifre;
        private System.Windows.Forms.TextBox tbxKullaniciAd;
    }
}