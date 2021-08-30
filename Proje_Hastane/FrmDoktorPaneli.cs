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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        SQLBaglantısı bgl = new SQLBaglantısı();

        private void DoktorlarListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Doktorlar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DoktorlarListesi();
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar Order By Bransad ASC", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBoxbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", textBoxad.Text);
            komut.Parameters.AddWithValue("@d2", textBoxsoyad.Text);
            komut.Parameters.AddWithValue("@d3", comboBoxbrans.Text);
            komut.Parameters.AddWithValue("@d4", maskedTextBoxTC.Text);
            komut.Parameters.AddWithValue("@d5", textBoxSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Ekelndi");
            DoktorlarListesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBoxad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBoxsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBoxbrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTextBoxTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBoxSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@d1,DoktorSoyad=@d2,DoktorBrans=@d3,DoktorSifre=@d5 Where DoktorTC=@d4", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", textBoxad.Text);
            komut.Parameters.AddWithValue("@d2", textBoxsoyad.Text);
            komut.Parameters.AddWithValue("@d3", comboBoxbrans.Text);
            komut.Parameters.AddWithValue("@d4", maskedTextBoxTC.Text);
            komut.Parameters.AddWithValue("@d5", textBoxSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Bilgileri Güncellendi!");
            DoktorlarListesi();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Tbl_Doktorlar Where DoktorTC@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBoxTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi!");
            DoktorlarListesi();
        }
    }
}
