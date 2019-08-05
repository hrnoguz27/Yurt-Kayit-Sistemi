namespace YurtKayitSistemi
{
    partial class FrmBolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.PcbBolumEkle = new System.Windows.Forms.PictureBox();
            this.PcbBolumSil = new System.Windows.Forms.PictureBox();
            this.PcbBolumDuzenle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBolumId = new System.Windows.Forms.TextBox();
            this.TxtBolumAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet = new YurtKayitSistemi.YurtOtomasyonuDataSet();
            this.bolumlerTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSetTableAdapters.BolumlerTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumDuzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PcbBolumEkle
            // 
            this.PcbBolumEkle.Image = ((System.Drawing.Image)(resources.GetObject("PcbBolumEkle.Image")));
            this.PcbBolumEkle.Location = new System.Drawing.Point(443, 12);
            this.PcbBolumEkle.Name = "PcbBolumEkle";
            this.PcbBolumEkle.Size = new System.Drawing.Size(75, 59);
            this.PcbBolumEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbBolumEkle.TabIndex = 0;
            this.PcbBolumEkle.TabStop = false;
            this.toolTip1.SetToolTip(this.PcbBolumEkle, "Ekleme");
            this.PcbBolumEkle.Click += new System.EventHandler(this.PcbBolumEkle_Click);
            // 
            // PcbBolumSil
            // 
            this.PcbBolumSil.Image = ((System.Drawing.Image)(resources.GetObject("PcbBolumSil.Image")));
            this.PcbBolumSil.Location = new System.Drawing.Point(536, 12);
            this.PcbBolumSil.Name = "PcbBolumSil";
            this.PcbBolumSil.Size = new System.Drawing.Size(75, 59);
            this.PcbBolumSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbBolumSil.TabIndex = 1;
            this.PcbBolumSil.TabStop = false;
            this.toolTip1.SetToolTip(this.PcbBolumSil, "Silme");
            this.PcbBolumSil.Click += new System.EventHandler(this.PcbBolumSil_Click);
            // 
            // PcbBolumDuzenle
            // 
            this.PcbBolumDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("PcbBolumDuzenle.Image")));
            this.PcbBolumDuzenle.Location = new System.Drawing.Point(487, 84);
            this.PcbBolumDuzenle.Name = "PcbBolumDuzenle";
            this.PcbBolumDuzenle.Size = new System.Drawing.Size(75, 59);
            this.PcbBolumDuzenle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbBolumDuzenle.TabIndex = 2;
            this.PcbBolumDuzenle.TabStop = false;
            this.toolTip1.SetToolTip(this.PcbBolumDuzenle, "Güncelleme");
            this.PcbBolumDuzenle.Click += new System.EventHandler(this.PcbBolumDuzenle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bölüm ID:";
            // 
            // TxtBolumId
            // 
            this.TxtBolumId.Enabled = false;
            this.TxtBolumId.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBolumId.Location = new System.Drawing.Point(120, 15);
            this.TxtBolumId.Name = "TxtBolumId";
            this.TxtBolumId.Size = new System.Drawing.Size(284, 30);
            this.TxtBolumId.TabIndex = 1;
            // 
            // TxtBolumAd
            // 
            this.TxtBolumAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBolumAd.Location = new System.Drawing.Point(120, 79);
            this.TxtBolumAd.Name = "TxtBolumAd";
            this.TxtBolumAd.Size = new System.Drawing.Size(284, 30);
            this.TxtBolumAd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bölüm Ad:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumIdDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(632, 255);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bolumIdDataGridViewTextBoxColumn
            // 
            this.bolumIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumIdDataGridViewTextBoxColumn.DataPropertyName = "BolumId";
            this.bolumIdDataGridViewTextBoxColumn.HeaderText = "BolumId";
            this.bolumIdDataGridViewTextBoxColumn.Name = "bolumIdDataGridViewTextBoxColumn";
            this.bolumIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "Bolumler";
            this.bolumlerBindingSource.DataSource = this.yurtOtomasyonuDataSet;
            // 
            // yurtOtomasyonuDataSet
            // 
            this.yurtOtomasyonuDataSet.DataSetName = "YurtOtomasyonuDataSet";
            this.yurtOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(631, 427);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtBolumAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBolumId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PcbBolumDuzenle);
            this.Controls.Add(this.PcbBolumSil);
            this.Controls.Add(this.PcbBolumEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBolumler";
            this.Text = "Bölümler";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumDuzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PcbBolumEkle;
        private System.Windows.Forms.PictureBox PcbBolumSil;
        private System.Windows.Forms.PictureBox PcbBolumDuzenle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBolumId;
        private System.Windows.Forms.TextBox TxtBolumAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet yurtOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private YurtOtomasyonuDataSetTableAdapters.BolumlerTableAdapter bolumlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}