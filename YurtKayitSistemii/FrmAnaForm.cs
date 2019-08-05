using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet1.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonuDataSet1.Ogrenci);
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MsPaint.exe");
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("15.02.2019-17.02.2019 Öğrenci Yurt Otomasyon Sistemi \n HARUN OĞUZ \n Copyright © 2019 Tüm Hakları Saklıdır!");
        }

        private void radyo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://yayin3.canlitv.com:5070/";
        }

        private void radyo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://radyo.dogannet.tv/slowturk";
        }

        private void radyo3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://turkmedya.radyotvonline.com/turkmedya/alemfm.stream/playlist.m3u8";
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmOgrKayit fr = new FrmOgrKayit();
                fr.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata!,Tekrar Deneyiniz.");
            }
            
        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmOgrListe fr = new FrmOgrListe();
                fr.Show();
                MessageBox.Show("Güncelleme İçin İstediğiniz Alana Tıklayın.","İpucu",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Hata!,Tekrar Deneyiniz.");
            }
            
        }

        private void bölümEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBolumler fr = new FrmBolumler();
                fr.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata!,Tekrar Deneyiniz.");
            }
           
        }

        private void bölümDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBolumler fr = new FrmBolumler();
                fr.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata!,Tekrar Deneyiniz.");
            }
        }

        private void ödemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmOdemeler fr = new FrmOdemeler();
                fr.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata!,Tekrar Deneyiniz.");
            }
            
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmGider fr = new FrmGider();
                fr.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata!,Tekrar Deneyiniz.");
            }
            
        }

        private void giderListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmGiderListe fr = new FrmGiderListe();
                fr.Show();
                MessageBox.Show("Güncelleme İçin İstediğiniz Alana Tıklayın.", "İpucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Hata!,Tekrar Deneyiniz.");
            }
        }

        private void gelirİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmGelirIstatistik fr = new FrmGelirIstatistik();
                fr.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata!,Tekrar Deneyiniz.");
            }
        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAdminGuncelle fr = new FrmAdminGuncelle();
                fr.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata!,Tekrar Deneyiniz.");
            }
        }

        private void personelDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPersonel fr = new FrmPersonel();
                fr.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata!,Tekrar Deneyiniz.");
            }
        }

        private void öğrenciSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmOgrListe fr = new FrmOgrListe();
                fr.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata!,Tekrar Deneyiniz.");
            }
        }

        private void notEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmNotEkle fr = new FrmNotEkle();
                fr.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata!,Tekrar Deneyiniz.");
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
