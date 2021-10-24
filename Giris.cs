using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Giris : Form
    {
       
        genel gnl = new genel();
        public Giris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Personeller p = new Personeller();
            bool result = p.personelGirisKontrolu(txtSifre.Text, gnl._personel_Id);
            if (result)
            {
                PersonelHareketleri ch = new PersonelHareketleri();
                ch.PersonelId = gnl._personel_Id;
                ch.Islem = "Giriş Yaptı";
                ch.Tarih = DateTime.Now;
                ch.PersonelHareketKayit(ch);
                this.Hide();
                frm_menu menu = new frm_menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Şifreniz Yanlış", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        private void Giris_Load(object sender, EventArgs e)
        {
            Personeller p = new Personeller();
            p.personelbilgisial(cbKullanici);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "uyarı!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
