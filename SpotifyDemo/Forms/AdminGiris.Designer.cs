
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.lblAdminSifre = new System.Windows.Forms.Label();
            this.lblAdminAd = new System.Windows.Forms.Label();
            this.tbxAdminSifre = new System.Windows.Forms.TextBox();
            this.tbxAdminAd = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnAdmin);
            this.groupBox2.Controls.Add(this.lblAdminSifre);
            this.groupBox2.Controls.Add(this.lblAdminAd);
            this.groupBox2.Controls.Add(this.tbxAdminSifre);
            this.groupBox2.Controls.Add(this.tbxAdminAd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(182, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 390);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Admin Giriş";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(190, 268);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(218, 37);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Giriş Yap";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // lblAdminSifre
            // 
            this.lblAdminSifre.AutoSize = true;
            this.lblAdminSifre.Location = new System.Drawing.Point(10, 183);
            this.lblAdminSifre.Name = "lblAdminSifre";
            this.lblAdminSifre.Size = new System.Drawing.Size(75, 31);
            this.lblAdminSifre.TabIndex = 3;
            this.lblAdminSifre.Text = "Şifre";
            // 
            // lblAdminAd
            // 
            this.lblAdminAd.AutoSize = true;
            this.lblAdminAd.Location = new System.Drawing.Point(10, 84);
            this.lblAdminAd.Name = "lblAdminAd";
            this.lblAdminAd.Size = new System.Drawing.Size(174, 31);
            this.lblAdminAd.TabIndex = 2;
            this.lblAdminAd.Text = "Kullanıcı Adı";
            // 
            // tbxAdminSifre
            // 
            this.tbxAdminSifre.Location = new System.Drawing.Point(190, 176);
            this.tbxAdminSifre.Name = "tbxAdminSifre";
            this.tbxAdminSifre.Size = new System.Drawing.Size(218, 38);
            this.tbxAdminSifre.TabIndex = 1;
            // 
            // tbxAdminAd
            // 
            this.tbxAdminAd.Location = new System.Drawing.Point(190, 81);
            this.tbxAdminAd.Name = "tbxAdminAd";
            this.tbxAdminAd.Size = new System.Drawing.Size(218, 38);
            this.tbxAdminAd.TabIndex = 0;
            // 
            // AdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Name = "AdminGiris";
            this.Text = "AdminGiris";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label lblAdminSifre;
        private System.Windows.Forms.Label lblAdminAd;
        private System.Windows.Forms.TextBox tbxAdminSifre;
        private System.Windows.Forms.TextBox tbxAdminAd;
    }
}