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
    public partial class FrmDoktorBilgiDüzenle : Form
    {
        public FrmDoktorBilgiDüzenle()
        {
            InitializeComponent();
        }

        public string TCno;

        SQLBaglantısı bgl = new SQLBaglantısı();

        private void FrmDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            MskTC.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBoxad.Text = dr[1].ToString();
                textBoxsoyad.Text = dr[2].ToString();
                comboBoxBrans.Text = dr[3].ToString();
                txtsifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void buttongüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set Doktorad=@d1,DoktorSoyad=@d2,DoktorBrans=@d3,DoktorSifre=@d4 where DoktorTc=@d5", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", textBoxad.Text);
            komut.Parameters.AddWithValue("@d2", textBoxsoyad.Text);
            komut.Parameters.AddWithValue("@d3", comboBoxBrans.Text);
            komut.Parameters.AddWithValue("@d4", txtsifre.Text);
            komut.Parameters.AddWithValue("@d5", MskTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            labeluyari.Text = "Bilgileriniz güncellenmiştir!";
            labeluyari.Visible = true;
            labeluyari.ForeColor = Color.Red;
        }
    }
}
