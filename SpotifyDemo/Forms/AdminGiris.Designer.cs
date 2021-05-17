
namespace SpotifyDemo
{
    partial class AdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGiris));
            this.btnAdmin = new System.Windows.Forms.Button();
            this.lblAdminSifre = new System.Windows.Forms.Label();
            this.lblAdminAd = new System.Windows.Forms.Label();
            this.tbxAdminSifre = new System.Windows.Forms.TextBox();
            this.tbxAdminAd = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.btnGirisDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Teal;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(140)))));
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnAdmin.Location = new System.Drawing.Point(597, 314);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(218, 37);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Giriş Yap";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // lblAdminSifre
            // 
            this.lblAdminSifre.AutoSize = true;
            this.lblAdminSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminSifre.ForeColor = System.Drawing.Color.White;
            this.lblAdminSifre.Location = new System.Drawing.Point(442, 206);
            this.lblAdminSifre.Name = "lblAdminSifre";
            this.lblAdminSifre.Size = new System.Drawing.Size(52, 24);
            this.lblAdminSifre.TabIndex = 3;
            this.lblAdminSifre.Text = "Şifre";
            // 
            // lblAdminAd
            // 
            this.lblAdminAd.AutoSize = true;
            this.lblAdminAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminAd.ForeColor = System.Drawing.Color.White;
            this.lblAdminAd.Location = new System.Drawing.Point(442, 119);
            this.lblAdminAd.Name = "lblAdminAd";
            this.lblAdminAd.Size = new System.Drawing.Size(126, 24);
            this.lblAdminAd.TabIndex = 2;
            this.lblAdminAd.Text = "Kullanıcı Adı";
            // 
            // tbxAdminSifre
            // 
            this.tbxAdminSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAdminSifre.Location = new System.Drawing.Point(597, 206);
            this.tbxAdminSifre.Name = "tbxAdminSifre";
            this.tbxAdminSifre.Size = new System.Drawing.Size(218, 29);
            this.tbxAdminSifre.TabIndex = 1;
            // 
            // tbxAdminAd
            // 
            this.tbxAdminAd.BackColor = System.Drawing.SystemColors.Window;
            this.tbxAdminAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAdminAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAdminAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.tbxAdminAd.Location = new System.Drawing.Point(597, 124);
            this.tbxAdminAd.Name = "tbxAdminAd";
            this.tbxAdminAd.Size = new System.Drawing.Size(218, 29);
            this.tbxAdminAd.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 614);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-50, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1072, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(0, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(182, 41);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "  Admin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.BackColor = System.Drawing.Color.Teal;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(617, 13);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(57, 20);
            this.lblTarih.TabIndex = 9;
            this.lblTarih.Text = "label2";
            // 
            // btnGirisDon
            // 
            this.btnGirisDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btnGirisDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGirisDon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btnGirisDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisDon.ForeColor = System.Drawing.Color.White;
            this.btnGirisDon.Location = new System.Drawing.Point(0, 322);
            this.btnGirisDon.Name = "btnGirisDon";
            this.btnGirisDon.Size = new System.Drawing.Size(182, 41);
            this.btnGirisDon.TabIndex = 21;
            this.btnGirisDon.Text = "Giriş Ekran";
            this.btnGirisDon.UseVisualStyleBackColor = false;
            this.btnGirisDon.Click += new System.EventHandler(this.btnGirisDon_Click);
            // 
            // AdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(911, 538);
            this.Controls.Add(this.btnGirisDon);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxAdminAd);
            this.Controls.Add(this.tbxAdminSifre);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.lblAdminSifre);
            this.Controls.Add(this.lblAdminAd);
            this.Name = "AdminGiris";
            this.Text = "Admin Giriş";
            this.Load += new System.EventHandler(this.AdminGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label lblAdminSifre;
        private System.Windows.Forms.Label lblAdminAd;
        private System.Windows.Forms.TextBox tbxAdminSifre;
        private System.Windows.Forms.TextBox tbxAdminAd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Button btnGirisDon;
    }
}