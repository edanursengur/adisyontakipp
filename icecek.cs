using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class icecek
    {
        genel gnl = new genel();
        public void icecekcagir(ListView cesitler, Button btn)
        {

            cesitler.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Urunler inner join Tur on Urunler.TurID=Tur.ID inner join Kategori on Urunler.KategoriID=Kategori.ID WHERE Tur.ID=2 ORDER BY Kategori.ID asc ";
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
        public void SogukIcecekCagir(ListView cesitler, Button btn)
        {

            cesitler.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Urunler inner join Tur on Urunler.TurId=Tur.ID inner join Kategori on Urunler.KategoriID=Kategori.ID WHERE Kategori.ID=7";

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
        public void SicakIcecekCagir(ListView cesitler, Button btn)
        {

            cesitler.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Urunler inner join Tur on Urunler.TurId=Tur.ID inner join Kategori on Urunler.KategoriID=Kategori.ID WHERE Kategori.ID=6";

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

    }
    class SogukIcecek : icecek
    {
        public SogukIcecek() { }
    }
    class SicakIcecek : icecek
    {
        public SicakIcecek() { }
    }
}
