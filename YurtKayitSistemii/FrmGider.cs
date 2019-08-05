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
    public partial class FrmGider : Form
    {
        public FrmGider()
        {
            InitializeComponent();
        }
        SqlConnect conn = new SqlConnect();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtElektrik.Text != "" && TxtSu.Text != "" && TxtInternet.Text != "" && TxtGida.Text != "" && TxtDogalgaz.Text != "" && TxtPersonel.Text != "" && TxtDiger.Text != "")
                {
                    SqlCommand command = new SqlCommand("insert into Giderler (Elektrik,Su,Dogalgaz,Internet,Gida,Personel,Diger) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", conn.connect());
                    command.Parameters.AddWithValue("@p1", TxtElektrik.Text);
                    command.Parameters.AddWithValue("@p2", TxtSu.Text);
                    command.Parameters.AddWithValue("@p3", TxtDogalgaz.Text);
                    command.Parameters.AddWithValue("@p4", TxtInternet.Text);
                    command.Parameters.AddWithValue("@p5", TxtGida.Text);
                    command.Parameters.AddWithValue("@p6", TxtPersonel.Text);
                    command.Parameters.AddWithValue("@p7", TxtDiger.Text);
                    command.ExecuteNonQuery();
                    conn.connect().Close();
                    MessageBox.Show("Giderler Veritabanına Eklendi.");
                }
                else
                {
                    MessageBox.Show("Doldurulması Zorunlu Alanları Boş Bırakmayınız!");
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Hata,Lütfen Tekrar Deneyiniz");
            }
            

        }
    }
}
