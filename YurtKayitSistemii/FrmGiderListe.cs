﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    public partial class FrmGiderListe : Form
    {
        public FrmGiderListe()
        {
            InitializeComponent();
        }

        private void FrmGiderListe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet4.Giderler' table. You can move, or remove it, as needed.
            this.giderlerTableAdapter.Fill(this.yurtOtomasyonuDataSet4.Giderler);
            this.dataGridView1.DefaultCellStyle.Font= new Font("Georgia", 11);
        }
       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;

            FrmGiderGüncelle fr = new FrmGiderGüncelle();
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            fr.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            fr.elektrik = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            fr.su = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            fr.dogalgaz = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            fr.internet = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            fr.gida = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            fr.personel = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            fr.diger = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            fr.Show();
        }
    }
}
