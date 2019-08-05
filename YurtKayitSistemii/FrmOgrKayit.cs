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
    public partial class FrmOgrKayit : Form
    {
        public FrmOgrKayit()
        {
            InitializeComponent();
        }
        SqlConnect conn = new SqlConnect();
        private void FrmOgrKayit_Load(object sender, EventArgs e)
        {
            // Bölümleri Listeleme
            
            SqlCommand command = new SqlCommand("select BolumAd from Bolumler", conn.connect());
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                CmbBolumler.Items.Add(read[0].ToString());
            }
            conn.connect().Close();

            //Boş Odaları Listeleme
            
            SqlCommand command2 = new SqlCommand("select OdaNo from Odalar where OdaKapasite != OdaAktif", conn.connect());
            SqlDataReader read2 = command2.ExecuteReader();
            while (read2.Read())
            {
                CmbOdaNo.Items.Add(read2[0].ToString());
            }
            conn.connect().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Öğrenci Kayıt
                if (TxtOgrAd.Text!="" && TxtOgrSoyad.Text!="" && MskTC.Text!="" && MskTelefon.Text!="" && MskDogumTarihi.Text!="" && CmbBolumler.Text!=""
                    && TxtMail.Text!="" && CmbOdaNo.Text!="" && TxtVeliAdSoyad.Text!="" && MskVeliTelefon.Text!="" && RTxtAdres.Text!="")
                {
                    SqlCommand commandsave = new SqlCommand("insert into Ogrenci (OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", conn.connect());
                    commandsave.Parameters.AddWithValue("@p1", TxtOgrAd.Text);
                    commandsave.Parameters.AddWithValue("@p2", TxtOgrSoyad.Text);
                    commandsave.Parameters.AddWithValue("@p3", MskTC.Text);
                    commandsave.Parameters.AddWithValue("@p4", MskTelefon.Text);
                    commandsave.Parameters.AddWithValue("@p5", MskDogumTarihi.Text);
                    commandsave.Parameters.AddWithValue("@p6", CmbBolumler.Text);
                    commandsave.Parameters.AddWithValue("@p7", TxtMail.Text);
                    commandsave.Parameters.AddWithValue("@p8", CmbOdaNo.Text);
                    commandsave.Parameters.AddWithValue("@p9", TxtVeliAdSoyad.Text);
                    commandsave.Parameters.AddWithValue("@p10", MskVeliTelefon.Text);
                    commandsave.Parameters.AddWithValue("@p11", RTxtAdres.Text);
                    commandsave.ExecuteNonQuery();
                    conn.connect().Close();
                    MessageBox.Show("Kayıt Başarılı Bir Şekilde Eklendi.");

                    // Öğrenci Id Alınması
                    SqlCommand command = new SqlCommand("select OgrId from Ogrenci", conn.connect());
                    SqlDataReader read = command.ExecuteReader();
                    while (read.Read())
                    {
                        label1.Text = read[0].ToString();
                    }
                    conn.connect().Close();

                    // Öğrenci Borç Oluşturma
                    SqlCommand commandsave2 = new SqlCommand("insert into Borclar (OgrId,OgrAd,OgrSoyad) values(@b1,@b2,@b3)", conn.connect());
                    commandsave2.Parameters.AddWithValue("@b1", label1.Text);
                    commandsave2.Parameters.AddWithValue("@b2", TxtOgrAd.Text);
                    commandsave2.Parameters.AddWithValue("@b3", TxtOgrSoyad.Text);
                    commandsave2.ExecuteNonQuery();
                    conn.connect().Close();

                }
                else
                {
                    MessageBox.Show("Doldurulması Zorunlu Alanları Boş Bırakmayınız!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("HATA! Lütfen Yeniden Deneyiniz.");
            }

            // Öğrenci Oda Kontenjanı Arttırma
            SqlCommand commandoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif+1 where OdaNo=@o1", conn.connect());
            commandoda.Parameters.AddWithValue("@o1", CmbOdaNo.Text);
            commandoda.ExecuteNonQuery();
            conn.connect().Close();

        }
    }
}
