namespace YurtKayitSistemi
{
    partial class FrmAdminGiris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.TxtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnSifreShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.BackColor = System.Drawing.Color.White;
            this.BtnGirisYap.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGirisYap.ForeColor = System.Drawing.Color.Red;
            this.BtnGirisYap.Location = new System.Drawing.Point(178, 209);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(164, 57);
            this.BtnGirisYap.TabIndex = 3;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = false;
            this.BtnGirisYap.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(237, 88);
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(253, 34);
            this.TxtKullaniciAdi.TabIndex = 1;
            // 
            // TxtSifre
            // 
            this.TxtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtSifre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Location = new System.Drawing.Point(237, 151);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(253, 34);
            this.TxtSifre.TabIndex = 2;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(143, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblTitle.Font = new System.Drawing.Font("MV Boli", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.Red;
            this.LblTitle.Location = new System.Drawing.Point(12, 19);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(540, 31);
            this.LblTitle.TabIndex = 5;
            this.LblTitle.Text = " Öğrenci Yurt Kayıt Otomasyon Sistemi  ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnSifreShow
            // 
            this.BtnSifreShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnSifreShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSifreShow.BackgroundImage")));
            this.BtnSifreShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSifreShow.Location = new System.Drawing.Point(496, 154);
            this.BtnSifreShow.Name = "BtnSifreShow";
            this.BtnSifreShow.Size = new System.Drawing.Size(30, 28);
            this.BtnSifreShow.TabIndex = 18;
            this.BtnSifreShow.UseVisualStyleBackColor = false;
            this.BtnSifreShow.Click += new System.EventHandler(this.BtnSifreShow_Click);
            // 
            // FrmAdminGiris
            // 
            this.AcceptButton = this.BtnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(552, 288);
            this.Controls.Add(this.BtnSifreShow);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtKullaniciAdi);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminGiris";
            this.Load += new System.EventHandler(this.FrmAdminGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGirisYap;
        private System.Windows.Forms.TextBox TxtKullaniciAdi;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnSifreShow;
    }
}