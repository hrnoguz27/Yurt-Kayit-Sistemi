namespace YurtKayitSistemi
{
    partial class FrmOgrDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrDuzenle));
            this.LblOgrId = new System.Windows.Forms.Label();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.RTxtAdres = new System.Windows.Forms.RichTextBox();
            this.MskVeliTelefon = new System.Windows.Forms.MaskedTextBox();
            this.CmbOdaNo = new System.Windows.Forms.ComboBox();
            this.CmbBolumler = new System.Windows.Forms.ComboBox();
            this.MskDogumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.LblDogumTarihi = new System.Windows.Forms.Label();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.LblTelefon = new System.Windows.Forms.Label();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.LblAdres = new System.Windows.Forms.Label();
            this.LblVeliTelefon = new System.Windows.Forms.Label();
            this.TxtVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.LblVeliAdSoyad = new System.Windows.Forms.Label();
            this.LblOdaNo = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.LblMail = new System.Windows.Forms.Label();
            this.LblBolum = new System.Windows.Forms.Label();
            this.LblTcNo = new System.Windows.Forms.Label();
            this.TxtOgrSoyad = new System.Windows.Forms.TextBox();
            this.LblOgrSoyad = new System.Windows.Forms.Label();
            this.TxtOgrAd = new System.Windows.Forms.TextBox();
            this.LblOgrAd = new System.Windows.Forms.Label();
            this.TxtOgrId = new System.Windows.Forms.TextBox();
            this.BtnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblOgrId
            // 
            this.LblOgrId.AutoSize = true;
            this.LblOgrId.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOgrId.Location = new System.Drawing.Point(9, 9);
            this.LblOgrId.Name = "LblOgrId";
            this.LblOgrId.Size = new System.Drawing.Size(109, 23);
            this.LblOgrId.TabIndex = 0;
            this.LblOgrId.Text = "Öğrenci ID:";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.White;
            this.BtnGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.ForeColor = System.Drawing.Color.Red;
            this.BtnGuncelle.Location = new System.Drawing.Point(46, 652);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(176, 48);
            this.BtnGuncelle.TabIndex = 24;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // RTxtAdres
            // 
            this.RTxtAdres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RTxtAdres.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RTxtAdres.Location = new System.Drawing.Point(164, 505);
            this.RTxtAdres.Name = "RTxtAdres";
            this.RTxtAdres.Size = new System.Drawing.Size(328, 131);
            this.RTxtAdres.TabIndex = 23;
            this.RTxtAdres.Text = "";
            // 
            // MskVeliTelefon
            // 
            this.MskVeliTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MskVeliTelefon.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskVeliTelefon.Location = new System.Drawing.Point(164, 454);
            this.MskVeliTelefon.Mask = "(999) 000-0000";
            this.MskVeliTelefon.Name = "MskVeliTelefon";
            this.MskVeliTelefon.Size = new System.Drawing.Size(328, 30);
            this.MskVeliTelefon.TabIndex = 21;
            // 
            // CmbOdaNo
            // 
            this.CmbOdaNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CmbOdaNo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbOdaNo.FormattingEnabled = true;
            this.CmbOdaNo.Location = new System.Drawing.Point(164, 364);
            this.CmbOdaNo.Name = "CmbOdaNo";
            this.CmbOdaNo.Size = new System.Drawing.Size(328, 32);
            this.CmbOdaNo.TabIndex = 17;
            // 
            // CmbBolumler
            // 
            this.CmbBolumler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CmbBolumler.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbBolumler.FormattingEnabled = true;
            this.CmbBolumler.Location = new System.Drawing.Point(164, 273);
            this.CmbBolumler.Name = "CmbBolumler";
            this.CmbBolumler.Size = new System.Drawing.Size(328, 32);
            this.CmbBolumler.TabIndex = 13;
            // 
            // MskDogumTarihi
            // 
            this.MskDogumTarihi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MskDogumTarihi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskDogumTarihi.Location = new System.Drawing.Point(164, 228);
            this.MskDogumTarihi.Mask = "00/00/0000";
            this.MskDogumTarihi.Name = "MskDogumTarihi";
            this.MskDogumTarihi.Size = new System.Drawing.Size(328, 30);
            this.MskDogumTarihi.TabIndex = 11;
            this.MskDogumTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // LblDogumTarihi
            // 
            this.LblDogumTarihi.AutoSize = true;
            this.LblDogumTarihi.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDogumTarihi.Location = new System.Drawing.Point(9, 233);
            this.LblDogumTarihi.Name = "LblDogumTarihi";
            this.LblDogumTarihi.Size = new System.Drawing.Size(136, 23);
            this.LblDogumTarihi.TabIndex = 48;
            this.LblDogumTarihi.Text = "Doğum Tarihi:";
            // 
            // MskTelefon
            // 
            this.MskTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MskTelefon.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTelefon.Location = new System.Drawing.Point(164, 183);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(328, 30);
            this.MskTelefon.TabIndex = 9;
            // 
            // LblTelefon
            // 
            this.LblTelefon.AutoSize = true;
            this.LblTelefon.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTelefon.Location = new System.Drawing.Point(9, 188);
            this.LblTelefon.Name = "LblTelefon";
            this.LblTelefon.Size = new System.Drawing.Size(78, 23);
            this.LblTelefon.TabIndex = 46;
            this.LblTelefon.Text = "Telefon:";
            // 
            // MskTC
            // 
            this.MskTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MskTC.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTC.Location = new System.Drawing.Point(164, 138);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(328, 30);
            this.MskTC.TabIndex = 7;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // LblAdres
            // 
            this.LblAdres.AutoSize = true;
            this.LblAdres.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAdres.Location = new System.Drawing.Point(9, 504);
            this.LblAdres.Name = "LblAdres";
            this.LblAdres.Size = new System.Drawing.Size(65, 23);
            this.LblAdres.TabIndex = 44;
            this.LblAdres.Text = "Adres:";
            // 
            // LblVeliTelefon
            // 
            this.LblVeliTelefon.AutoSize = true;
            this.LblVeliTelefon.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblVeliTelefon.Location = new System.Drawing.Point(9, 459);
            this.LblVeliTelefon.Name = "LblVeliTelefon";
            this.LblVeliTelefon.Size = new System.Drawing.Size(116, 23);
            this.LblVeliTelefon.TabIndex = 43;
            this.LblVeliTelefon.Text = "Veli Telefon:";
            // 
            // TxtVeliAdSoyad
            // 
            this.TxtVeliAdSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtVeliAdSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtVeliAdSoyad.Location = new System.Drawing.Point(164, 409);
            this.TxtVeliAdSoyad.Name = "TxtVeliAdSoyad";
            this.TxtVeliAdSoyad.Size = new System.Drawing.Size(328, 30);
            this.TxtVeliAdSoyad.TabIndex = 19;
            // 
            // LblVeliAdSoyad
            // 
            this.LblVeliAdSoyad.AutoSize = true;
            this.LblVeliAdSoyad.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblVeliAdSoyad.Location = new System.Drawing.Point(9, 414);
            this.LblVeliAdSoyad.Name = "LblVeliAdSoyad";
            this.LblVeliAdSoyad.Size = new System.Drawing.Size(134, 23);
            this.LblVeliAdSoyad.TabIndex = 41;
            this.LblVeliAdSoyad.Text = "Veli Ad Soyad:";
            // 
            // LblOdaNo
            // 
            this.LblOdaNo.AutoSize = true;
            this.LblOdaNo.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOdaNo.Location = new System.Drawing.Point(9, 369);
            this.LblOdaNo.Name = "LblOdaNo";
            this.LblOdaNo.Size = new System.Drawing.Size(81, 23);
            this.LblOdaNo.TabIndex = 40;
            this.LblOdaNo.Text = "Oda No:";
            // 
            // TxtMail
            // 
            this.TxtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtMail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMail.Location = new System.Drawing.Point(164, 319);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(328, 30);
            this.TxtMail.TabIndex = 15;
            // 
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMail.Location = new System.Drawing.Point(9, 324);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(55, 23);
            this.LblMail.TabIndex = 38;
            this.LblMail.Text = "Mail:";
            // 
            // LblBolum
            // 
            this.LblBolum.AutoSize = true;
            this.LblBolum.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBolum.Location = new System.Drawing.Point(9, 278);
            this.LblBolum.Name = "LblBolum";
            this.LblBolum.Size = new System.Drawing.Size(143, 23);
            this.LblBolum.TabIndex = 37;
            this.LblBolum.Text = "Öğrenci Bölüm:";
            // 
            // LblTcNo
            // 
            this.LblTcNo.AutoSize = true;
            this.LblTcNo.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTcNo.Location = new System.Drawing.Point(9, 143);
            this.LblTcNo.Name = "LblTcNo";
            this.LblTcNo.Size = new System.Drawing.Size(40, 23);
            this.LblTcNo.TabIndex = 36;
            this.LblTcNo.Text = "TC:";
            // 
            // TxtOgrSoyad
            // 
            this.TxtOgrSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtOgrSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrSoyad.Location = new System.Drawing.Point(164, 93);
            this.TxtOgrSoyad.Name = "TxtOgrSoyad";
            this.TxtOgrSoyad.Size = new System.Drawing.Size(328, 30);
            this.TxtOgrSoyad.TabIndex = 5;
            // 
            // LblOgrSoyad
            // 
            this.LblOgrSoyad.AutoSize = true;
            this.LblOgrSoyad.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOgrSoyad.Location = new System.Drawing.Point(9, 98);
            this.LblOgrSoyad.Name = "LblOgrSoyad";
            this.LblOgrSoyad.Size = new System.Drawing.Size(139, 23);
            this.LblOgrSoyad.TabIndex = 34;
            this.LblOgrSoyad.Text = "Öğrenci Soyad:";
            // 
            // TxtOgrAd
            // 
            this.TxtOgrAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtOgrAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrAd.Location = new System.Drawing.Point(164, 47);
            this.TxtOgrAd.Name = "TxtOgrAd";
            this.TxtOgrAd.Size = new System.Drawing.Size(328, 30);
            this.TxtOgrAd.TabIndex = 3;
            // 
            // LblOgrAd
            // 
            this.LblOgrAd.AutoSize = true;
            this.LblOgrAd.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOgrAd.Location = new System.Drawing.Point(9, 52);
            this.LblOgrAd.Name = "LblOgrAd";
            this.LblOgrAd.Size = new System.Drawing.Size(112, 23);
            this.LblOgrAd.TabIndex = 32;
            this.LblOgrAd.Text = "Öğrenci Ad:";
            // 
            // TxtOgrId
            // 
            this.TxtOgrId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtOgrId.Enabled = false;
            this.TxtOgrId.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrId.Location = new System.Drawing.Point(164, 4);
            this.TxtOgrId.Name = "TxtOgrId";
            this.TxtOgrId.Size = new System.Drawing.Size(328, 30);
            this.TxtOgrId.TabIndex = 2;
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.White;
            this.BtnSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.ForeColor = System.Drawing.Color.Red;
            this.BtnSil.Location = new System.Drawing.Point(270, 652);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(176, 48);
            this.BtnSil.TabIndex = 25;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // FrmOgrDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(504, 712);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.TxtOgrId);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.RTxtAdres);
            this.Controls.Add(this.MskVeliTelefon);
            this.Controls.Add(this.CmbOdaNo);
            this.Controls.Add(this.CmbBolumler);
            this.Controls.Add(this.MskDogumTarihi);
            this.Controls.Add(this.LblDogumTarihi);
            this.Controls.Add(this.MskTelefon);
            this.Controls.Add(this.LblTelefon);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.LblAdres);
            this.Controls.Add(this.LblVeliTelefon);
            this.Controls.Add(this.TxtVeliAdSoyad);
            this.Controls.Add(this.LblVeliAdSoyad);
            this.Controls.Add(this.LblOdaNo);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.LblMail);
            this.Controls.Add(this.LblBolum);
            this.Controls.Add(this.LblTcNo);
            this.Controls.Add(this.TxtOgrSoyad);
            this.Controls.Add(this.LblOgrSoyad);
            this.Controls.Add(this.TxtOgrAd);
            this.Controls.Add(this.LblOgrAd);
            this.Controls.Add(this.LblOgrId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgrDuzenle";
            this.Text = "Öğrenci Düzenle";
            this.Load += new System.EventHandler(this.FrmOgrDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblOgrId;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.RichTextBox RTxtAdres;
        private System.Windows.Forms.MaskedTextBox MskVeliTelefon;
        private System.Windows.Forms.ComboBox CmbOdaNo;
        private System.Windows.Forms.ComboBox CmbBolumler;
        private System.Windows.Forms.MaskedTextBox MskDogumTarihi;
        private System.Windows.Forms.Label LblDogumTarihi;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.Label LblTelefon;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label LblAdres;
        private System.Windows.Forms.Label LblVeliTelefon;
        private System.Windows.Forms.TextBox TxtVeliAdSoyad;
        private System.Windows.Forms.Label LblVeliAdSoyad;
        private System.Windows.Forms.Label LblOdaNo;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label LblMail;
        private System.Windows.Forms.Label LblBolum;
        private System.Windows.Forms.Label LblTcNo;
        private System.Windows.Forms.TextBox TxtOgrSoyad;
        private System.Windows.Forms.Label LblOgrSoyad;
        private System.Windows.Forms.TextBox TxtOgrAd;
        private System.Windows.Forms.Label LblOgrAd;
        private System.Windows.Forms.TextBox TxtOgrId;
        private System.Windows.Forms.Button BtnSil;
    }
}