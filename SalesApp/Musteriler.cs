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
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-EELQ0C13\SQLEXPRESS; Initial Catalog=SalesApp; Integrated Security=True");

        private void verilergoster()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {


                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Firmaismi"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["Adres"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["Vergino"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilergoster();
        }

        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            MstSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            MstFirma.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MstMail.Text = listView1.SelectedItems[0].SubItems[4].Text;
            MstAdres.Text = listView1.SelectedItems[0].SubItems[5].Text;
            MstTelefon.Text = listView1.SelectedItems[0].SubItems[6].Text;
            MstTc.Text = listView1.SelectedItems[0].SubItems[7].Text;
            MstVergiNo.Text = listView1.SelectedItems[0].SubItems[8].Text;

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from MusteriEkle where Musteriid=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            MstSoyadi.Clear();
            MstFirma.Clear();
            MstMail.Clear();
            MstAdres.Clear();
            MstTelefon.Clear();
            MstVergiNo.Clear();
            MstTc.Clear();
            MstVergiNo.Clear();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE MusteriEkle SET " +
                                                  "Adi = @Adi, " +
                                                  "Soyadi = @Soyadi, " +
                                                  "Firmaismi = @Firmaismi, " +
                                                  "Mail = @Mail, " +
                                                  "Adres = @Adres, " +
                                                  "Telefon = @Telefon, " +
                                                  "TC = @TC, " +
                                                  "Vergino = @Vergino " +
                                                  "WHERE Musteriid = @Musteriid", baglanti);

                komut.Parameters.AddWithValue("@Adi", textBox1.Text);
                komut.Parameters.AddWithValue("@Soyadi", MstSoyadi.Text);
                komut.Parameters.AddWithValue("@Firmaismi", MstFirma.Text);
                komut.Parameters.AddWithValue("@Mail", MstMail.Text);
                komut.Parameters.AddWithValue("@Adres", MstAdres.Text);
                komut.Parameters.AddWithValue("@Telefon", MstTelefon.Text);
                komut.Parameters.AddWithValue("@TC", MstTc.Text);
                komut.Parameters.AddWithValue("@Vergino", MstVergiNo.Text);
                komut.Parameters.AddWithValue("@Musteriid", id);

                komut.ExecuteNonQuery();
                baglanti.Close();


                verilergoster();
            }

        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where Adi like '%"+MstArama.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {


                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Firmaismi"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["Adres"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["Vergino"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void Mst1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
