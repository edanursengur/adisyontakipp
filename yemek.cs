using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class yemek
    {

        genel gnl = new genel();
        private string _Ad;
        private string _Tur;
        private int _Fiyat;
        private int _StokAdet;

        public string Ad { get => _Ad; set => _Ad = value; }
        public string Tur { get => _Tur; set => _Tur = value; }
        public int Fiyat { get => _Fiyat; set => _Fiyat = value; }
        public int StokAdet { get => _StokAdet; set => _StokAdet = value; }

        public yemek() { }
        public yemek(string Ad, string Tur, int Fiyat, int StokAdet) {
            Ad = this.Ad;
            Tur = this.Tur;
            Fiyat = this.Fiyat;
            StokAdet = this.StokAdet;
        }

          public void anayemekcagir(ListView cesitler, Button btn)
         {

             cesitler.Items.Clear();
             SqlConnection con = new SqlConnection(gnl.conString);
             SqlCommand cmd = new SqlCommand();
             con.Open();
             cmd.Connection = con;
             cmd.CommandText = "SELECT * FROM Urunler inner join Tur on Urunler.TurId=Tur.ID inner join Kategori on Urunler.KategoriID=Kategori.ID WHERE Tur.ID=3 ORDER BY Kategori.ID asc ";

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
        public void EtYemekleriCagir(ListView cesitler, Button btn)
        {
            cesitler.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Urunler inner join Tur on Urunler.TurId=Tur.ID inner join Kategori on Urunler.KategoriID=Kategori.ID WHERE Kategori.ID=1";
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

       
        public void AraSicakCagir(ListView cesitler, Button btn)
        {

            cesitler.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Urunler inner join Tur on Urunler.TurId=Tur.ID inner join Kategori on Urunler.KategoriID=Kategori.ID WHERE Kategori.ID=2";

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
        public void SuluYemekCagir(ListView cesitler, Button btn)
        {

            cesitler.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Urunler inner join Tur on Urunler.TurId=Tur.ID inner join Kategori on Urunler.KategoriID=Kategori.ID WHERE Kategori.ID=3";

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
    class SuluYemek : yemek
    {
        public SuluYemek() { }
    }
    class AraSicak : yemek
    {
        public AraSicak() { }
    }
    class EtYemekleri : yemek
    {
        public EtYemekleri() { }
    }
}