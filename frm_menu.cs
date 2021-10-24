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
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void btn_masa_Click(object sender, EventArgs e)
        {
            frmMasalar masa = new frmMasalar();
            masa.Show();

        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            frmKasa kasa = new frmKasa();
            this.Close();
            kasa.Show();
        }

        private void btnMutfak_Click(object sender, EventArgs e)
        {
            frmMutfak mutfak = new frmMutfak();
            this.Close();
            mutfak.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
           
        }
    }
}
