namespace YurtKayitSistemi
{
    partial class FrmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDepartmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet6 = new YurtKayitSistemi.YurtOtomasyonuDataSet6();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.TxtPersonelId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPersonelGorev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPersonelAdi = new System.Windows.Forms.TextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.personelTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSet6TableAdapters.PersonelTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelIdDataGridViewTextBoxColumn,
            this.personelAdSoyadDataGridViewTextBoxColumn,
            this.personelDepartmanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(551, 234);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // personelIdDataGridViewTextBoxColumn
            // 
            this.personelIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.personelIdDataGridViewTextBoxColumn.DataPropertyName = "PersonelId";
            this.personelIdDataGridViewTextBoxColumn.HeaderText = "Personel ID";
            this.personelIdDataGridViewTextBoxColumn.Name = "personelIdDataGridViewTextBoxColumn";
            this.personelIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelAdSoyadDataGridViewTextBoxColumn
            // 
            this.personelAdSoyadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.personelAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "PersonelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.HeaderText = "Personel Ad Soyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.Name = "personelAdSoyadDataGridViewTextBoxColumn";
            // 
            // personelDepartmanDataGridViewTextBoxColumn
            // 
            this.personelDepartmanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.personelDepartmanDataGridViewTextBoxColumn.DataPropertyName = "PersonelDepartman";
            this.personelDepartmanDataGridViewTextBoxColumn.HeaderText = "Personel Departman";
            this.personelDepartmanDataGridViewTextBoxColumn.Name = "personelDepartmanDataGridViewTextBoxColumn";
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.yurtOtomasyonuDataSet6;
            // 
            // yurtOtomasyonuDataSet6
            // 
            this.yurtOtomasyonuDataSet6.DataSetName = "YurtOtomasyonuDataSet6";
            this.yurtOtomasyonuDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.White;
            this.BtnGuncelle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.ForeColor = System.Drawing.Color.Red;
            this.BtnGuncelle.Location = new System.Drawing.Point(330, 186);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(129, 52);
            this.BtnGuncelle.TabIndex = 9;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.White;
            this.BtnSil.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.ForeColor = System.Drawing.Color.Red;
            this.BtnSil.Location = new System.Drawing.Point(199, 186);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(125, 52);
            this.BtnSil.TabIndex = 8;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // TxtPersonelId
            // 
            this.TxtPersonelId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtPersonelId.Enabled = false;
            this.TxtPersonelId.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonelId.Location = new System.Drawing.Point(242, 15);
            this.TxtPersonelId.Name = "TxtPersonelId";
            this.TxtPersonelId.Size = new System.Drawing.Size(286, 34);
            this.TxtPersonelId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(106, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Personel ID:";
            // 
            // TxtPersonelGorev
            // 
            this.TxtPersonelGorev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtPersonelGorev.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonelGorev.Location = new System.Drawing.Point(242, 121);
            this.TxtPersonelGorev.Name = "TxtPersonelGorev";
            this.TxtPersonelGorev.Size = new System.Drawing.Size(286, 34);
            this.TxtPersonelGorev.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(72, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "Personel Görev:*";
            // 
            // TxtPersonelAdi
            // 
            this.TxtPersonelAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtPersonelAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonelAdi.Location = new System.Drawing.Point(242, 71);
            this.TxtPersonelAdi.Name = "TxtPersonelAdi";
            this.TxtPersonelAdi.Size = new System.Drawing.Size(286, 34);
            this.TxtPersonelAdi.TabIndex = 4;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.White;
            this.BtnKaydet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.ForeColor = System.Drawing.Color.Red;
            this.BtnKaydet.Location = new System.Drawing.Point(73, 186);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(120, 52);
            this.BtnKaydet.TabIndex = 7;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Personel Ad Soyad:*";
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "* Doldurulması Zorunlu Alanlar";
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(551, 496);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.TxtPersonelId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPersonelGorev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPersonelAdi);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPersonel";
            this.Text = "Personel İşlemleri";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.TextBox TxtPersonelId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPersonelGorev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPersonelAdi;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label1;
        private YurtOtomasyonuDataSet6 yurtOtomasyonuDataSet6;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private YurtOtomasyonuDataSet6TableAdapters.PersonelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDepartmanDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
    }
}