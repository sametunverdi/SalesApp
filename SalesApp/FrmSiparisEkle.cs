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
    public partial class FrmSiparisEkle : Form
    {
        public FrmSiparisEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-EELQ0C13\\SQLEXPRESS; Initial Catalog=SalesApp; Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxMusteri.SelectedItem != null && comboBoxUrun.SelectedItem != null &&
        !   string.IsNullOrEmpty(SiparisMiktar.Text) && !string.IsNullOrEmpty(SiparisFiyat.Text))
            {
              
                int musteriId = Convert.ToInt32(((dynamic)comboBoxMusteri.SelectedItem).Value);
                int urunId = Convert.ToInt32(((dynamic)comboBoxUrun.SelectedItem).Value);
                int miktar = Convert.ToInt32(SiparisMiktar.Text);
                decimal fiyat = Convert.ToDecimal(SiparisFiyat.Text);
                var aciklama = Convert.ToString(SiparisAciklama.Text);


                decimal toplamFiyat = fiyat * miktar;


                baglanti.Open();

                // 1. Ürünün stok miktarını kontrol et
                SqlCommand stokSorgu = new SqlCommand("SELECT Miktar FROM Urunler WHERE Urunid = @Urunid", baglanti);
                stokSorgu.Parameters.AddWithValue("@Urunid", urunId);
                int mevcutStok = Convert.ToInt32(stokSorgu.ExecuteScalar());

                // 2. Stok yeterliyse siparişi ekle ve stoktan düş
                if (mevcutStok >= miktar)
                {

                    string query = "INSERT INTO Siparisler (Musteriid, Urunid, Adet, Fiyat, ToplamFiyat, SiparisTarihi, SiparisAciklama) " +
                   "VALUES (@Musteriid, @Urunid, @Adet, @Fiyat, @ToplamFiyat, @SiparisTarihi, @SiparisAciklama)";

                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@Musteriid", musteriId);
                    komut.Parameters.AddWithValue("@Urunid", urunId);
                    komut.Parameters.AddWithValue("@Adet", miktar);
                    komut.Parameters.AddWithValue("@Fiyat", fiyat);
                    komut.Parameters.AddWithValue("@ToplamFiyat", toplamFiyat);
                    komut.Parameters.AddWithValue("@SiparisTarihi", DateTime.Now);
                    komut.Parameters.AddWithValue("@SiparisAciklama", aciklama);


                    

                    // Stoktan düş
                    SqlCommand stokGuncelle = new SqlCommand("UPDATE Urunler SET Miktar = Miktar - @Miktar WHERE Urunid = @Urunid", baglanti);
                    stokGuncelle.Parameters.AddWithValue("@Urunid", urunId);
                    stokGuncelle.Parameters.AddWithValue("@Miktar", miktar);
                    stokGuncelle.ExecuteNonQuery();

                    MessageBox.Show("Sipariş eklendi ve stok güncellendi.");
                }
                else
                {
                    MessageBox.Show("Yetersiz stok! Sipariş verilemedi.");
                }

                baglanti.Close();
            }
        
        }

        private void FrmSiparisEkle_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT Musteriid, Adi + ' ' + Soyadi AS MusteriAdi FROM MusteriEkle", baglanti);
            baglanti.Open();
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBoxMusteri.Items.Add(new { Text = oku["MusteriAdi"].ToString(), Value = Convert.ToInt32(oku["Musteriid"]) });
            }
            baglanti.Close();

            komut = new SqlCommand("SELECT Urunid, UrunAdi FROM Urunler", baglanti);
            baglanti.Open();
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBoxUrun.Items.Add(new { Text = oku["UrunAdi"].ToString(), Value = Convert.ToInt32(oku["Urunid"]) });
            }
            baglanti.Close();

            comboBoxMusteri.DisplayMember = "Text";
            comboBoxMusteri.ValueMember = "Value";

            comboBoxUrun.DisplayMember = "Text";
            comboBoxUrun.ValueMember = "Value";
        }

        private decimal urunFiyat = 0;
        private void comboBoxUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUrun.SelectedItem != null)
            {
                int urunId = Convert.ToInt32(((dynamic)comboBoxUrun.SelectedItem).Value);

                string query = "SELECT Fiyat FROM Urunler WHERE Urunid = @Urunid";
                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.Parameters.AddWithValue("@Urunid", urunId);

                baglanti.Open();
                object sonuc = komut.ExecuteScalar();
                baglanti.Close();

                if (sonuc != null)
                {
                    urunFiyat = Convert.ToDecimal(sonuc);
                    SiparisFiyat.Text = urunFiyat.ToString("0.00"); 
                }

                HesaplaToplamFiyat(); 
            }
        }

        private void SiparisMiktar_TextChanged(object sender, EventArgs e)
        {
            HesaplaToplamFiyat();
        }
        private void HesaplaToplamFiyat()
        {
            if (decimal.TryParse(SiparisFiyat.Text, out decimal fiyat) && int.TryParse(SiparisMiktar.Text, out int miktar))
            {
                decimal toplamFiyat = fiyat * miktar;
                lblToplamFiyat.Text = "Toplam Fiyat: " + toplamFiyat.ToString("0.00") + " TL"; 
            }
            else
            {
                lblToplamFiyat.Text = "Toplam Fiyat: 0.00 TL";
            }
        }
        

        private void VeriGoster_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnVeriGoster_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
               
                ListViewItem selectedItem = listView1.SelectedItems[0];

                
                int siparisId;
                if (!int.TryParse(selectedItem.SubItems[0].Text, out siparisId))
                {
                    MessageBox.Show("Sipariş ID format hatası.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                string musteriAdi = selectedItem.SubItems[1].Text;
                string urunAdi = selectedItem.SubItems[2].Text;

                int adet;
                if (!int.TryParse(selectedItem.SubItems[3].Text, out adet))
                {
                    MessageBox.Show("Adet format hatası.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal fiyat;
                if (!decimal.TryParse(selectedItem.SubItems[4].Text, out fiyat))
                {
                    MessageBox.Show("Fiyat format hatası.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal toplamFiyat;
                if (!decimal.TryParse(selectedItem.SubItems[5].Text, out toplamFiyat))
                {
                    MessageBox.Show("Toplam Fiyat format hatası.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string siparisTarihi = selectedItem.SubItems[6].Text;
                string siparisAciklama = selectedItem.SubItems[7].Text;

                
                comboBoxMusteri.SelectedItem = comboBoxMusteri.Items.Cast<dynamic>().FirstOrDefault(m => m.Text == musteriAdi);
                comboBoxUrun.SelectedItem = comboBoxUrun.Items.Cast<dynamic>().FirstOrDefault(u => u.Text == urunAdi);

                
                SiparisMiktar.Text = adet.ToString();
                SiparisFiyat.Text = fiyat.ToString("0.00");
                lblToplamFiyat.Text = "Toplam Fiyat: " + toplamFiyat.ToString("0.00") + " TL";
                SiparisAciklama.Text = siparisAciklama;
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int siparisId = Convert.ToInt32(selectedItem.SubItems[0].Text);
                int adet = int.TryParse(SiparisMiktar.Text, out adet) ? adet : 0;
                decimal fiyat = decimal.TryParse(SiparisFiyat.Text, out fiyat) ? fiyat : 0;
                decimal toplamFiyat = adet * fiyat;
                string aciklama = SiparisAciklama.Text;
                int musteriId = Convert.ToInt32(((dynamic)comboBoxMusteri.SelectedItem).Value);
                int urunId = Convert.ToInt32(((dynamic)comboBoxUrun.SelectedItem).Value);

                string query = "UPDATE Siparisler SET Musteriid = @Musteriid, Urunid = @Urunid, Adet = @Adet, Fiyat = @Fiyat, ToplamFiyat = @ToplamFiyat, SiparisAciklama = @SiparisAciklama WHERE Siparisid = @Siparisid";
                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.Parameters.AddWithValue("@Musteriid", musteriId);
                komut.Parameters.AddWithValue("@Urunid", urunId);
                komut.Parameters.AddWithValue("@Adet", adet);
                komut.Parameters.AddWithValue("@Fiyat", fiyat);
                komut.Parameters.AddWithValue("@ToplamFiyat", toplamFiyat);
                komut.Parameters.AddWithValue("@SiparisAciklama", aciklama);
                komut.Parameters.AddWithValue("@Siparisid", siparisId);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Sipariş başarıyla güncellendi!");
                BtnVeriGoster_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için bir sipariş seçin.");
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int siparisId = Convert.ToInt32(selectedItem.SubItems[0].Text);

                string query = "DELETE FROM Siparisler WHERE Siparisid = @Siparisid";
                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.Parameters.AddWithValue("@Siparisid", siparisId);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Sipariş başarıyla silindi!");
                BtnVeriGoster_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir sipariş seçin.");
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            comboBoxMusteri.SelectedIndex = -1;
            comboBoxUrun.SelectedIndex = -1;
            SiparisMiktar.Clear();
            SiparisFiyat.Clear();
            SiparisAciklama.Clear();
            lblToplamFiyat.Text = "Toplam Fiyat: 0.00 TL";
        }

        private void Mst2_Click(object sender, EventArgs e)
        {
            FrmUrunler frm = new FrmUrunler();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmSiparisEkle frm = new FrmSiparisEkle();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Musteriler frm = new Musteriler();
            frm.Show();
            this.Hide();
        }

        private void Mst1_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle frm = new FrmMusteriEkle();
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}