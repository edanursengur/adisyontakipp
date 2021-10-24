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
    public partial class frmMasalar : Form
    {
        genel gnl = new genel();
        public frmMasalar()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void cikis_Click(object sender, EventArgs e)
        {
            {
                /*  if (MessageBox.Show("Çıkmak istediğinize emin misiniz?",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                  {
                      Application.Exit();
                  }*/
            }
        }

        private void geridon_Click(object sender, EventArgs e)
        {
            frm_menu menu = new frm_menu();
            menu.Show();
        }

        private void masa1_Click(object sender, EventArgs e)
        {
            frm_siparis siparis = new frm_siparis();
            int uzunluk = masa1.Text.Length;

            genel.buttonValue = masa1.Text.Substring(uzunluk - 5, 5);
            genel.buttonName = masa1.Name;
            this.Close();
            siparis.ShowDialog();
        }

        private void masa2_Click(object sender, EventArgs e)
        {

            frm_siparis siparis = new frm_siparis();
            int uzunluk = masa2.Text.Length;

            genel.buttonValue = masa2.Text.Substring(uzunluk - 6, 6);
            genel.buttonName = masa2.Name;
            this.Close();
            siparis.ShowDialog();
        }

        private void masa4_Click(object sender, EventArgs e)
        {

            frm_siparis siparis = new frm_siparis();
            int uzunluk = masa4.Text.Length;

            genel.buttonValue = masa4.Text.Substring(uzunluk - 6, 6);
            genel.buttonName = masa4.Name;
            this.Close();
            siparis.ShowDialog();
        }

        private void masa5_Click(object sender, EventArgs e)
        {

            frm_siparis siparis = new frm_siparis();
            int uzunluk = masa5.Text.Length;

            genel.buttonValue = masa5.Text.Substring(uzunluk - 6, 6);
            genel.buttonName = masa5.Name;
            this.Close();
            siparis.ShowDialog();
        }

        private void masa6_Click(object sender, EventArgs e)
        {

            frm_siparis siparis = new frm_siparis();
            int uzunluk = masa6.Text.Length;

            genel.buttonValue = masa6.Text.Substring(uzunluk - 6, 6);
            genel.buttonName = masa6.Name;
            this.Close();
            siparis.ShowDialog();
        }

        private void masa3_Click(object sender, EventArgs e)
        {

            frm_siparis siparis = new frm_siparis();
            int uzunluk = masa3.Text.Length;

            genel.buttonValue = masa3.Text.Substring(uzunluk - 6, 6);
            genel.buttonName = masa3.Name;
            this.Close();
            siparis.ShowDialog();
        }

        private void frmMasalar_Load(object sender, EventArgs e)
        { 

                

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    }