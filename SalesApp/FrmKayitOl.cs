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

namespace SalesApp
{
    public partial class FrmKayitOl : Form
    {
        public FrmKayitOl()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-EELQ0C13\\SQLEXPRESS; Initial Catalog=SalesApp; Integrated Security=True");

        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            if (TxtKullaniciAdi.Text != "" && TxtSifre.Text != "")
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("INSERT INTO Kullanicilar (Kullaniciadi, KullaniciSifre) VALUES (@Kullaniciadi, @KullaniciSifre)", baglanti);
                    komut.Parameters.AddWithValue("@Kullaniciadi", TxtKullaniciAdi.Text);
                    komut.Parameters.AddWithValue("@KullaniciSifre", TxtSifre.Text);  

                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Kayıt başarılı! Giriş yapabilirsiniz.");

                    FrmGiris frm = new FrmGiris(); 
                    frm.Show(); 
                    this.Close(); 
                    


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
    }
}
