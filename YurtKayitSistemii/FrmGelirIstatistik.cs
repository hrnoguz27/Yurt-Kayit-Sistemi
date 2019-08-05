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
    public partial class FrmGelirIstatistik : Form
    {
        public FrmGelirIstatistik()
        {
            InitializeComponent();
        }
        SqlConnect conn = new SqlConnect();
        private void FrmGelirIstatistik_Load(object sender, EventArgs e)
        {
            // Kasa Miktarı
            try
            {
                SqlCommand command = new SqlCommand("select sum(OdemeMiktar) from Kasa", conn.connect());
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    LblPara.Text = read[0].ToString() + " TL";
                }
                conn.connect().Close();

                //Ayları Listeleme
                SqlCommand command2 = new SqlCommand("select distinct(OdemeAy) from Kasa", conn.connect());
                SqlDataReader read2 = command2.ExecuteReader();
                while (read2.Read())
                {
                    CmbTarih.Items.Add(read2[0].ToString());
                }
                conn.connect().Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata! Tekrar Deneyiniz.");
            }
            // Veritabanı ile Grafikleri Oluşturma
            SqlCommand command3 = new SqlCommand("select OdemeAy,sum(OdemeMiktar) from Kasa Group by OdemeAy",conn.connect());
            SqlDataReader read3 = command3.ExecuteReader();
            while (read3.Read())
            {
                this.ChrtGelir.Series["Aylik"].Points.AddXY(read3[0],read3[1]);
            }
            conn.connect().Close();
        }

        private void CmbOdenenAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("select sum(OdemeMiktar) from Kasa where OdemeAy=@p1", conn.connect());
                command.Parameters.AddWithValue("@p1", CmbTarih.Text);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    LblStp.Text = read[0].ToString()+" TL";
                }
                conn.connect().Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata! Tekrar Deneyiniz.");
            }
            
        }
    }
}
