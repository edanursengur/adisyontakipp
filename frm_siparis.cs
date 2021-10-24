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
    public partial class frm_siparis : Form
    {
        genel gnl = new genel();
        yemek ymk = new yemek();
        tatli tatli = new tatli();
        icecek icecek = new icecek();
      
        public frm_siparis()
        {
            InitializeComponent();
        }

        private void frm_siparis_Load(object sender, EventArgs e)
        {

        }

        private void btnanayemek_Click(object sender, EventArgs e)
        {
            ymk.anayemekcagir(lvMenu,btnanayemek);
        }

        private void btnTatli_Click(object sender, EventArgs e)
        {
            tatli.tatlicagir(lvMenu,btnTatli);
        }

        private void btnIcecek_Click(object sender, EventArgs e)
        {
            icecek.icecekcagir(lvMenu, btnIcecek);
        }

        private void btnSiparisFrm_Click(object sender, EventArgs e)
        {
            SiparisAl sa = new SiparisAl();
            sa.Show();

        }
    }
    }
