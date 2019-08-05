namespace YurtKayitSistemi
{
    partial class FrmAnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öğrencilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümDüzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istatistiklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirİstatistikleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erişimKolaylığıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radyolarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radyo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radyo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radyo3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrOdaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet1 = new YurtKayitSistemi.YurtOtomasyonuDataSet1();
            this.ogrenciTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSet1TableAdapters.OgrenciTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrencilerToolStripMenuItem,
            this.bölümlerToolStripMenuItem,
            this.ödemelerToolStripMenuItem,
            this.giderlerToolStripMenuItem,
            this.istatistiklerToolStripMenuItem,
            this.yöneticiToolStripMenuItem,
            this.erişimKolaylığıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(909, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrencilerToolStripMenuItem
            // 
            this.öğrencilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciEkleToolStripMenuItem,
            this.öğrenciListesiToolStripMenuItem,
            this.öğrenciSilToolStripMenuItem});
            this.öğrencilerToolStripMenuItem.Name = "öğrencilerToolStripMenuItem";
            this.öğrencilerToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.öğrencilerToolStripMenuItem.Text = "Öğrenciler";
            // 
            // öğrenciEkleToolStripMenuItem
            // 
            this.öğrenciEkleToolStripMenuItem.Name = "öğrenciEkleToolStripMenuItem";
            this.öğrenciEkleToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.öğrenciEkleToolStripMenuItem.Text = "Öğrenci Ekle";
            this.öğrenciEkleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciEkleToolStripMenuItem_Click);
            // 
            // öğrenciListesiToolStripMenuItem
            // 
            this.öğrenciListesiToolStripMenuItem.Name = "öğrenciListesiToolStripMenuItem";
            this.öğrenciListesiToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.öğrenciListesiToolStripMenuItem.Text = "Öğrenci Listesi";
            this.öğrenciListesiToolStripMenuItem.Click += new System.EventHandler(this.öğrenciListesiToolStripMenuItem_Click);
            // 
            // öğrenciSilToolStripMenuItem
            // 
            this.öğrenciSilToolStripMenuItem.Name = "öğrenciSilToolStripMenuItem";
            this.öğrenciSilToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.öğrenciSilToolStripMenuItem.Text = "Öğrenci Sil";
            this.öğrenciSilToolStripMenuItem.Click += new System.EventHandler(this.öğrenciSilToolStripMenuItem_Click);
            // 
            // bölümlerToolStripMenuItem
            // 
            this.bölümlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bölümEkleToolStripMenuItem,
            this.bölümDüzenlemeToolStripMenuItem});
            this.bölümlerToolStripMenuItem.Name = "bölümlerToolStripMenuItem";
            this.bölümlerToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.bölümlerToolStripMenuItem.Text = "Bölümler";
            // 
            // bölümEkleToolStripMenuItem
            // 
            this.bölümEkleToolStripMenuItem.Name = "bölümEkleToolStripMenuItem";
            this.bölümEkleToolStripMenuItem.Size = new System.Drawing.Size(244, 30);
            this.bölümEkleToolStripMenuItem.Text = "Bölüm Ekle";
            this.bölümEkleToolStripMenuItem.Click += new System.EventHandler(this.bölümEkleToolStripMenuItem_Click);
            // 
            // bölümDüzenlemeToolStripMenuItem
            // 
            this.bölümDüzenlemeToolStripMenuItem.Name = "bölümDüzenlemeToolStripMenuItem";
            this.bölümDüzenlemeToolStripMenuItem.Size = new System.Drawing.Size(244, 30);
            this.bölümDüzenlemeToolStripMenuItem.Text = "Bölüm Düzenleme";
            this.bölümDüzenlemeToolStripMenuItem.Click += new System.EventHandler(this.bölümDüzenlemeToolStripMenuItem_Click);
            // 
            // ödemelerToolStripMenuItem
            // 
            this.ödemelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ödemeAlToolStripMenuItem});
            this.ödemelerToolStripMenuItem.Name = "ödemelerToolStripMenuItem";
            this.ödemelerToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.ödemelerToolStripMenuItem.Text = "Ödemeler";
            // 
            // ödemeAlToolStripMenuItem
            // 
            this.ödemeAlToolStripMenuItem.Name = "ödemeAlToolStripMenuItem";
            this.ödemeAlToolStripMenuItem.Size = new System.Drawing.Size(173, 30);
            this.ödemeAlToolStripMenuItem.Text = "Ödeme Al";
            this.ödemeAlToolStripMenuItem.Click += new System.EventHandler(this.ödemeAlToolStripMenuItem_Click);
            // 
            // giderlerToolStripMenuItem
            // 
            this.giderlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giderEkleToolStripMenuItem,
            this.giderListesiToolStripMenuItem});
            this.giderlerToolStripMenuItem.Name = "giderlerToolStripMenuItem";
            this.giderlerToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.giderlerToolStripMenuItem.Text = "Giderler";
            // 
            // giderEkleToolStripMenuItem
            // 
            this.giderEkleToolStripMenuItem.Name = "giderEkleToolStripMenuItem";
            this.giderEkleToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.giderEkleToolStripMenuItem.Text = "Gider Ekle";
            this.giderEkleToolStripMenuItem.Click += new System.EventHandler(this.giderEkleToolStripMenuItem_Click);
            // 
            // giderListesiToolStripMenuItem
            // 
            this.giderListesiToolStripMenuItem.Name = "giderListesiToolStripMenuItem";
            this.giderListesiToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.giderListesiToolStripMenuItem.Text = "Gider Listesi";
            this.giderListesiToolStripMenuItem.Click += new System.EventHandler(this.giderListesiToolStripMenuItem_Click);
            // 
            // istatistiklerToolStripMenuItem
            // 
            this.istatistiklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gelirİstatistikleriToolStripMenuItem});
            this.istatistiklerToolStripMenuItem.Name = "istatistiklerToolStripMenuItem";
            this.istatistiklerToolStripMenuItem.Size = new System.Drawing.Size(114, 29);
            this.istatistiklerToolStripMenuItem.Text = "İstatistikler";
            // 
            // gelirİstatistikleriToolStripMenuItem
            // 
            this.gelirİstatistikleriToolStripMenuItem.Name = "gelirİstatistikleriToolStripMenuItem";
            this.gelirİstatistikleriToolStripMenuItem.Size = new System.Drawing.Size(230, 30);
            this.gelirİstatistikleriToolStripMenuItem.Text = "Gelir İstatistikleri";
            this.gelirİstatistikleriToolStripMenuItem.Click += new System.EventHandler(this.gelirİstatistikleriToolStripMenuItem_Click);
            // 
            // yöneticiToolStripMenuItem
            // 
            this.yöneticiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şifreİşlemleriToolStripMenuItem,
            this.personelDüzenleToolStripMenuItem,
            this.notEkleToolStripMenuItem});
            this.yöneticiToolStripMenuItem.Name = "yöneticiToolStripMenuItem";
            this.yöneticiToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.yöneticiToolStripMenuItem.Text = "Yönetici";
            // 
            // şifreİşlemleriToolStripMenuItem
            // 
            this.şifreİşlemleriToolStripMenuItem.Name = "şifreİşlemleriToolStripMenuItem";
            this.şifreİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.şifreİşlemleriToolStripMenuItem.Text = "Şifre İşlemleri";
            this.şifreİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.şifreİşlemleriToolStripMenuItem_Click);
            // 
            // personelDüzenleToolStripMenuItem
            // 
            this.personelDüzenleToolStripMenuItem.Name = "personelDüzenleToolStripMenuItem";
            this.personelDüzenleToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.personelDüzenleToolStripMenuItem.Text = "Personel Düzenle";
            this.personelDüzenleToolStripMenuItem.Click += new System.EventHandler(this.personelDüzenleToolStripMenuItem_Click);
            // 
            // notEkleToolStripMenuItem
            // 
            this.notEkleToolStripMenuItem.Name = "notEkleToolStripMenuItem";
            this.notEkleToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.notEkleToolStripMenuItem.Text = "Not Ekle";
            this.notEkleToolStripMenuItem.Click += new System.EventHandler(this.notEkleToolStripMenuItem_Click);
            // 
            // erişimKolaylığıToolStripMenuItem
            // 
            this.erişimKolaylığıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapMakinesiToolStripMenuItem,
            this.paintToolStripMenuItem,
            this.radyolarToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.erişimKolaylığıToolStripMenuItem.Name = "erişimKolaylığıToolStripMenuItem";
            this.erişimKolaylığıToolStripMenuItem.Size = new System.Drawing.Size(152, 29);
            this.erişimKolaylığıToolStripMenuItem.Text = "Erişim Kolaylığı";
            // 
            // hesapMakinesiToolStripMenuItem
            // 
            this.hesapMakinesiToolStripMenuItem.Name = "hesapMakinesiToolStripMenuItem";
            this.hesapMakinesiToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.hesapMakinesiToolStripMenuItem.Text = "Hesap Makinesi";
            this.hesapMakinesiToolStripMenuItem.Click += new System.EventHandler(this.hesapMakinesiToolStripMenuItem_Click);
            // 
            // paintToolStripMenuItem
            // 
            this.paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            this.paintToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.paintToolStripMenuItem.Text = "Paint";
            this.paintToolStripMenuItem.Click += new System.EventHandler(this.paintToolStripMenuItem_Click);
            // 
            // radyolarToolStripMenuItem
            // 
            this.radyolarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radyo1ToolStripMenuItem,
            this.radyo2ToolStripMenuItem,
            this.radyo3ToolStripMenuItem});
            this.radyolarToolStripMenuItem.Name = "radyolarToolStripMenuItem";
            this.radyolarToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.radyolarToolStripMenuItem.Text = "Radyolar";
            // 
            // radyo1ToolStripMenuItem
            // 
            this.radyo1ToolStripMenuItem.Name = "radyo1ToolStripMenuItem";
            this.radyo1ToolStripMenuItem.Size = new System.Drawing.Size(157, 30);
            this.radyo1ToolStripMenuItem.Text = "Radyo 1";
            this.radyo1ToolStripMenuItem.Click += new System.EventHandler(this.radyo1ToolStripMenuItem_Click);
            // 
            // radyo2ToolStripMenuItem
            // 
            this.radyo2ToolStripMenuItem.Name = "radyo2ToolStripMenuItem";
            this.radyo2ToolStripMenuItem.Size = new System.Drawing.Size(157, 30);
            this.radyo2ToolStripMenuItem.Text = "Radyo 2";
            this.radyo2ToolStripMenuItem.Click += new System.EventHandler(this.radyo2ToolStripMenuItem_Click);
            // 
            // radyo3ToolStripMenuItem
            // 
            this.radyo3ToolStripMenuItem.Name = "radyo3ToolStripMenuItem";
            this.radyo3ToolStripMenuItem.Size = new System.Drawing.Size(157, 30);
            this.radyo3ToolStripMenuItem.Text = "Radyo 3";
            this.radyo3ToolStripMenuItem.Click += new System.EventHandler(this.radyo3ToolStripMenuItem_Click);
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrIdDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrOdaNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(672, 311);
            this.dataGridView1.TabIndex = 1;
            // 
            // ogrIdDataGridViewTextBoxColumn
            // 
            this.ogrIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrIdDataGridViewTextBoxColumn.DataPropertyName = "OgrId";
            this.ogrIdDataGridViewTextBoxColumn.HeaderText = "Öğrenci ID";
            this.ogrIdDataGridViewTextBoxColumn.Name = "ogrIdDataGridViewTextBoxColumn";
            this.ogrIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "Öğrenci Ad";
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "Öğrenci Soyad";
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            // 
            // ogrOdaNoDataGridViewTextBoxColumn
            // 
            this.ogrOdaNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrOdaNoDataGridViewTextBoxColumn.DataPropertyName = "OgrOdaNo";
            this.ogrOdaNoDataGridViewTextBoxColumn.HeaderText = "Öğrenci Oda No";
            this.ogrOdaNoDataGridViewTextBoxColumn.Name = "ogrOdaNoDataGridViewTextBoxColumn";
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "Ogrenci";
            this.ogrenciBindingSource.DataSource = this.yurtOtomasyonuDataSet1;
            // 
            // yurtOtomasyonuDataSet1
            // 
            this.yurtOtomasyonuDataSet1.DataSetName = "YurtOtomasyonuDataSet1";
            this.yurtOtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(74, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(273, 44);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(227, 47);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmAnaForm";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FrmAnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrencilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümDüzenlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istatistiklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirİstatistikleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erişimKolaylığıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radyolarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radyo1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radyo2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radyo3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet1 yurtOtomasyonuDataSet1;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private YurtOtomasyonuDataSet1TableAdapters.OgrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrOdaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notEkleToolStripMenuItem;
    }
}