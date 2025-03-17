using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SalesApp
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-EELQ0C13\\SQLEXPRESS; Initial Catalog=SalesApp; Integrated Security=True");
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = TxtKullaniciAdi.Text;
            var sifre = TxtSifre.Text;

            if (kullaniciAdi != "" && sifre != "")
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM Kullanicilar WHERE KullaniciAdi = @KullaniciAdi AND KullaniciSifre = @KullaniciSifre", baglanti);
                    komut.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                    komut.Parameters.AddWithValue("@KullaniciSifre", sifre);

                    int kullaniciSayisi = (int)komut.ExecuteScalar(); // Eğer kullanıcı varsa, sonuç 1 döner, yoksa 0 döner.
                    baglanti.Close();

                    if (kullaniciSayisi > 0)
                    {
                        // Kullanıcı doğruysa, FrmMusteriEkle sayfasına yönlendirme yap
                        FrmMusteriEkle musteriEkleFormu = new FrmMusteriEkle();
                        musteriEkleFormu.Show();
                        this.Hide(); // Giriş formunu kapatıyoruz.
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
            }
        
    }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmKayitOl frm = new FrmKayitOl();
            frm.Show();
            this.Hide();
        }
    }
}
