using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_a_Car_Uygulaması
{
    public partial class frmkurumsal : Form
    {
        public frmkurumsal()
        {
            InitializeComponent();
            lblhosgeldiniz.Text = $"Sayın {kullanicibilgileridegeleri.isim} Hoşgeldiniz.";
        }
        string connectionString = "Data Source=DESKTOP-MONNBD4\\TEW_SQLEXPRESS;Initial Catalog=kullanicibilgileri;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MONNBD4\\TEW_SQLEXPRESS;Initial Catalog=kullanicibilgileri;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");

        private void btncikis_Click(object sender, EventArgs e)
        {
            kullanicibilgileridegeleri.kullaniciadi = null;
            kullanicibilgileridegeleri.sifre = null;
            kullanicibilgileridegeleri.isim = null;
            kullanicibilgileridegeleri.soyisim = null;
            kullanicibilgileridegeleri.mail = null;
            kullanicibilgileridegeleri.telefon = -1;

            formgiris frmgiris = new formgiris();
            this.Close();
            frmgiris.Show();
        }

        private void btnilanekle_Click(object sender, EventArgs e)
        {
            //frmilanekle frmilanekle = new frmilanekle();
            //this.Hide();
            //frmilanekle.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbmarka.SelectedIndex == -1 || cbmodel.SelectedIndex == -1 || cbyil.SelectedIndex == -1 ||
        cbsanziman.SelectedIndex == -1 || cbyakit.SelectedIndex == -1 || string.IsNullOrEmpty(tbfiyat.Text) ||
        string.IsNullOrEmpty(tbaciklama.Text) || pbresim.ImageLocation == null)
            {
                MessageBox.Show("Tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=DESKTOP-MONNBD4\\TEW_SQLEXPRESS;Initial Catalog=kullanicibilgileri;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

            int aracID = GetSelectedAracID(cbmarka.Text, cbmodel.Text, cbyil.Text, cbsanziman.Text, cbyakit.Text);

            if (aracID == -1)
            {
                MessageBox.Show("Araç bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string resimlerKlasoru = Path.Combine(Application.StartupPath, "Resimler");
            if (!Directory.Exists(resimlerKlasoru))
            {
                Directory.CreateDirectory(resimlerKlasoru);
            }

            string yeniResimAdi = Guid.NewGuid().ToString() + Path.GetExtension(pbresim.ImageLocation);
            string hedefYol = Path.Combine(resimlerKlasoru, yeniResimAdi);

            File.Copy(pbresim.ImageLocation, hedefYol, true);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"INSERT INTO kiralikaraclar (AracID, YetkiliID, Fiyat, ResimYolu, Aciklama, OnayDurumu)
                         VALUES (@AracID, @YetkiliID, @Fiyat, @ResimYolu, @Aciklama, 0)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@AracID", aracID);
                cmd.Parameters.AddWithValue("@YetkiliID", kullanicibilgileridegeleri.YetkiliID);
                cmd.Parameters.AddWithValue("@Fiyat", decimal.Parse(tbfiyat.Text));
                cmd.Parameters.AddWithValue("@ResimYolu", "Resimler\\" + yeniResimAdi);
                cmd.Parameters.AddWithValue("@Aciklama", tbaciklama.Text);

                cmd.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("İlan başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmkurumsal_Load(object sender, EventArgs e)
        {
            MarkaDoldur();
            ListeleKiralamaGecmisi();
            KiralananAraclariListele();
        }
        private int GetSelectedAracID(string marka, string model, string yil, string sanziman, string yakit)
        {
            int id = -1;
            string connectionString = "Data Source=DESKTOP-MONNBD4\\TEW_SQLEXPRESS;Initial Catalog=kullanicibilgileri;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"SELECT AracID FROM aracbilgileri 
                         WHERE marka = @marka AND model = @model AND yil = @yil 
                         AND sanziman = @sanziman AND YakitTuru = @yakit";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@marka", marka);
                cmd.Parameters.AddWithValue("@model", model);
                cmd.Parameters.AddWithValue("@yil", yil);
                cmd.Parameters.AddWithValue("@sanziman", sanziman);
                cmd.Parameters.AddWithValue("@yakit", yakit);

                var result = cmd.ExecuteScalar();
                if (result != null)
                    id = Convert.ToInt32(result);
                con.Close();
            }

            return id;
        }
        private void KiralananAraclariListele()
        {
            try
            {
                conn.Open();
                string query = @"
    SELECT 
        k.IlanId,
        a.Marka,
        a.Model,
        a.Yil,
        kr.KiralamaBaslangicTarihi,
        kr.KiralamaBitisTarihi,
        u.isim + ' ' + u.soyisim AS Kiralayan,
        u.mail AS Email,
        u.telefon AS Telefon
    FROM kiralamalar kr
    INNER JOIN kiralikaraclar k ON kr.IlanId = k.IlanId
    INNER JOIN aracbilgileri a ON k.AracId = a.AracId
    INNER JOIN kullanicigirisi u ON kr.KullaniciID = u.id
    WHERE k.YetkiliID = @YetkiliID
    ORDER BY kr.KiralamaBaslangicTarihi DESC";


                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@YetkiliID", kullanicibilgileridegeleri.YetkiliID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvKiralamaGecmisi.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler alınamadı: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void Temizle()
        {
            cbmarka.SelectedIndex = -1;
            cbmodel.SelectedIndex = -1;
            cbyil.SelectedIndex = -1;
            cbsanziman.SelectedIndex = -1;
            cbyakit.SelectedIndex = -1;
            tbfiyat.Clear();
            tbaciklama.Clear();
            pbresim.ImageLocation = null;
        }

        private void btnresimsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbresim.ImageLocation = ofd.FileName;
            }
        }

        private void cbmarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbmodel.Items.Clear();
            cbyil.Items.Clear();
            cbsanziman.Items.Clear();
            cbyakit.Items.Clear();

            string secilenMarka = cbmarka.SelectedItem?.ToString();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT model FROM aracbilgileri WHERE marka = @marka", con);
                cmd.Parameters.AddWithValue("@marka", secilenMarka);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbmodel.Items.Add(dr["model"].ToString());
                }
                dr.Close();
            }
        }

        private void cbmodel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbyil.Items.Clear();
            cbsanziman.Items.Clear();
            cbyakit.Items.Clear();

            string secilenMarka = cbmarka.SelectedItem?.ToString();
            string secilenModel = cbmodel.SelectedItem?.ToString();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT yil FROM aracbilgileri WHERE marka = @marka AND model = @model", con);
                cmd.Parameters.AddWithValue("@marka", secilenMarka);
                cmd.Parameters.AddWithValue("@model", secilenModel);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbyil.Items.Add(dr["yil"].ToString());
                }
                dr.Close();
            }
        }

        private void cbyil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbsanziman.Items.Clear();
            cbyakit.Items.Clear();

            string secilenMarka = cbmarka.SelectedItem?.ToString();
            string secilenModel = cbmodel.SelectedItem?.ToString();
            string secilenYil = cbyil.SelectedItem?.ToString();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT sanziman FROM aracbilgileri WHERE marka = @marka AND model = @model AND yil = @yil", con);
                cmd.Parameters.AddWithValue("@marka", secilenMarka);
                cmd.Parameters.AddWithValue("@model", secilenModel);
                cmd.Parameters.AddWithValue("@yil", secilenYil);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbsanziman.Items.Add(dr["sanziman"].ToString());
                }
                dr.Close();
            }
        }

        private void cbsanziman_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbyakit.Items.Clear();

            string secilenMarka = cbmarka.SelectedItem?.ToString();
            string secilenModel = cbmodel.SelectedItem?.ToString();
            string secilenYil = cbyil.SelectedItem?.ToString();
            string secilenSanziman = cbsanziman.SelectedItem?.ToString();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT YakitTuru FROM aracbilgileri WHERE marka = @marka AND model = @model AND yil = @yil AND sanziman = @sanziman", con);
                cmd.Parameters.AddWithValue("@marka", secilenMarka);
                cmd.Parameters.AddWithValue("@model", secilenModel);
                cmd.Parameters.AddWithValue("@yil", secilenYil);
                cmd.Parameters.AddWithValue("@sanziman", secilenSanziman);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbyakit.Items.Add(dr["YakitTuru"].ToString());
                }
                dr.Close();
            }
        }
        private void MarkaDoldur()
        {
            cbmarka.Items.Clear();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT marka FROM aracbilgileri", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbmarka.Items.Add(dr["marka"].ToString());
                }
                dr.Close();
            }
        }
        private void ListeleKiralamaGecmisi()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(@"
        SELECT 
            k.KiralamaID,
            ka.IlanID,
            kg.isim + ' ' + kg.soyisim AS KiralayanKisi,
            ka.Aciklama,
            ka.Fiyat,
            k.KiralamaBaslangicTarihi,
            k.KiralamaBitisTarihi
        FROM kiralamalar k
        JOIN kiralikaraclar ka ON k.AracID = ka.AracID
        JOIN kullanicigirisi kg ON k.KullaniciID = kg.id
        WHERE ka.YetkiliID = @YetkiliID", conn);

            cmd.Parameters.AddWithValue("@YetkiliID", kullanicibilgileridegeleri.YetkiliID); // Oturum açan şirketin ID’si

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKiralama.DataSource = dt;

            conn.Close();
        }
    }
}
