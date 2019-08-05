using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace YurtKayitSistemi
{
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }
        SqlConnect conn = new SqlConnect();
        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet2.Borclar' table. You can move, or remove it, as needed.
            this.borclarTableAdapter.Fill(this.yurtOtomasyonuDataSet2.Borclar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            TxtId.Text = id;
            TxtOgrAd.Text = ad;
            TxtOgrSoyad.Text = soyad;
            TxtKalan.Text = kalan;
        }

        private void BtnOdeme_Click(object sender, EventArgs e)
        {
            //Kalan Borcu hesaplama
            int odenen, kalan,yeniborc;
            odenen = Convert.ToInt16(TxtOdenen.Text);
            kalan = Convert.ToInt16(TxtKalan.Text);
            yeniborc = kalan - odenen;
            TxtKalan.Text = yeniborc.ToString();
            // Yeni tutarı veritabanında güncelleme
            SqlCommand command = new SqlCommand("update Borclar set OgrKalanBorc=@p1 where OgrId=@p2 ", conn.connect());
            command.Parameters.AddWithValue("@p2", TxtId.Text);
            command.Parameters.AddWithValue("@p1", TxtKalan.Text);
            command.ExecuteNonQuery();
            conn.connect().Close();
            MessageBox.Show("Borç Ödendi!");
            this.borclarTableAdapter.Fill(this.yurtOtomasyonuDataSet2.Borclar);

            //Kasa Tablosuna Ekleme
            try
            {
                SqlCommand command2 = new SqlCommand("insert into Kasa (OdemeAy,OdemeMiktar) values(@k1,@k2)", conn.connect());
                command2.Parameters.AddWithValue("@k1", CmbOdenenAy.Text + " " + CmbOdenenYil.Text);
                command2.Parameters.AddWithValue("@k2", TxtOdenen.Text);
                command2.ExecuteNonQuery();
                conn.connect().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Kasa Tablosuna Eklenirken Hata Oluştu Lütfen Tekrar Deneyiniz.");
            }
            
        }
    }
}
