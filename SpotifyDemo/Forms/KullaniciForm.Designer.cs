
namespace SpotifyDemo.Forms
{
    partial class KullaniciForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblKullaniciAd = new System.Windows.Forms.Label();
            this.pctbxPop = new System.Windows.Forms.PictureBox();
            this.pctxCaz = new System.Windows.Forms.PictureBox();
            this.pctbxKlasik = new System.Windows.Forms.PictureBox();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnCaz = new System.Windows.Forms.Button();
            this.btnKlasik = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnListeEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxPop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctxCaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxKlasik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 537);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.pictureBox2.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(920, 85);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblKullaniciAd
            // 
            this.lblKullaniciAd.AutoSize = true;
            this.lblKullaniciAd.BackColor = System.Drawing.Color.Teal;
            this.lblKullaniciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAd.ForeColor = System.Drawing.Color.White;
            this.lblKullaniciAd.Location = new System.Drawing.Point(45, 25);
            this.lblKullaniciAd.Name = "lblKullaniciAd";
            this.lblKullaniciAd.Size = new System.Drawing.Size(99, 33);
            this.lblKullaniciAd.TabIndex = 2;
            this.lblKullaniciAd.Text = "label1";
            // 
            // pctbxPop
            // 
            this.pctbxPop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctbxPop.Image = ((System.Drawing.Image)(resources.GetObject("pctbxPop.Image")));
            this.pctbxPop.Location = new System.Drawing.Point(33, 112);
            this.pctbxPop.Name = "pctbxPop";
            this.pctbxPop.Size = new System.Drawing.Size(111, 107);
            this.pctbxPop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbxPop.TabIndex = 3;
            this.pctbxPop.TabStop = false;
            this.pctbxPop.Click += new System.EventHandler(this.pctbxPop_Click);
            // 
            // pctxCaz
            // 
            this.pctxCaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctxCaz.Image = ((System.Drawing.Image)(resources.GetObject("pctxCaz.Image")));
            this.pctxCaz.Location = new System.Drawing.Point(33, 250);
            this.pctxCaz.Name = "pctxCaz";
            this.pctxCaz.Size = new System.Drawing.Size(111, 107);
            this.pctxCaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctxCaz.TabIndex = 4;
            this.pctxCaz.TabStop = false;
            this.pctxCaz.Click += new System.EventHandler(this.pctxCaz_Click);
            // 
            // pctbxKlasik
            // 
            this.pctbxKlasik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.pctbxKlasik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctbxKlasik.Image = ((System.Drawing.Image)(resources.GetObject("pctbxKlasik.Image")));
            this.pctbxKlasik.Location = new System.Drawing.Point(33, 387);
            this.pctbxKlasik.Name = "pctbxKlasik";
            this.pctbxKlasik.Size = new System.Drawing.Size(111, 107);
            this.pctbxKlasik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbxKlasik.TabIndex = 5;
            this.pctbxKlasik.TabStop = false;
            this.pctbxKlasik.Click += new System.EventHandler(this.pctbxKlasik_Click);
            // 
            // btnPop
            // 
            this.btnPop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btnPop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btnPop.FlatAppearance.BorderSize = 0;
            this.btnPop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPop.ForeColor = System.Drawing.Color.White;
            this.btnPop.Location = new System.Drawing.Point(227, 90);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(140, 42);
            this.btnPop.TabIndex = 6;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = false;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnCaz
            // 
            this.btnCaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btnCaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaz.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btnCaz.FlatAppearance.BorderSize = 0;
            this.btnCaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCaz.ForeColor = System.Drawing.Color.White;
            this.btnCaz.Location = new System.Drawing.Point(409, 90);
            this.btnCaz.Name = "btnCaz";
            this.btnCaz.Size = new System.Drawing.Size(140, 42);
            this.btnCaz.TabIndex = 7;
            this.btnCaz.Text = "Caz";
            this.btnCaz.UseVisualStyleBackColor = false;
            this.btnCaz.Click += new System.EventHandler(this.btnCaz_Click);
            // 
            // btnKlasik
            // 
            this.btnKlasik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btnKlasik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKlasik.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btnKlasik.FlatAppearance.BorderSize = 0;
            this.btnKlasik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKlasik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKlasik.ForeColor = System.Drawing.Color.White;
            this.btnKlasik.Location = new System.Drawing.Point(593, 90);
            this.btnKlasik.Name = "btnKlasik";
            this.btnKlasik.Size = new System.Drawing.Size(140, 42);
            this.btnKlasik.TabIndex = 8;
            this.btnKlasik.Text = "Klasik";
            this.btnKlasik.UseVisualStyleBackColor = false;
            this.btnKlasik.Click += new System.EventHandler(this.btnKlasik_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(227, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(506, 369);
            this.dataGridView1.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(199, 84);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // btnListeEkle
            // 
            this.btnListeEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btnListeEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListeEkle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btnListeEkle.FlatAppearance.BorderSize = 0;
            this.btnListeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListeEkle.ForeColor = System.Drawing.Color.White;
            this.btnListeEkle.Location = new System.Drawing.Point(739, 151);
            this.btnListeEkle.Name = "btnListeEkle";
            this.btnListeEkle.Size = new System.Drawing.Size(167, 42);
            this.btnListeEkle.TabIndex = 11;
            this.btnListeEkle.Text = "Listeye Ekle";
            this.btnListeEkle.UseVisualStyleBackColor = false;
            this.btnListeEkle.Click += new System.EventHandler(this.btnListeEkle_Click);
            // 
            // KullaniciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(918, 532);
            this.Controls.Add(this.btnListeEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKlasik);
            this.Controls.Add(this.btnCaz);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.pctbxKlasik);
            this.Controls.Add(this.pctxCaz);
            this.Controls.Add(this.pctbxPop);
            this.Controls.Add(this.lblKullaniciAd);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "KullaniciForm";
            this.Text = "KullaniciForm";
            this.Load += new System.EventHandler(this.KullaniciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxPop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctxCaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxKlasik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblKullaniciAd;
        private System.Windows.Forms.PictureBox pctbxPop;
        private System.Windows.Forms.PictureBox pctxCaz;
        private System.Windows.Forms.PictureBox pctbxKlasik;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnCaz;
        private System.Windows.Forms.Button btnKlasik;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnListeEkle;
    }
}