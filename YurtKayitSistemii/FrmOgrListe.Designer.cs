namespace YurtKayitSistemi
{
    partial class FrmOgrListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrListe));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrDogumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrBolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrOdaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrVeliTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrVeliAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet3 = new YurtKayitSistemi.YurtOtomasyonuDataSet3();
            this.ogrenciTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSet3TableAdapters.OgrenciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrIdDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrTCDataGridViewTextBoxColumn,
            this.ogrTelefonDataGridViewTextBoxColumn,
            this.ogrDogumDataGridViewTextBoxColumn,
            this.ogrBolumDataGridViewTextBoxColumn,
            this.ogrMailDataGridViewTextBoxColumn,
            this.ogrOdaNoDataGridViewTextBoxColumn,
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn,
            this.ogrVeliTelefonDataGridViewTextBoxColumn,
            this.ogrVeliAdresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1327, 530);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // ogrTCDataGridViewTextBoxColumn
            // 
            this.ogrTCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrTCDataGridViewTextBoxColumn.DataPropertyName = "OgrTC";
            this.ogrTCDataGridViewTextBoxColumn.HeaderText = "Öğrenci TC";
            this.ogrTCDataGridViewTextBoxColumn.Name = "ogrTCDataGridViewTextBoxColumn";
            // 
            // ogrTelefonDataGridViewTextBoxColumn
            // 
            this.ogrTelefonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrTelefonDataGridViewTextBoxColumn.DataPropertyName = "OgrTelefon";
            this.ogrTelefonDataGridViewTextBoxColumn.HeaderText = "Öğrenci Telefon";
            this.ogrTelefonDataGridViewTextBoxColumn.Name = "ogrTelefonDataGridViewTextBoxColumn";
            // 
            // ogrDogumDataGridViewTextBoxColumn
            // 
            this.ogrDogumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrDogumDataGridViewTextBoxColumn.DataPropertyName = "OgrDogum";
            this.ogrDogumDataGridViewTextBoxColumn.HeaderText = "Öğrenci Doğum Tarihi";
            this.ogrDogumDataGridViewTextBoxColumn.Name = "ogrDogumDataGridViewTextBoxColumn";
            // 
            // ogrBolumDataGridViewTextBoxColumn
            // 
            this.ogrBolumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrBolumDataGridViewTextBoxColumn.DataPropertyName = "OgrBolum";
            this.ogrBolumDataGridViewTextBoxColumn.HeaderText = "Öğrenci Bölüm";
            this.ogrBolumDataGridViewTextBoxColumn.Name = "ogrBolumDataGridViewTextBoxColumn";
            // 
            // ogrMailDataGridViewTextBoxColumn
            // 
            this.ogrMailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrMailDataGridViewTextBoxColumn.DataPropertyName = "OgrMail";
            this.ogrMailDataGridViewTextBoxColumn.HeaderText = "Öğrenci Mail";
            this.ogrMailDataGridViewTextBoxColumn.Name = "ogrMailDataGridViewTextBoxColumn";
            // 
            // ogrOdaNoDataGridViewTextBoxColumn
            // 
            this.ogrOdaNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrOdaNoDataGridViewTextBoxColumn.DataPropertyName = "OgrOdaNo";
            this.ogrOdaNoDataGridViewTextBoxColumn.HeaderText = "Öğrenci Oda No";
            this.ogrOdaNoDataGridViewTextBoxColumn.Name = "ogrOdaNoDataGridViewTextBoxColumn";
            // 
            // ogrVeliAdSoyadDataGridViewTextBoxColumn
            // 
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrVeliAdSoyad";
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn.HeaderText = "Veli Ad Soyad";
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn.Name = "ogrVeliAdSoyadDataGridViewTextBoxColumn";
            // 
            // ogrVeliTelefonDataGridViewTextBoxColumn
            // 
            this.ogrVeliTelefonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrVeliTelefonDataGridViewTextBoxColumn.DataPropertyName = "OgrVeliTelefon";
            this.ogrVeliTelefonDataGridViewTextBoxColumn.HeaderText = "Veli Telefon";
            this.ogrVeliTelefonDataGridViewTextBoxColumn.Name = "ogrVeliTelefonDataGridViewTextBoxColumn";
            // 
            // ogrVeliAdresDataGridViewTextBoxColumn
            // 
            this.ogrVeliAdresDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrVeliAdresDataGridViewTextBoxColumn.DataPropertyName = "OgrVeliAdres";
            this.ogrVeliAdresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.ogrVeliAdresDataGridViewTextBoxColumn.Name = "ogrVeliAdresDataGridViewTextBoxColumn";
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "Ogrenci";
            this.ogrenciBindingSource.DataSource = this.yurtOtomasyonuDataSet3;
            // 
            // yurtOtomasyonuDataSet3
            // 
            this.yurtOtomasyonuDataSet3.DataSetName = "YurtOtomasyonuDataSet3";
            this.yurtOtomasyonuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // FrmOgrListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1327, 530);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmOgrListe";
            this.Text = "Öğrenci Listesi";
            this.Load += new System.EventHandler(this.FrmOgrListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet3 yurtOtomasyonuDataSet3;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private YurtOtomasyonuDataSet3TableAdapters.OgrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrDogumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrBolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrOdaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrVeliAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrVeliTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrVeliAdresDataGridViewTextBoxColumn;
    }
}