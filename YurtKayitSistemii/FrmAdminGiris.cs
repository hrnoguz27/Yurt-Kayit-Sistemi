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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlConnect conn = new SqlConnect();
        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblTitle.Text = LblTitle.Text.Substring(1) + LblTitle.Text.Substring(0, 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Admin where YoneticiAd=@p1 and YoneticiSifre=@p2", conn.connect());
            command.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
            command.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader read = command.ExecuteReader();
            if (read.Read())
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
                TxtKullaniciAdi.Clear();
                TxtSifre.Clear();
                TxtKullaniciAdi.Focus();
            }
            conn.connect().Close();
        }

        private void BtnSifreShow_Click(object sender, EventArgs e)
        {
            TxtSifre.UseSystemPasswordChar = !TxtSifre.UseSystemPasswordChar;
        }
    }
}
