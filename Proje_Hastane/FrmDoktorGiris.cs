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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }

        SQLBaglantısı bgl = new SQLBaglantısı();

        private void FrmDoktorGiris_Load(object sender, EventArgs e)
        {
        }

        private void buttongiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar Where DoktorTC=@p1 and DoktorSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay doktordetay = new FrmDoktorDetay();
                doktordetay.TC = MskTC.Text;
                doktordetay.Show();
                this.Hide();
            }
            else
            {
                labeluyarı.Text = "Hatalı TC Kimlik numarası \nveya şifre";
                labeluyarı.Visible = true;
                labeluyarı.ForeColor = Color.Red;
            }
            bgl.baglanti().Close();
        }
    }
    
}
