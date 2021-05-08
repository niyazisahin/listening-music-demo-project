
namespace SpotifyDemo
{
    partial class AdminForm
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
            this.tbxSarkiciAd = new System.Windows.Forms.TextBox();
            this.tbxSarkiciUlke = new System.Windows.Forms.TextBox();
            this.btnSarkiciEkle = new System.Windows.Forms.Button();
            this.btnSanatciGuncelle = new System.Windows.Forms.Button();
            this.tbxSanatciULKE = new System.Windows.Forms.TextBox();
            this.tbxSanatciAD = new System.Windows.Forms.TextBox();
            this.tbxSanatciID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxSarkiciAd
            // 
            this.tbxSarkiciAd.Location = new System.Drawing.Point(469, 95);
            this.tbxSarkiciAd.Name = "tbxSarkiciAd";
            this.tbxSarkiciAd.Size = new System.Drawing.Size(178, 20);
            this.tbxSarkiciAd.TabIndex = 0;
            // 
            // tbxSarkiciUlke
            // 
            this.tbxSarkiciUlke.Location = new System.Drawing.Point(469, 157);
            this.tbxSarkiciUlke.Name = "tbxSarkiciUlke";
            this.tbxSarkiciUlke.Size = new System.Drawing.Size(178, 20);
            this.tbxSarkiciUlke.TabIndex = 1;
            // 
            // btnSarkiciEkle
            // 
            this.btnSarkiciEkle.Location = new System.Drawing.Point(469, 256);
            this.btnSarkiciEkle.Name = "btnSarkiciEkle";
            this.btnSarkiciEkle.Size = new System.Drawing.Size(183, 59);
            this.btnSarkiciEkle.TabIndex = 2;
            this.btnSarkiciEkle.Text = "button1";
            this.btnSarkiciEkle.UseVisualStyleBackColor = true;
            this.btnSarkiciEkle.Click += new System.EventHandler(this.btnSarkiciEkle_Click);
            // 
            // btnSanatciGuncelle
            // 
            this.btnSanatciGuncelle.Location = new System.Drawing.Point(86, 256);
            this.btnSanatciGuncelle.Name = "btnSanatciGuncelle";
            this.btnSanatciGuncelle.Size = new System.Drawing.Size(183, 59);
            this.btnSanatciGuncelle.TabIndex = 5;
            this.btnSanatciGuncelle.Text = "button1";
            this.btnSanatciGuncelle.UseVisualStyleBackColor = true;
            this.btnSanatciGuncelle.Click += new System.EventHandler(this.btnSanatciGuncelle_Click);
            // 
            // tbxSanatciULKE
            // 
            this.tbxSanatciULKE.Location = new System.Drawing.Point(86, 176);
            this.tbxSanatciULKE.Name = "tbxSanatciULKE";
            this.tbxSanatciULKE.Size = new System.Drawing.Size(178, 20);
            this.tbxSanatciULKE.TabIndex = 4;
            // 
            // tbxSanatciAD
            // 
            this.tbxSanatciAD.Location = new System.Drawing.Point(86, 127);
            this.tbxSanatciAD.Name = "tbxSanatciAD";
            this.tbxSanatciAD.Size = new System.Drawing.Size(178, 20);
            this.tbxSanatciAD.TabIndex = 3;
            // 
            // tbxSanatciID
            // 
            this.tbxSanatciID.Location = new System.Drawing.Point(86, 69);
            this.tbxSanatciID.Name = "tbxSanatciID";
            this.tbxSanatciID.Size = new System.Drawing.Size(178, 20);
            this.tbxSanatciID.TabIndex = 6;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxSanatciID);
            this.Controls.Add(this.btnSanatciGuncelle);
            this.Controls.Add(this.tbxSanatciULKE);
            this.Controls.Add(this.tbxSanatciAD);
            this.Controls.Add(this.btnSarkiciEkle);
            this.Controls.Add(this.tbxSarkiciUlke);
            this.Controls.Add(this.tbxSarkiciAd);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSarkiciAd;
        private System.Windows.Forms.TextBox tbxSarkiciUlke;
        private System.Windows.Forms.Button btnSarkiciEkle;
        private System.Windows.Forms.Button btnSanatciGuncelle;
        private System.Windows.Forms.TextBox tbxSanatciULKE;
        private System.Windows.Forms.TextBox tbxSanatciAD;
        private System.Windows.Forms.TextBox tbxSanatciID;
    }
}