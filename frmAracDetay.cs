using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_a_Car_Uygulaması
{
    public partial class frmAracDetay : Form
    {
        public frmAracDetay(DataGridViewRow selectedRow)
        {
            InitializeComponent();
            lblMarka.Text = selectedRow.Cells["Marka"].Value.ToString();
            lblModel.Text = selectedRow.Cells["Model"].Value.ToString();
            lblFiyat.Text = selectedRow.Cells["Fiyat"].Value.ToString();
            lblYil.Text = selectedRow.Cells["Yil"].Value.ToString();
            lblYakit.Text = selectedRow.Cells["YakitTuru"].Value.ToString();
            lblSanziman.Text = selectedRow.Cells["Sanziman"].Value.ToString();
            lblAciklama.Text = selectedRow.Cells["Aciklama"].Value.ToString();

            string resimYolu = selectedRow.Cells["ResimYolu"].Value.ToString();
            if (System.IO.File.Exists(resimYolu))
            {
                pbAracResim.Image = Image.FromFile(resimYolu);
            }
            // Araç bilgilerini getirir.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmkullanici frmkullanici = new frmkullanici();
            this.Close();
            frmkullanici.Show();
        }

        private void btnkirala_Click(object sender, EventArgs e)
        {

        }

        private void btnkirala_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
