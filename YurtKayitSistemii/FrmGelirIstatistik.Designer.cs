namespace YurtKayitSistemi
{
    partial class FrmGelirIstatistik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGelirIstatistik));
            this.LblKasa = new System.Windows.Forms.Label();
            this.LblPara = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbTarih = new System.Windows.Forms.ComboBox();
            this.ChrtGelir = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LblStp = new System.Windows.Forms.Label();
            this.LblSt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChrtGelir)).BeginInit();
            this.SuspendLayout();
            // 
            // LblKasa
            // 
            this.LblKasa.AutoSize = true;
            this.LblKasa.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKasa.Location = new System.Drawing.Point(264, 30);
            this.LblKasa.Name = "LblKasa";
            this.LblKasa.Size = new System.Drawing.Size(139, 23);
            this.LblKasa.TabIndex = 0;
            this.LblKasa.Text = "Kasadaki Para:";
            // 
            // LblPara
            // 
            this.LblPara.AutoSize = true;
            this.LblPara.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPara.Location = new System.Drawing.Point(400, 30);
            this.LblPara.Name = "LblPara";
            this.LblPara.Size = new System.Drawing.Size(21, 22);
            this.LblPara.TabIndex = 1;
            this.LblPara.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tarih:";
            // 
            // CmbTarih
            // 
            this.CmbTarih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CmbTarih.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbTarih.FormattingEnabled = true;
            this.CmbTarih.Location = new System.Drawing.Point(80, 25);
            this.CmbTarih.Name = "CmbTarih";
            this.CmbTarih.Size = new System.Drawing.Size(163, 32);
            this.CmbTarih.TabIndex = 14;
            this.CmbTarih.SelectedIndexChanged += new System.EventHandler(this.CmbOdenenAy_SelectedIndexChanged);
            // 
            // ChrtGelir
            // 
            chartArea1.Name = "ChartArea1";
            this.ChrtGelir.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChrtGelir.Legends.Add(legend1);
            this.ChrtGelir.Location = new System.Drawing.Point(2, 114);
            this.ChrtGelir.Name = "ChrtGelir";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Aylik";
            this.ChrtGelir.Series.Add(series1);
            this.ChrtGelir.Size = new System.Drawing.Size(741, 353);
            this.ChrtGelir.TabIndex = 15;
            this.ChrtGelir.Text = "Chart1";
            // 
            // LblStp
            // 
            this.LblStp.AutoSize = true;
            this.LblStp.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblStp.Location = new System.Drawing.Point(641, 30);
            this.LblStp.Name = "LblStp";
            this.LblStp.Size = new System.Drawing.Size(21, 22);
            this.LblStp.TabIndex = 17;
            this.LblStp.Text = "0";
            // 
            // LblSt
            // 
            this.LblSt.AutoSize = true;
            this.LblSt.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSt.Location = new System.Drawing.Point(507, 30);
            this.LblSt.Name = "LblSt";
            this.LblSt.Size = new System.Drawing.Size(128, 23);
            this.LblSt.TabIndex = 16;
            this.LblSt.Text = "Seçilen Tarih:";
            // 
            // FrmGelirIstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(745, 468);
            this.Controls.Add(this.LblStp);
            this.Controls.Add(this.LblSt);
            this.Controls.Add(this.ChrtGelir);
            this.Controls.Add(this.CmbTarih);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblPara);
            this.Controls.Add(this.LblKasa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGelirIstatistik";
            this.Text = "Gelir İstatistik";
            this.Load += new System.EventHandler(this.FrmGelirIstatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChrtGelir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblKasa;
        private System.Windows.Forms.Label LblPara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbTarih;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChrtGelir;
        private System.Windows.Forms.Label LblStp;
        private System.Windows.Forms.Label LblSt;
    }
}