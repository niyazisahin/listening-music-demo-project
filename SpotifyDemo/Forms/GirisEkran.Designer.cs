
namespace SpotifyDemo
{
    partial class GirisEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkran));
            this.btnKullanici = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.pictureAdmin = new System.Windows.Forms.PictureBox();
            this.pictureKullanici = new System.Windows.Forms.PictureBox();
            this.btnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKullanici
            // 
            this.btnKullanici.BackColor = System.Drawing.Color.White;
            this.btnKullanici.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKullanici.FlatAppearance.BorderSize = 0;
            this.btnKullanici.Location = new System.Drawing.Point(449, 26);
            this.btnKullanici.Name = "btnKullanici";
            this.btnKullanici.Size = new System.Drawing.Size(212, 77);
            this.btnKullanici.TabIndex = 0;
            this.btnKullanici.Text = "Kullanıcı Giriş";
            this.btnKullanici.UseVisualStyleBackColor = false;
            this.btnKullanici.Click += new System.EventHandler(this.btnKullanici_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(170, 26);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(212, 77);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin Giriş";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // pictureAdmin
            // 
            this.pictureAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pictureAdmin.Image")));
            this.pictureAdmin.Location = new System.Drawing.Point(170, 132);
            this.pictureAdmin.Name = "pictureAdmin";
            this.pictureAdmin.Size = new System.Drawing.Size(212, 279);
            this.pictureAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAdmin.TabIndex = 2;
            this.pictureAdmin.TabStop = false;
            this.pictureAdmin.Click += new System.EventHandler(this.pictureAdmin_Click);
            // 
            // pictureKullanici
            // 
            this.pictureKullanici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureKullanici.Image = ((System.Drawing.Image)(resources.GetObject("pictureKullanici.Image")));
            this.pictureKullanici.Location = new System.Drawing.Point(449, 132);
            this.pictureKullanici.Name = "pictureKullanici";
            this.pictureKullanici.Size = new System.Drawing.Size(212, 279);
            this.pictureKullanici.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureKullanici.TabIndex = 3;
            this.pictureKullanici.TabStop = false;
            this.pictureKullanici.Click += new System.EventHandler(this.pictureKullanici_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Teal;
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btnCikis.Location = new System.Drawing.Point(336, 432);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(152, 35);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // GirisEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(844, 479);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.pictureKullanici);
            this.Controls.Add(this.pictureAdmin);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnKullanici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GirisEkran";
            this.Text = "GirisEkran";
            this.Load += new System.EventHandler(this.GirisEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKullanici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKullanici;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.PictureBox pictureAdmin;
        private System.Windows.Forms.PictureBox pictureKullanici;
        private System.Windows.Forms.Button btnCikis;
    }
}