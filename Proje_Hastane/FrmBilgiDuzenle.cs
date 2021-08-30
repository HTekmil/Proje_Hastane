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
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string TC;

        SQLBaglantısı bgl = new SQLBaglantısı();

        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskTC.Text = TC;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar Where HastaTC = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBoxad.Text = dr[1].ToString();
                textBoxsoyad.Text = dr[2].ToString();
                maskedTextBoxTelefon.Text = dr[4].ToString();
                txtsifre.Text = dr[5].ToString();
                comboBoxcinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1, HastaSoyad=@p2, HastaTelefon=@p3, HastaSifre=@p4, HastaCinsiyet=@p5 Where HastaTC=@p6", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxad.Text);
            komut.Parameters.AddWithValue("@p2", textBoxsoyad.Text);
            komut.Parameters.AddWithValue("@p3", maskedTextBoxTelefon.Text);
            komut.Parameters.AddWithValue("@p4", txtsifre.Text);
            komut.Parameters.AddWithValue("@p5", comboBoxcinsiyet.Text);
            komut.Parameters.AddWithValue("@p6", MskTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            labelUyarı.Text = "Bilgilerini Başarılı \nşekilde güncellenmiştir.";
            labelUyarı.Visible = true;
        }
    }
}
