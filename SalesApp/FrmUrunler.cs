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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SalesApp
{
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-EELQ0C13\\SQLEXPRESS; Initial Catalog=SalesApp; Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            FrmUrunler frm = new FrmUrunler();
            frm.Show();
            this.Hide();
        }

        private void verilergoster()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Urunler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {


                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Urunid"].ToString();
                ekle.SubItems.Add(oku["UrunAdi"].ToString());
                ekle.SubItems.Add(oku["Barkod"].ToString());
                ekle.SubItems.Add(oku["Birim"].ToString());
                ekle.SubItems.Add(oku["Miktar"].ToString());
                ekle.SubItems.Add(oku["Fiyat"].ToString());
               

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle frm = new FrmMusteriEkle();
            frm.Show();
            this.Hide();
        }

        private void UrnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Urunler (UrunAdi, Barkod, Birim, Miktar, Fiyat) VALUES (@UrunAdi, @Barkod, @Birim, @Miktar, @Fiyat)", baglanti);

            komut.Parameters.AddWithValue("@UrunAdi", UrnAdi.Text);
            komut.Parameters.AddWithValue("@Barkod", UrnBarkod.Text);
            komut.Parameters.AddWithValue("@Birim", UrnBirim.Text);
            komut.Parameters.AddWithValue("@Miktar", Convert.ToInt32(UrnAdet.Text));  
            komut.Parameters.AddWithValue("@Fiyat", Convert.ToDecimal(UrnFiyat.Text));  

            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Musteriler frm = new Musteriler();
            frm.Show();
            this.Hide();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            UrnAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            UrnBarkod.Text = listView1.SelectedItems[0].SubItems[2].Text;
            UrnBirim.Text = listView1.SelectedItems[0].SubItems[3].Text;
            UrnAdet.Text = listView1.SelectedItems[0].SubItems[4].Text;
            UrnFiyat.Text = listView1.SelectedItems[0].SubItems[5].Text;
            
        }

        int id = 0;

        private void VeriGoster_Click(object sender, EventArgs e)
        {
            verilergoster();
        }
    }
}
