using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_a_Car_Uygulaması
{
    public partial class frmadmin : Form
    {
        public frmadmin()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=DESKTOP-MONNBD4\\TEW_SQLEXPRESS;Initial Catalog=kullanicibilgileri;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

       

        private void btndon_Click(object sender, EventArgs e)
        {
          formgiris frmgiris = new formgiris();
            this.Close();
            frmgiris.Show();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string marka = tbmarka.Text;
            string model = tbmodel.Text;
            int yil = int.Parse(tbyil.Text);
            string sanziman = cbsanziman.SelectedItem.ToString();
            string yakitTuru = cbyakit.SelectedItem.ToString();
            string connectionString = "Data Source=DESKTOP-MONNBD4\\TEW_SQLEXPRESS;Initial Catalog=kullanicibilgileri;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO aracbilgileri (Marka, Model, Yil, Sanziman, YakitTuru) VALUES (@Marka, @Model, @Yil, @Sanziman, @YakitTuru)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Marka", marka);
                cmd.Parameters.AddWithValue("@Model", model);
                cmd.Parameters.AddWithValue("@Yil", yil);
                cmd.Parameters.AddWithValue("@Sanziman", sanziman);
                cmd.Parameters.AddWithValue("@YakitTuru", yakitTuru);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Araç başarıyla eklendi!");
                tbmarka.Clear();
                tbmodel.Clear();
                tbyil.Clear();
                cbsanziman.SelectedIndex = -1;
                cbyakit.SelectedIndex = -1;
            }
    }

        private void btnyenile_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT IlanID, YetkiliID, AracID, Fiyat, Aciklama, ResimYolu FROM kiralikaraclar WHERE OnayDurumu = 0", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvilanlar.DataSource = dt;
            }
        }


        
       

        private void frmadmin_Load(object sender, EventArgs e)
        {
            cbsanziman.Items.AddRange(new string[] { "Manuel", "Otomatik", "Yarı Otomatik" });
            cbyakit.Items.AddRange(new string[] { "Benzin", "Dizel", "Elektrik", "Hybrid" });
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT IlanID, YetkiliID, AracID, Fiyat, Aciklama, ResimYolu FROM kiralikaraclar WHERE OnayDurumu = 0", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvilanlar.DataSource = dt;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT IlanID, YetkiliID, AracID, Fiyat, Aciklama, ResimYolu FROM kiralikaraclar WHERE OnayDurumu = 1", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvonaylilar.DataSource = dt;
                conn.Close();
            }
        }

        private void btnonay_Click_1(object sender, EventArgs e)
        {
            if (dgvilanlar.SelectedRows.Count > 0)
            {
                int ilanID = Convert.ToInt32(dgvilanlar.SelectedRows[0].Cells["IlanID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE kiralikaraclar SET OnayDurumu = 1 WHERE IlanID = @IlanID", conn);
                    cmd.Parameters.AddWithValue("@IlanID", ilanID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("İlan başarıyla onaylandı!");
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT IlanID, YetkiliID, AracID, Fiyat, Aciklama, ResimYolu FROM kiralikaraclar WHERE OnayDurumu = 0", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvilanlar.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Lütfen onaylamak istediğiniz ilanı seçiniz.");
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (dgvilanlar.SelectedRows.Count > 0)
            {
                int ilanID = Convert.ToInt32(dgvilanlar.SelectedRows[0].Cells["IlanID"].Value);
                string resimYolu = dgvilanlar.SelectedRows[0].Cells["ResimYolu"].Value.ToString();


                DialogResult result = MessageBox.Show("Bu ilanı silmek istediğinize emin misiniz?", "İlan Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM kiralikaraclar WHERE IlanID = @IlanID", conn);
                        cmd.Parameters.AddWithValue("@IlanID", ilanID);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    // Resmi silme işlemi
                    if (System.IO.File.Exists(resimYolu))
                    {
                        System.IO.File.Delete(resimYolu);
                    }

                    MessageBox.Show("İlan başarıyla silindi!");
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlDataAdapter da = new SqlDataAdapter("SELECT IlanID, YetkiliID, AracID, Fiyat, Aciklama, ResimYolu FROM kiralikaraclar WHERE OnayDurumu = 0", conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvilanlar.DataSource = dt;
                    }
                }
                else
                {
                    MessageBox.Show("Silme işlemi iptal edildi.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz ilanı seçiniz.");
            }
        }

        private void dgvilanlar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvilanlar.SelectedRows.Count > 0)
            {
                string resimYolu = dgvilanlar.SelectedRows[0].Cells["ResimYolu"].Value.ToString();

                if (System.IO.File.Exists(resimYolu))
                {
                    pbresim.Image = Image.FromFile(resimYolu);
                }
                else
                {
                    pbresim.Image = null;
                }
            }
        }

        private void btnekle_Click_1(object sender, EventArgs e)
        {
            string marka = tbmarka.Text;
            string model = tbmodel.Text;
            int yil = int.Parse(tbyil.Text);
            string sanziman = cbsanziman.SelectedItem.ToString();
            string yakitTuru = cbyakit.SelectedItem.ToString();
            string connectionString = "Data Source=DESKTOP-MONNBD4\\TEW_SQLEXPRESS;Initial Catalog=kullanicibilgileri;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO aracbilgileri (Marka, Model, Yil, Sanziman, YakitTuru) VALUES (@Marka, @Model, @Yil, @Sanziman, @YakitTuru)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Marka", marka);
                cmd.Parameters.AddWithValue("@Model", model);
                cmd.Parameters.AddWithValue("@Yil", yil);
                cmd.Parameters.AddWithValue("@Sanziman", sanziman);
                cmd.Parameters.AddWithValue("@YakitTuru", yakitTuru);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Araç başarıyla eklendi!");
                tbmarka.Clear();
                tbmodel.Clear();
                tbyil.Clear();
                cbsanziman.SelectedIndex = -1;
                cbyakit.SelectedIndex = -1;
            }
        }

        private void dgvonaylilar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvonaylilar.SelectedRows.Count > 0)
            {
                string resimYolu = dgvonaylilar.SelectedRows[0].Cells["ResimYolu"].Value.ToString();

                if (System.IO.File.Exists(resimYolu))
                {
                    pbonayli.Image = Image.FromFile(resimYolu);
                }
                else
                {
                    pbonayli.Image = null;
                }
            }
        }
    }
}
