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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string TC;

        SQLBaglantısı bgl = new SQLBaglantısı();

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TC;
            //Ad Soyad Bilgi Çekme İşlemi
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC=" + TC, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branşları Çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar Order By Bransad ASC", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBoxbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void comboBoxbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad,DoktorBrans from Tbl_Doktorlar where DoktorBrans = @p1 Order By DoktorAd ASC", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", comboBoxbrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                comboBoxdoktor.Items.Clear();
                comboBoxdoktor.Text = "";
                comboBoxdoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void comboBoxdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular Where RandevuBrans='" + comboBoxbrans.Text + "'" + "and RandevuDoktor='" + comboBoxdoktor.Text + "' and RandevuDurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void linkLabelbilgiduzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle bilgiduzenle = new FrmBilgiDuzenle();
            bilgiduzenle.TC = lblTC.Text;
            bilgiduzenle.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            textBoxid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            richTextBoxsikayet.Text = "";
            buttonrendevual.Text = "Randevu Al";
        }

        private void buttonrendevual_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Randevular set RandevuDurum=@p1,HastaTC=@p2,HastaSikayet=@p3 where Randevuid=@p4", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", true);
            komut.Parameters.AddWithValue("@p2", lblTC.Text);
            komut.Parameters.AddWithValue("@p3", richTextBoxsikayet.Text);
            komut.Parameters.AddWithValue("@p4", textBoxid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            if (buttonrendevual.Text=="Randevu Al")
            {
                MessageBox.Show("Randevu başarılı şekilde alınmıştır!");
            }
            else if (buttonrendevual.Text == "Güncelle")
            {
                MessageBox.Show("Randevunuz başarılı şekilde güncellenmiştir!");
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBoxid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            comboBoxbrans.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            comboBoxdoktor.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            richTextBoxsikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            buttonrendevual.Text = "Güncelle";
        }
    }
}
