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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        public string TC;
        
        SQLBaglantısı bgl = new SQLBaglantısı();

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TC;
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad,Doktorid From Tbl_Doktorlar Where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Hasta Listesini Çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor='" + lbladsoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richTextBoxsikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void buttonBilgiDuzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDüzenle doktorbilgidüzenle = new FrmDoktorBilgiDüzenle();
            doktorbilgidüzenle.TCno = lblTC.Text;
            doktorbilgidüzenle.Show();
        }

        private void buttonDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular duyurular = new FrmDuyurular();
            duyurular.Show();
        }

        private void buttonCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
