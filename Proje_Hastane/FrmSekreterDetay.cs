using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        public string TC;

        SQLBaglantısı bgl = new SQLBaglantısı();

        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TC;
            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            //Branşları DataGrite Aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar Order By Bransad ASC", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorları DataGrite Aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (Doktorad + ' ' + DoktorSoyad) AS 'Doktorlar',DoktorBrans From Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branşı Combobox Aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar Order By Bransad ASC", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBoxRandevuBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();


        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (Randevutarih,RandevuSaat,RandevuBrans,RandevuDoktor) values(@p1,@p2,@p3,@p4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", maskedTextBoxRandevuTarih.Text);
            komutkaydet.Parameters.AddWithValue("@p2", maskedTextBoxRandevuSaat.Text);
            komutkaydet.Parameters.AddWithValue("@p3", comboBoxRandevuBrans.Text);
            komutkaydet.Parameters.AddWithValue("@p4", comboBoxRandevuDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            labelUyarı.Text = "Randevu oluşturuldu!";
            labelUyarı.Visible = true;

        }

        private void comboBoxRandevuBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad,DoktorBrans from Tbl_Doktorlar where DoktorBrans = @p1 Order By DoktorAd ASC", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", comboBoxRandevuBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxRandevuDoktor.Items.Clear();
                comboBoxRandevuDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void buttonOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", richTextBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu!");
        }

        private void buttonDoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli doktorpaneli = new FrmDoktorPaneli();
            doktorpaneli.Show();
        }

        private void buttonBransPaneli_Click(object sender, EventArgs e)
        {
            FrmBransPaneli branspaneli = new FrmBransPaneli();
            branspaneli.Show();
        }

        private void buttonRandevu_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi randevulistesi = new FrmRandevuListesi();
            randevulistesi.Show();
        }
    }
}
