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
    public partial class FrmGiderGüncelle : Form
    {
        public FrmGiderGüncelle()
        {
            InitializeComponent();
        }
        public string id, elektrik, su, dogalgaz, gida, diger, internet, personel;

        SqlConnect conn = new SqlConnect();
        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("update Giderler set Elektrik = @p1,Su=@p2,Dogalgaz=@p3,Internet=@p4,Gida=@p5,Personel=@p6,Diger=@p7 where OdemeId = @p8", conn.connect());
                command.Parameters.AddWithValue("@p8", TxtId.Text);
                command.Parameters.AddWithValue("@p1", TxtElektrik.Text);
                command.Parameters.AddWithValue("@p2", TxtSu.Text);
                command.Parameters.AddWithValue("@p3", TxtDogalgaz.Text);
                command.Parameters.AddWithValue("@p4", TxtInternet.Text);
                command.Parameters.AddWithValue("@p5", TxtGida.Text);
                command.Parameters.AddWithValue("@p6", TxtPersonel.Text);
                command.Parameters.AddWithValue("@p7", TxtDiger.Text);
                command.ExecuteNonQuery();
                conn.connect().Close();
                MessageBox.Show("Kayıtlar Güncellendi!");
            }
            catch (Exception)
            {

                MessageBox.Show("Hata,Lütfen Tekrar Deneyiniz!");
            }
            
        }

        private void FrmGiderGüncelle_Load(object sender, EventArgs e)
        {
            TxtId.Text = id;
            TxtElektrik.Text = elektrik;
            TxtSu.Text = su;
            TxtDogalgaz.Text = dogalgaz;
            TxtGida.Text = gida;
            TxtInternet.Text = internet;
            TxtPersonel.Text = personel;
            TxtDiger.Text = diger;
        }
    }
}
