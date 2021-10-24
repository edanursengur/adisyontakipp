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


namespace WindowsFormsApp1
{
    public partial class SiparisAl : Form
    {
        int tableId;
        genel gnl = new genel();
        AraSicak arasicak = new AraSicak();
        EtYemekleri etyemekleri = new EtYemekleri();
        SuluYemek suluyemekler = new SuluYemek();
        SutluTatlilar sutlutatlilar = new SutluTatlilar();
        MeyveliTatlilar meyveltatlilar = new MeyveliTatlilar();
        SicakIcecek sicakicecek = new SicakIcecek();
        SogukIcecek sogukicecek = new SogukIcecek();


        public SiparisAl()
        {
            InitializeComponent();
        }




        private void SiparisAl_Load(object sender, EventArgs e)
        {
          

            btn1.Click += new EventHandler(islem);
            btn2.Click += new EventHandler(islem);
            btn3.Click += new EventHandler(islem);
            btn4.Click += new EventHandler(islem);
            btn5.Click += new EventHandler(islem);
            btn6.Click += new EventHandler(islem);
            btn7.Click += new EventHandler(islem);
            btn8.Click += new EventHandler(islem);
            btn9.Click += new EventHandler(islem);
            btn0.Click += new EventHandler(islem);

        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdet.Text = null;
        }
        //hesap
        void islem(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btn1":
                    txtAdet.Text += (1).ToString();
                    break;
                case "btn2":
                    txtAdet.Text += (2).ToString();
                    break;
                case "btn3":
                    txtAdet.Text += (3).ToString();
                    break;
                case "btn4":
                    txtAdet.Text += (4).ToString();
                    break;
                case "btn5":
                    txtAdet.Text += (5).ToString();
                    break;
                case "btn6":
                    txtAdet.Text += (6).ToString();
                    break;
                case "btn7":
                    txtAdet.Text += (7).ToString();
                    break;
                case "btn8":
                    txtAdet.Text += (8).ToString();
                    break;
                case "btn9":
                    txtAdet.Text += (9).ToString();
                    break;
                case "btn0":
                    txtAdet.Text += (0).ToString();
                    break;
                default:
                    MessageBox.Show("Sayı Gir");
                    break;
            }
        }
        int sayac = 0;
        private void lvMenu_DoubleClick(object sender, EventArgs e)
        {
            if (txtAdet.Text == "")
            {
                txtAdet.Text = "1";
            }
            if (lvMenu.Items.Count > 0)
            {
                sayac = lvSiparis.Items.Count;
                lvSiparis.Items.Add(lvMenu.SelectedItems[0].Text);
                lvSiparis.Items[sayac].SubItems.Add(lvMenu.SelectedItems[0].SubItems[2].Text);
                lvSiparis.Items[sayac].SubItems.Add((Convert.ToDecimal(lvMenu.SelectedItems[0].SubItems[1].Text) * Convert.ToDecimal(txtAdet.Text)).ToString());
                lvSiparis.Items[sayac].SubItems.Add(txtAdet.Text);
            }

        }

        private void btnSiparisAl_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(gnl.conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Satislar (UrunAd,UrunTur,UrunAdet,UrunFiyat,ToplamFiyat) values (@urunAdi,@urunTuru,@urunFiyati,@urunAdedi,@toplamFiyat)", con);
            cmd.Parameters.AddWithValue("@urunAdi", txtadi.Text);
            cmd.Parameters.AddWithValue("@urunTuru", txtturu.Text);
            cmd.Parameters.AddWithValue("@urunAdedi", Convert.ToString(txtadt.Text));
            cmd.Parameters.AddWithValue("@urunFiyati", Convert.ToString(txtfiyat.Text));
            cmd.Parameters.AddWithValue("@toplamFiyat", Convert.ToString(txttoplamfiyat.Text));
            cmd.ExecuteNonQuery();          
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                MessageBox.Show("Ekleme Başarılı");
              
            }
            con.Close();


        }



        private void lvSiparis_DoubleClick(object sender, EventArgs e)
        {

            if (lvSiparis.SelectedItems.Count > 0)
            {
                ListViewItem Item = lvSiparis.SelectedItems[0];

                txtadi.Text = Item.SubItems[0].Text;
                txtturu.Text = Item.SubItems[1].Text;
                txtadt.Text = Item.SubItems[2].Text;
                txtfiyat.Text = Item.SubItems[3].Text;


            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnArasicak_Click(object sender, EventArgs e)
        {
            arasicak.AraSicakCagir(lvMenu, btnArasicak);
        }

        private void btnEtYemekleri_Click(object sender, EventArgs e)
        {
            etyemekleri.EtYemekleriCagir(lvMenu, btnEtYemekleri);
        }

        private void btnSuluYemek_Click(object sender, EventArgs e)
        {
            suluyemekler.SuluYemekCagir(lvMenu, btnSuluYemek);
        }

        private void btnsutlutatli_Click(object sender, EventArgs e)
        {
            sutlutatlilar.SutluTatliCagir(lvMenu,btnsutlutatli);
        }

        private void btnmeyvelitatli_Click(object sender, EventArgs e)
        {
            meyveltatlilar.MeyveliTatliCagir(lvMenu,btnmeyvelitatli);
        }

        private void btnsogukicecek_Click(object sender, EventArgs e)
        {
            sogukicecek.SogukIcecekCagir(lvMenu,btnsogukicecek);
        }

        private void btnsicakicecek_Click(object sender, EventArgs e)
        {
            sicakicecek.SicakIcecekCagir(lvMenu,btnsicakicecek);
        }

        private void btnToplamHesapla_Click(object sender, EventArgs e)
        {
            Decimal topla = 0;
            for (int sayi = 0; sayi <= lvSiparis.Items.Count - 1; sayi++)

            {

                decimal sayi1;

                string sayi2;

                sayi2 = lvSiparis.Items[sayi].SubItems[2].Text;

                sayi1 = decimal.Parse(sayi2);

                topla = topla + sayi1;

            }

            txttoplamfiyat.Text = Convert.ToString(topla);
        }

        
    }
    }
