using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_a_Car_Uygulaması
{
    public partial class frmkullanici : Form
    {
        public frmkullanici()
        {
            InitializeComponent();
            lblhosgeldiniz.Text = $"Sayın {kullanicibilgileridegeleri.isim} Hoşgeldiniz.";
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MONNBD4\\TEW_SQLEXPRESS;Initial Catalog=kullanicibilgileri;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
        DataTable araclarTable = new DataTable();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-MONNBD4\TEW_SQLEXPRESS;Initial Catalog=kullanicibilgileri;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
        string connectionString = "Data Source=DESKTOP-MONNBD4\\TEW_SQLEXPRESS;Initial Catalog=kullanicibilgileri;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        
        private void btndon_Click(object sender, EventArgs e)
        {
            kullanicibilgileridegeleri.kullaniciadi = null;
            kullanicibilgileridegeleri.sifre = null;
            kullanicibilgileridegeleri.isim = null;
            kullanicibilgileridegeleri.soyisim = null;
            kullanicibilgileridegeleri.mail = null;
            kullanicibilgileridegeleri.telefon = -1;
            formgiris formgiris = new formgiris();
            this.Close();
            formgiris.Show();

            // grişe döndüğü zaman classtaki tüm değerleri siler
        }

        private void btngoster_Click(object sender, EventArgs e)
        {
            AraclariListele();

        }
        private void AraclariListele()
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }

                DateTime baslangic = dtpBaslangicTarihi.Value.Date;
                DateTime bitis = dtpBitisTarihi.Value.Date;
                string secilenMarka = cbMarka.SelectedItem?.ToString();

                // SQL sorgusu
                string query = @"
            SELECT 
                a.Marka,
                a.Model,
                a.Yil,
                a.Sanziman,
                a.YakitTuru,
                k.Fiyat,
                k.Aciklama,
                k.IlanId,
                k.ResimYolu,
                a.AracID
            FROM kiralikaraclar k
            INNER JOIN aracbilgileri a ON k.AracId = a.AracId
            WHERE k.OnayDurumu = 1
            AND k.IlanId NOT IN (
                SELECT kr.IlanId
                FROM kiralamalar kr
                WHERE (
                    (@Baslangic BETWEEN kr.KiralamaBaslangicTarihi AND kr.KiralamaBitisTarihi)
                    OR (@Bitis BETWEEN kr.KiralamaBaslangicTarihi AND kr.KiralamaBitisTarihi)
                    OR (kr.KiralamaBaslangicTarihi BETWEEN @Baslangic AND @Bitis)
                    OR (kr.KiralamaBitisTarihi BETWEEN @Baslangic AND @Bitis)
                )
            )";

                
                if (!string.IsNullOrEmpty(secilenMarka) && secilenMarka != "Tüm Markalar")
                {
                    query += " AND a.Marka = @Marka";
                }

                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.Parameters.AddWithValue("@Baslangic", baslangic);
                komut.Parameters.AddWithValue("@Bitis", bitis);

                if (!string.IsNullOrEmpty(secilenMarka) && secilenMarka != "Tüm Markalar")
                {
                    komut.Parameters.AddWithValue("@Marka", secilenMarka);
                }

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvaraclar.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Araçları listelerken hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            // Tüm araçları listeler markalar seçilirse o marka listelenir.(O tarihte kiralanmamış araçlar için)
        }


       

        private void btnkirala_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvaraclar.SelectedRows.Count > 0)
                {
                    int ilanId = Convert.ToInt32(dgvaraclar.SelectedRows[0].Cells[0].Value);
                    int aracId = Convert.ToInt32(dgvaraclar.SelectedRows[0].Cells[9].Value);
                    DateTime baslangicTarihi = dtpBaslangicTarihi.Value;
                    DateTime bitisTarihi = dtpBitisTarihi.Value;
                    int kullaniciId = Convert.ToInt32(kullanicibilgileridegeleri.YetkiliID);





                    string kiralamaQuery = @"
INSERT INTO kiralamalar (IlanId, AracId, KiralamaBaslangicTarihi, KiralamaBitisTarihi, KullaniciId)
VALUES (@IlanId, @AracId, @BaslangicTarihi, @BitisTarihi, @KullaniciId)";


                    SqlCommand kiralamaCmd = new SqlCommand(kiralamaQuery, conn);


                    kiralamaCmd.Parameters.AddWithValue("@IlanId", ilanId);
                    kiralamaCmd.Parameters.AddWithValue("@AracId", aracId);
                    kiralamaCmd.Parameters.AddWithValue("@BaslangicTarihi", baslangicTarihi);
                    kiralamaCmd.Parameters.AddWithValue("@BitisTarihi", bitisTarihi);
                    kiralamaCmd.Parameters.AddWithValue("@KullaniciId", kullaniciId);


                    conn.Open();
                    kiralamaCmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Araç kiralama işlemi başarılı.");
                    AraclariListele();
                }
                else
                {
                    MessageBox.Show("Lütfen bir araç seçin.");
                }
            }
            finally
            {
                conn.Close();
            }
            // Aracı kiralar database ekler.
        }

        private void frmkullanici_Load(object sender, EventArgs e)
        {
           
            MarkaListele();
        }
        private void MarkaListele()
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                using (SqlCommand komut = new SqlCommand("SELECT DISTINCT Marka FROM aracbilgileri", baglanti))
                using (SqlDataReader dr = komut.ExecuteReader())
                {
                    cbMarka.Items.Clear();
                    cbMarka.Items.Add("Tüm Markalar");

                    while (dr.Read())
                    {
                        cbMarka.Items.Add(dr["Marka"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Marka listelenirken hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }



        private void cbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            AraclariListele();
        }

        private void dgvaraclar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvaraclar.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvaraclar.SelectedRows[0];
                frmAracDetay frm = new frmAracDetay(selectedRow);
                frm.ShowDialog();
            }
            // seçilen aracı yeni formda gösterir.
        }
    }
}
