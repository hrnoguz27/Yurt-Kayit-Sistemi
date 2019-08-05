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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        SqlConnect conn = new SqlConnect();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet6.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet6.Personel);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id, ad, gorev;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            gorev = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtPersonelId.Text = id;
            TxtPersonelAdi.Text = ad;
            TxtPersonelGorev.Text = gorev;
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtPersonelAdi.Text!="" && TxtPersonelGorev.Text != "")
                {
                    SqlCommand command = new SqlCommand("insert into Personel (PersonelAdSoyad,PersonelDepartman) values(@p1,@p2)", conn.connect());
                    command.Parameters.AddWithValue("@p1", TxtPersonelAdi.Text);
                    command.Parameters.AddWithValue("@p2", TxtPersonelGorev.Text);
                    command.ExecuteNonQuery();
                    conn.connect().Close();
                    MessageBox.Show("Personel Eklendi");
                    this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet6.Personel);
                }
                else
                {
                    MessageBox.Show("Doldurulması Zorunlu Alanları Boş Bırakmayınız!");
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Personel Eklenirken Bir Hata Oluştu");
            }
        }
        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("delete from Personel where PersonelId=@p1", conn.connect());
                command.Parameters.AddWithValue("@p1", TxtPersonelId.Text);
                command.ExecuteNonQuery();
                conn.connect().Close();
                MessageBox.Show("Silme İşlemi Gerçekleştirildi.");
                this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet6.Personel);
                TxtPersonelId.Clear();
                TxtPersonelAdi.Clear();
                TxtPersonelGorev.Clear();
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
                SqlCommand command = new SqlCommand("update Personel set PersonelAdSoyad=@p1,PersonelDepartman=@p2 where PersonelId=@p3", conn.connect());
                command.Parameters.AddWithValue("@p1", TxtPersonelAdi.Text);
                command.Parameters.AddWithValue("@p2", TxtPersonelGorev.Text);
                command.Parameters.AddWithValue("@p3", TxtPersonelId.Text);
                command.ExecuteNonQuery();
                conn.connect().Close();
                MessageBox.Show("Güncelleme İşlemi Gerçekleştirildi.");
                this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet6.Personel);
            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme İşlemi Başarısız Oldu.");
            }
        }

        
    }
}
