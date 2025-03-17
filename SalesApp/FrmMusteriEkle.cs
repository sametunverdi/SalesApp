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
    public partial class FrmMusteriEkle : Form
    {
        public FrmMusteriEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-EELQ0C13\\SQLEXPRESS; Initial Catalog=SalesApp; Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle frm = new FrmMusteriEkle();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmUrunler frm = new FrmUrunler();
            frm.Show();
            this.Hide();
        }

        private void MstKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO MusteriEkle (Adi, Soyadi, Firmaismi, Mail, Adres, Telefon, TC, Vergino) VALUES (@Adi, @Soyadi, @Firmaismi, @Mail, @Adres, @Telefon, @TC, @Vergino)", baglanti);

                komut.Parameters.AddWithValue("@Adi", MstAdi.Text);
                komut.Parameters.AddWithValue("@Soyadi", MstSoyadi.Text);
                komut.Parameters.AddWithValue("@Firmaismi", MstFirma.Text);
                komut.Parameters.AddWithValue("@Mail", MstMail.Text);
                komut.Parameters.AddWithValue("@Adres", MstAdres.Text);
                komut.Parameters.AddWithValue("@Telefon", MstTelefon.Text);
                komut.Parameters.AddWithValue("@TC", MstTc.Text);
                komut.Parameters.AddWithValue("@Vergino", MstVergiNo.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();

               
                MessageBox.Show("Müşteri başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Musteriler frm = new Musteriler();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmSiparisEkle frm = new FrmSiparisEkle();
            frm.Show();
            this.Hide();
        }

        private void FrmMusteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
