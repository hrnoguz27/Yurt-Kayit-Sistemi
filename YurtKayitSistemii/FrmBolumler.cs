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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }
        SqlConnect conn = new SqlConnect();

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet.Bolumler' table. You can move, or remove it, as needed.
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu Tekrar Deneyiniz!");
            }

        }
        private void PcbBolumSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command2 = new SqlCommand("delete from Bolumler where BolumId=@p1",conn.connect());
                command2.Parameters.AddWithValue("@p1", TxtBolumId.Text);
                command2.ExecuteNonQuery();
                conn.connect().Close();
                MessageBox.Show("Silme İşlemi Gerçekleştirildi.");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
            }
            catch (Exception)
            {

                MessageBox.Show("Hata, işlem Gerçekleştirilemedi.");
            }
        }
        int choosen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            choosen = dataGridView1.SelectedCells[0].RowIndex;
            string id, bolumad;
            id = dataGridView1.Rows[choosen].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[choosen].Cells[1].Value.ToString();
            TxtBolumId.Text = id;
            TxtBolumAd.Text = bolumad;
            
        }

        private void PcbBolumDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command3 = new SqlCommand("update Bolumler set BolumAd=@p1 where BolumId=@p2", conn.connect());
                command3.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                command3.Parameters.AddWithValue("@p2", TxtBolumId.Text);
                command3.ExecuteNonQuery();
                conn.connect().Close();
                MessageBox.Show("Güncelleme Gerçekleştirildi.");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
            }
            catch (Exception)
            {

                MessageBox.Show("Hata! Güncelleme Gerçekleştirilemedi.");
            }
            
        }

        private void PcbBolumEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command4 = new SqlCommand("insert into Bolumler (BolumAd) values(@p1)", conn.connect());
                command4.Parameters.Add("@p1", TxtBolumAd.Text);
                command4.ExecuteNonQuery();
                conn.connect().Close();
                MessageBox.Show("Bölüm Eklendi.");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
            }
            catch (Exception)
            {

                MessageBox.Show("Bölüm Eklenirken Hata Oluştu!");
            }
            
        }
    }
}
