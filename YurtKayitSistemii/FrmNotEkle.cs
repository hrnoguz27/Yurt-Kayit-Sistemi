using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace YurtKayitSistemi
{
    public partial class FrmNotEkle : Form
    {
        string text = "Not Ekleyin";
        public FrmNotEkle()
        {
            InitializeComponent();
            richTextBox1.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Title = "Kayıt Yeri Seçin";
                saveFileDialog1.Filter = "Metin Dosyası | *.txt";
                saveFileDialog1.InitialDirectory = "C:\\Users\\your User\\source\\your file";
                saveFileDialog1.ShowDialog();
                StreamWriter kaydet = new StreamWriter(saveFileDialog1.FileName);
                kaydet.WriteLine(richTextBox1.Text);
                kaydet.Close();
                MessageBox.Show("Kayıt Yapıldı.");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata,Tekrar Deneyiniz!");
            }
            
        }
        
        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            if (richTextBox1.Text == text)
            {
                richTextBox1.Text = "";
            }
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = text;
            }
        }
    }
}
