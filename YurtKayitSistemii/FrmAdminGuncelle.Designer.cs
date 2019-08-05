namespace YurtKayitSistemi
{
    partial class FrmAdminGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminGuncelle));
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtYoneticiId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yoneticiIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet5 = new YurtKayitSistemi.YurtOtomasyonuDataSet5();
            this.adminTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSet5TableAdapters.AdminTableAdapter();
            this.BtnSifreShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSifre
            // 
            this.TxtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtSifre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Location = new System.Drawing.Point(182, 131);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(253, 34);
            this.TxtSifre.TabIndex = 3;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(88, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre:";
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(182, 81);
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(253, 34);
            this.TxtKullaniciAdi.TabIndex = 2;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.White;
            this.BtnKaydet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.ForeColor = System.Drawing.Color.Red;
            this.BtnKaydet.Location = new System.Drawing.Point(49, 200);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(120, 52);
            this.BtnKaydet.TabIndex = 4;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // TxtYoneticiId
            // 
            this.TxtYoneticiId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtYoneticiId.Enabled = false;
            this.TxtYoneticiId.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYoneticiId.Location = new System.Drawing.Point(182, 25);
            this.TxtYoneticiId.Name = "TxtYoneticiId";
            this.TxtYoneticiId.Size = new System.Drawing.Size(253, 34);
            this.TxtYoneticiId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Yönetici ID:";
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.White;
            this.BtnSil.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.ForeColor = System.Drawing.Color.Red;
            this.BtnSil.Location = new System.Drawing.Point(175, 200);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(125, 52);
            this.BtnSil.TabIndex = 5;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.White;
            this.BtnGuncelle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.ForeColor = System.Drawing.Color.Red;
            this.BtnGuncelle.Location = new System.Drawing.Point(306, 200);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(129, 52);
            this.BtnGuncelle.TabIndex = 6;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yoneticiIdDataGridViewTextBoxColumn,
            this.yoneticiAdDataGridViewTextBoxColumn,
            this.yoneticiSifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.adminBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(492, 284);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yoneticiIdDataGridViewTextBoxColumn
            // 
            this.yoneticiIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yoneticiIdDataGridViewTextBoxColumn.DataPropertyName = "YoneticiId";
            this.yoneticiIdDataGridViewTextBoxColumn.HeaderText = "YoneticiId";
            this.yoneticiIdDataGridViewTextBoxColumn.Name = "yoneticiIdDataGridViewTextBoxColumn";
            this.yoneticiIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yoneticiAdDataGridViewTextBoxColumn
            // 
            this.yoneticiAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yoneticiAdDataGridViewTextBoxColumn.DataPropertyName = "YoneticiAd";
            this.yoneticiAdDataGridViewTextBoxColumn.HeaderText = "YoneticiAd";
            this.yoneticiAdDataGridViewTextBoxColumn.Name = "yoneticiAdDataGridViewTextBoxColumn";
            // 
            // yoneticiSifreDataGridViewTextBoxColumn
            // 
            this.yoneticiSifreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yoneticiSifreDataGridViewTextBoxColumn.DataPropertyName = "YoneticiSifre";
            this.yoneticiSifreDataGridViewTextBoxColumn.HeaderText = "YoneticiSifre";
            this.yoneticiSifreDataGridViewTextBoxColumn.Name = "yoneticiSifreDataGridViewTextBoxColumn";
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            this.adminBindingSource.DataSource = this.yurtOtomasyonuDataSet5;
            // 
            // yurtOtomasyonuDataSet5
            // 
            this.yurtOtomasyonuDataSet5.DataSetName = "YurtOtomasyonuDataSet5";
            this.yurtOtomasyonuDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // BtnSifreShow
            // 
            this.BtnSifreShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnSifreShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSifreShow.BackgroundImage")));
            this.BtnSifreShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSifreShow.Location = new System.Drawing.Point(441, 134);
            this.BtnSifreShow.Name = "BtnSifreShow";
            this.BtnSifreShow.Size = new System.Drawing.Size(30, 28);
            this.BtnSifreShow.TabIndex = 17;
            this.BtnSifreShow.UseVisualStyleBackColor = false;
            this.BtnSifreShow.Click += new System.EventHandler(this.BtnSifreShow_Click);
            // 
            // FrmAdminGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(493, 559);
            this.Controls.Add(this.BtnSifreShow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.TxtYoneticiId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtKullaniciAdi);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminGuncelle";
            this.Text = "Yönetici İşlemleri";
            this.Load += new System.EventHandler(this.FrmAdminGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtKullaniciAdi;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtYoneticiId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet5 yurtOtomasyonuDataSet5;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private YurtOtomasyonuDataSet5TableAdapters.AdminTableAdapter adminTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiSifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnSifreShow;
    }
}