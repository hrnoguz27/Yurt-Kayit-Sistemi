namespace YurtKayitSistemi
{
    partial class FrmOdemeler
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtOdenen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtKalan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnOdeme = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrKalanBorcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet2 = new YurtKayitSistemi.YurtOtomasyonuDataSet2();
            this.borclarTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSet2TableAdapters.BorclarTableAdapter();
            this.TxtOgrSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtOgrAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbOdenenAy = new System.Windows.Forms.ComboBox();
            this.CmbOdenenYil = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci ID:";
            // 
            // TxtId
            // 
            this.TxtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtId.Enabled = false;
            this.TxtId.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtId.Location = new System.Drawing.Point(152, 20);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(305, 30);
            this.TxtId.TabIndex = 1;
            // 
            // TxtOdenen
            // 
            this.TxtOdenen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtOdenen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOdenen.Location = new System.Drawing.Point(152, 159);
            this.TxtOdenen.Name = "TxtOdenen";
            this.TxtOdenen.Size = new System.Drawing.Size(305, 30);
            this.TxtOdenen.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(65, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ödenen:";
            // 
            // TxtKalan
            // 
            this.TxtKalan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtKalan.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKalan.Location = new System.Drawing.Point(152, 208);
            this.TxtKalan.Name = "TxtKalan";
            this.TxtKalan.Size = new System.Drawing.Size(305, 30);
            this.TxtKalan.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kalan Borç:";
            // 
            // BtnOdeme
            // 
            this.BtnOdeme.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOdeme.Location = new System.Drawing.Point(134, 307);
            this.BtnOdeme.Name = "BtnOdeme";
            this.BtnOdeme.Size = new System.Drawing.Size(168, 40);
            this.BtnOdeme.TabIndex = 6;
            this.BtnOdeme.Text = "Ödeme Al:";
            this.BtnOdeme.UseVisualStyleBackColor = true;
            this.BtnOdeme.Click += new System.EventHandler(this.BtnOdeme_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrIdDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrKalanBorcDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.borclarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(479, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(532, 316);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ogrIdDataGridViewTextBoxColumn
            // 
            this.ogrIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrIdDataGridViewTextBoxColumn.DataPropertyName = "OgrId";
            this.ogrIdDataGridViewTextBoxColumn.HeaderText = "OgrId";
            this.ogrIdDataGridViewTextBoxColumn.Name = "ogrIdDataGridViewTextBoxColumn";
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            // 
            // ogrKalanBorcDataGridViewTextBoxColumn
            // 
            this.ogrKalanBorcDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrKalanBorcDataGridViewTextBoxColumn.DataPropertyName = "OgrKalanBorc";
            this.ogrKalanBorcDataGridViewTextBoxColumn.HeaderText = "OgrKalanBorc";
            this.ogrKalanBorcDataGridViewTextBoxColumn.Name = "ogrKalanBorcDataGridViewTextBoxColumn";
            // 
            // borclarBindingSource
            // 
            this.borclarBindingSource.DataMember = "Borclar";
            this.borclarBindingSource.DataSource = this.yurtOtomasyonuDataSet2;
            // 
            // yurtOtomasyonuDataSet2
            // 
            this.yurtOtomasyonuDataSet2.DataSetName = "YurtOtomasyonuDataSet2";
            this.yurtOtomasyonuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borclarTableAdapter
            // 
            this.borclarTableAdapter.ClearBeforeFill = true;
            // 
            // TxtOgrSoyad
            // 
            this.TxtOgrSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtOgrSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrSoyad.Location = new System.Drawing.Point(152, 114);
            this.TxtOgrSoyad.Name = "TxtOgrSoyad";
            this.TxtOgrSoyad.Size = new System.Drawing.Size(305, 30);
            this.TxtOgrSoyad.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(7, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Öğrenci Soyad:";
            // 
            // TxtOgrAd
            // 
            this.TxtOgrAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtOgrAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrAd.Location = new System.Drawing.Point(152, 68);
            this.TxtOgrAd.Name = "TxtOgrAd";
            this.TxtOgrAd.Size = new System.Drawing.Size(305, 30);
            this.TxtOgrAd.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(34, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Öğrenci Ad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(8, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ödenen Ay:";
            // 
            // CmbOdenenAy
            // 
            this.CmbOdenenAy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CmbOdenenAy.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbOdenenAy.FormattingEnabled = true;
            this.CmbOdenenAy.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.CmbOdenenAy.Location = new System.Drawing.Point(122, 256);
            this.CmbOdenenAy.Name = "CmbOdenenAy";
            this.CmbOdenenAy.Size = new System.Drawing.Size(121, 32);
            this.CmbOdenenAy.TabIndex = 15;
            // 
            // CmbOdenenYil
            // 
            this.CmbOdenenYil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CmbOdenenYil.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbOdenenYil.FormattingEnabled = true;
            this.CmbOdenenYil.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.CmbOdenenYil.Location = new System.Drawing.Point(361, 256);
            this.CmbOdenenYil.Name = "CmbOdenenYil";
            this.CmbOdenenYil.Size = new System.Drawing.Size(96, 32);
            this.CmbOdenenYil.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(247, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ödenen Yıl:";
            // 
            // FrmOdemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1011, 372);
            this.Controls.Add(this.CmbOdenenYil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CmbOdenenAy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtOgrSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtOgrAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnOdeme);
            this.Controls.Add(this.TxtKalan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtOdenen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmOdemeler";
            this.Text = "Ödemeler";
            this.Load += new System.EventHandler(this.FrmOdemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtOdenen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtKalan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnOdeme;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet2 yurtOtomasyonuDataSet2;
        private System.Windows.Forms.BindingSource borclarBindingSource;
        private YurtOtomasyonuDataSet2TableAdapters.BorclarTableAdapter borclarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrKalanBorcDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TxtOgrSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtOgrAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbOdenenAy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbOdenenYil;
    }
}