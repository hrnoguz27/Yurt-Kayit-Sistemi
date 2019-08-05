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
    public partial class FrmAdminGuncelle : Form
    {
        public FrmAdminGuncelle()
        {
            InitializeComponent();
        }
        SqlConnect conn = new SqlConnect();
        private void FrmAdminGuncelle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet5.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet5.Admin);

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id,ad, sifre;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtYoneticiId.Text = id;
            TxtKullaniciAdi.Text = ad;
            TxtSifre.Text = sifre;
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("insert into Admin (YoneticiAd,YoneticiSifre) values(@p1,@p2)", conn.connect());
                command.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
                command.Parameters.AddWithValue("@p2", TxtSifre.Text);
                command.ExecuteNonQuery();
                conn.connect().Close();
                MessageBox.Show("Yönetici Eklendi");
                this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet5.Admin);
            }
            catch (Exception)
            {

                MessageBox.Show("Yönetici Eklenirken Bir Hata Oluştu");
            }

        }
        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("delete from Admin where YoneticiId=@p1", conn.connect());
                command.Parameters.AddWithValue("@p1", TxtYoneticiId.Text);
                command.ExecuteNonQuery();
                conn.connect().Close();
                MessageBox.Show("Silme İşlemi Gerçekleştirildi.");
                this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet5.Admin);
                TxtYoneticiId.Clear();
                TxtKullaniciAdi.Clear();
                TxtSifre.Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Silme İşlemi Yapılırken Hata Oluştu Lütfen Tekrar Deneyiniz.");
            }
        }
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("update Admin set YoneticiAd=@p1,YoneticiSifre=@p2 where YoneticiId=@p3", conn.connect());
                command.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
                command.Parameters.AddWithValue("@p2", TxtSifre.Text);
                command.Parameters.AddWithValue("@p3", TxtYoneticiId.Text);
                command.ExecuteNonQuery();
                conn.connect().Close();
                MessageBox.Show("Güncelleme İşlemi Gerçekleştirildi.");
                this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet5.Admin);
            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme İşlemi Başarısız Oldu.");
            }
        }
        
        private void BtnSifreShow_Click(object sender, EventArgs e)
        {
            TxtSifre.UseSystemPasswordChar = !TxtSifre.UseSystemPasswordChar;
        }
    }
}
