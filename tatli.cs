using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    class tatli
    {
        genel gnl = new genel();
        public void tatlicagir(ListView cesitler, Button btn)
        {

            cesitler.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM URUNLER inner join tur on URUNLER.TURID=tur.ID inner join kategori on URUNLER.KategoriID=kategori.ID WHERE tur.ID=1 ORDER BY kategori.ID asc ";
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                cesitler.Items.Add(dr["UrunAd"].ToString());
                cesitler.Items[i].SubItems.Add(dr["UrunFiyat"].ToString());
                cesitler.Items[i].SubItems.Add(dr["KategoriAd"].ToString());
                cesitler.Items[i].SubItems.Add(dr["StokMiktar"].ToString());
                i++;
            }
            con.Close();
            con.Dispose();
            con.Close();

        }
        public void SutluTatliCagir(ListView cesitler, Button btn)
        {

            cesitler.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Urunler inner join Tur on Urunler.TurId=Tur.ID inner join Kategori on Urunler.KategoriID=Kategori.ID WHERE Kategori.ID=4";

            SqlDataReader dr = cmd.ExecuteReader();

            int i = 0;
            while (dr.Read())
            {
                cesitler.Items.Add(dr["UrunAd"].ToString());
                cesitler.Items[i].SubItems.Add(dr["UrunFiyat"].ToString());
                cesitler.Items[i].SubItems.Add(dr["KategoriAd"].ToString());
                cesitler.Items[i].SubItems.Add(dr["StokMiktar"].ToString());
                i++;
            }
            con.Close();
            con.Dispose();
            con.Close();

        }
        public void MeyveliTatliCagir(ListView cesitler, Button btn)
        {

            cesitler.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Urunler inner join Tur on Urunler.TurId=Tur.ID inner join Kategori on Urunler.KategoriID=Kategori.ID WHERE Kategori.ID=5";

            SqlDataReader dr = cmd.ExecuteReader();

            int i = 0;
            while (dr.Read())
            {
                cesitler.Items.Add(dr["UrunAd"].ToString());
                cesitler.Items[i].SubItems.Add(dr["UrunFiyat"].ToString());
                cesitler.Items[i].SubItems.Add(dr["KategoriAd"].ToString());
                cesitler.Items[i].SubItems.Add(dr["StokMiktar"].ToString());
                i++;
            }
            con.Close();
            con.Dispose();
            con.Close();

        }
        /*public int stokHesapla(int müsterininistedigiadet) {

}*/

    }
    class SutluTatlilar : tatli
    {
        public SutluTatlilar(){ }
    }
    class MeyveliTatlilar : tatli
    {
        public MeyveliTatlilar() { }
    }
}