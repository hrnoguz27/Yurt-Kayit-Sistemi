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
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }

        public string id,ad,soyad,tc,telefon,dt,bolum,
            mail,odano,vad,vtelefon,adres;

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand commandsil = new SqlCommand("delete from Ogrenci where OgrId=@k1", conn.connect());
                commandsil.Parameters.AddWithValue("@k1", TxtOgrId.Text);
                commandsil.ExecuteNonQuery();
                conn.connect().Close();
                MessageBox.Show("Kayıt Silindi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Silme İşlemi Gerçekleştirildi.");
            }

            // Oda Kontenjanı Arttırma
            SqlCommand commandoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif-1 where OdaNo=@o1", conn.connect());
            commandoda.Parameters.AddWithValue("@o1", TxtOgrId.Text);
            commandoda.ExecuteNonQuery();
            conn.connect().Close();
        }

        SqlConnect conn = new SqlConnect();
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlCommand command = new SqlCommand("update Ogrenci set OgrAd=@p2,OgrSoyad=@p3,OgrTC=@p4,OgrTelefon=@p5,OgrDogum=@p6,OgrBolum=@p7,OgrMail=@p8,OgrOdaNo=@p9,OgrVeliAdSoyad=@p10,OgrVeliTelefon=@p11,OgrVeliAdres=@p12 where OgrId=@p1", conn.connect());
                command.Parameters.AddWithValue("@p1", TxtOgrId.Text);
                command.Parameters.AddWithValue("@p2", TxtOgrAd.Text);
                command.Parameters.AddWithValue("@p3", TxtOgrSoyad.Text);
                command.Parameters.AddWithValue("@p4", MskTC.Text);
                command.Parameters.AddWithValue("@p5", MskTelefon.Text);
                command.Parameters.AddWithValue("@p6", MskDogumTarihi.Text);
                command.Parameters.AddWithValue("@p7", CmbBolumler.Text);
                command.Parameters.AddWithValue("@p8", TxtMail.Text);
                command.Parameters.AddWithValue("@p9", CmbOdaNo.Text);
                command.Parameters.AddWithValue("@p10", TxtVeliAdSoyad.Text);
                command.Parameters.AddWithValue("@p11", MskVeliTelefon.Text);
                command.Parameters.AddWithValue("@p12", RTxtAdres.Text);
                command.ExecuteNonQuery();
                conn.connect().Close();
                MessageBox.Show("Kayıt Güncellendi.");
            }
            catch (Exception)
            {

                MessageBox.Show("Hata,Tekrar Deneyiniz!");
            }
            
        }

        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            TxtOgrId.Text = id;
            TxtOgrAd.Text = ad;
            TxtOgrSoyad.Text = soyad;
            MskTC.Text = tc;
            MskTelefon.Text = telefon;
            MskDogumTarihi.Text = dt;
            CmbBolumler.Text = bolum;
            TxtMail.Text = mail;
            CmbOdaNo.Text = odano;
            TxtVeliAdSoyad.Text = vad;
            MskVeliTelefon.Text = vtelefon;
            RTxtAdres.Text = adres;
            
      
        }
    }
}
