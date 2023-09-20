using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiLatihanTiga3
{
    public partial class frmLatihanTiga3 : Form
    {
        public frmLatihanTiga3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            var nama = txtnama.Text;
            var pendidikan = cmbpendidikan.Text;
            var pekerjaan = lstpekerjaan.Text;

            txtpesan1.Text = string.Format("Hallo {0}", nama);
            txtpesan2.Text = string.Format("Pendidikan Anda {0} ya?", pendidikan);
            txtpesan3.Text = string.Format("Anda seorang {0} hebat!!!", pekerjaan);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtpesan1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstpekerjaan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbpendidikan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtnama_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
