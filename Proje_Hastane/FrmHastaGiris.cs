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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        SQLBaglantısı bgl = new SQLBaglantısı();

        private void üyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayıt hastakayıt = new FrmHastaKayıt();
            hastakayıt.Show();
            //this.Hide();
        }

        private void buttongiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar Where HastaTC=@p1 and HastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmHastaDetay hastadetay = new FrmHastaDetay();
                hastadetay.TC = MskTC.Text;
                hastadetay.Show();
                this.Hide();
            }
            else
            {
                labeluyarı.Text = "Hatalı TC Kimlik numarası veya şifre";
                labeluyarı.Visible = true;
                labeluyarı.ForeColor = Color.Red;
            }
            bgl.baglanti().Close();


        }

        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
