using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace Rent_a_Car_Uygulaması
{
    public partial class formgiris : Form
    {


        public formgiris()
        {
            InitializeComponent();

        }
        //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-MONNBD4\TEW_SQLEXPRESS;Initial Catalog=kullanicibilgileri;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
        string connectionString = "Data Source=DESKTOP-MONNBD4\\TEW_SQLEXPRESS;Initial Catalog=kullanicibilgileri;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";


        private void btnkol_Click(object sender, EventArgs e)
        {
            Form frm = new frmkayit();
            this.Hide();
            frm.ShowDialog();


        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            kullanicibilgileridegeleri.kullaniciadi = null;
            kullanicibilgileridegeleri.sifre = null;
            kullanicibilgileridegeleri.isim = null;
            kullanicibilgileridegeleri.soyisim = null;
            kullanicibilgileridegeleri.mail = null;
            kullanicibilgileridegeleri.telefon = -1;
            kullanicibilgileridegeleri.YetkiliID = -1;
            Application.Exit();

        }

        private void btnkgirisi_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from kullanicigirisi where kullaniciadi = '" + tbkadi.Text + "' and sifre = '" + tbsifre.Text + "'", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                if (dr.Read())
                {

                    if (checkBox1.Checked)
                    {

                        Properties.Settings.Default.KullaniciAdi = tbkadi.Text;
                        Properties.Settings.Default.Sifre = tbsifre.Text;
                        Properties.Settings.Default.BeniHatirla = true;

                    }
                    else
                    {
                        Properties.Settings.Default.KullaniciAdi = "";
                        Properties.Settings.Default.Sifre = "";
                        Properties.Settings.Default.BeniHatirla = false;
                    }

                    Properties.Settings.Default.Save();

                    kullanicibilgileridegeleri.kullaniciadi = dr["kullaniciadi"].ToString();
                    kullanicibilgileridegeleri.sifre = dr["sifre"].ToString();
                    kullanicibilgileridegeleri.isim = dr["isim"].ToString();
                    kullanicibilgileridegeleri.soyisim = dr["soyisim"].ToString();
                    kullanicibilgileridegeleri.mail = dr["mail"].ToString();
                    kullanicibilgileridegeleri.YetkiliID = Convert.ToInt32(dr["id"]);
                    this.Hide();
                    Form form = new frmkullanici();
                    form.Show();
                    tbkadi.Clear();
                    tbsifre.Clear();
                    if (checkBox1.Checked)
                    {
                        kullanicibilgileridegeleri.bhkadi = kullanicibilgileridegeleri.kullaniciadi;
                        kullanicibilgileridegeleri.bhsifre = kullanicibilgileridegeleri.sifre;
                    }
                    else
                    {
                        kullanicibilgileridegeleri.bhkadi = null;
                        kullanicibilgileridegeleri.bhsifre = null;
                    }
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
                }
            }
        }


        private void btnpgirisi_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from yetkiligirisi where kullaniciadi = '" + tbkadi.Text + "' and sifre = '" + tbsifre.Text + "'", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    if (checkBox1.Checked)
                    {

                        Properties.Settings.Default.KullaniciAdi = tbkadi.Text;
                        Properties.Settings.Default.Sifre = tbsifre.Text;
                        Properties.Settings.Default.BeniHatirla = true;

                    }
                    else
                    {
                        Properties.Settings.Default.KullaniciAdi = "";
                        Properties.Settings.Default.Sifre = "";
                        Properties.Settings.Default.BeniHatirla = false;
                    }

                    Properties.Settings.Default.Save();
                    kullanicibilgileridegeleri.kullaniciadi = dr["kullaniciadi"].ToString();
                    kullanicibilgileridegeleri.sifre = dr["sifre"].ToString();
                    kullanicibilgileridegeleri.isim = dr["isim"].ToString();
                    kullanicibilgileridegeleri.soyisim = dr["soyisim"].ToString();
                    kullanicibilgileridegeleri.mail = dr["mail"].ToString();
                    kullanicibilgileridegeleri.telefon = Convert.ToInt64(dr["telefon"]);
                    kullanicibilgileridegeleri.YetkiliID = Convert.ToInt64(dr["id"]);
                    this.Hide();
                    Form form = new frmkurumsal();
                    form.Show();

                    tbkadi.Clear();
                    tbsifre.Clear();
                    if (checkBox1.Checked)
                    {
                        kullanicibilgileridegeleri.bhkadi = kullanicibilgileridegeleri.kullaniciadi;
                        kullanicibilgileridegeleri.bhsifre = kullanicibilgileridegeleri.sifre;
                    }
                    else
                    {
                        kullanicibilgileridegeleri.bhkadi = null;
                        kullanicibilgileridegeleri.bhsifre = null;
                    }
                    baglanti.Close();

                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
                }
            }

        }

        private void btnagirisi_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("Select * from admingirisi where kullaniciadi = '" + tbkadi.Text + "' and sifre = '" + tbsifre.Text + "'", baglanti);
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    if (checkBox1.Checked)
                    {

                        Properties.Settings.Default.KullaniciAdi = tbkadi.Text;
                        Properties.Settings.Default.Sifre = tbsifre.Text;
                        Properties.Settings.Default.BeniHatirla = true;

                    }
                    else
                    {
                        Properties.Settings.Default.KullaniciAdi = "";
                        Properties.Settings.Default.Sifre = "";
                        Properties.Settings.Default.BeniHatirla = false;
                    }

                    Properties.Settings.Default.Save();
                    this.Hide();
                    Form form = new frmadmin();
                    form.Show();
                    tbkadi.Clear();
                    tbsifre.Clear();
                    if (checkBox1.Checked)
                    {
                        kullanicibilgileridegeleri.bhkadi = kullanicibilgileridegeleri.kullaniciadi;
                        kullanicibilgileridegeleri.bhsifre = kullanicibilgileridegeleri.sifre;
                    }
                    else
                    {
                        kullanicibilgileridegeleri.bhkadi = null;
                        kullanicibilgileridegeleri.bhsifre = null;
                    }
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                kullanicibilgileridegeleri.bhkadi = kullanicibilgileridegeleri.kullaniciadi;
                kullanicibilgileridegeleri.bhsifre = kullanicibilgileridegeleri.sifre;
            }
        }

        private void frmgiris_Load(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.BeniHatirla)
            {
                tbkadi.Text = Properties.Settings.Default.KullaniciAdi;
                tbsifre.Text = Properties.Settings.Default.Sifre;
                checkBox1.Checked = true;
            }
            if (tbsifre.Text == Properties.Settings.Default.Sifre)
            {
                tbsifre.PasswordChar = '*';
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox2.Checked)
            {
                tbsifre.PasswordChar = '*';
            }
            else
            {
                tbsifre.PasswordChar = '\0';
            }
        }

        private void tbkadi_Enter(object sender, EventArgs e)
        {
            if (tbkadi.Text == "Nickname")
            {
                tbkadi.Text = "";
                tbkadi.ForeColor = Color.White;
            }
        }

        private void tbkadi_Leave(object sender, EventArgs e)
        {
            if (tbkadi.Text == "")
            {
                tbkadi.Text = "Nickname";
                tbkadi.ForeColor = Color.Silver;
            }
        }

        private void tbsifre_Enter(object sender, EventArgs e)
        {

            if (tbsifre.Text == "Password")
            {
                tbsifre.Text = "";
                tbsifre.ForeColor = Color.White;
                tbsifre.PasswordChar = '*';
            }

        }

        private void tbsifre_Leave(object sender, EventArgs e)
        {
            if (tbsifre.Text == "")
            {
                tbsifre.Text = "Password";
                tbsifre.ForeColor = Color.Silver;
                tbsifre.PasswordChar = '\0';
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                kullanicibilgileridegeleri.bhkadi = kullanicibilgileridegeleri.kullaniciadi;
                kullanicibilgileridegeleri.bhsifre = kullanicibilgileridegeleri.sifre;
            }

        }

        private void btnkol_Click_1(object sender, EventArgs e)
        {
            Form frm = new frmkayit();
            this.Hide();
            frm.ShowDialog();
            /*kullanicibilgileridegeleri.kullaniciadi = null;
            kullanicibilgileridegeleri.sifre = null;
            kullanicibilgileridegeleri.isim = null;
            kullanicibilgileridegeleri.soyisim = null;
            kullanicibilgileridegeleri.mail = null;
            kullanicibilgileridegeleri.telefon = -1;
            kullanicibilgileridegeleri.YetkiliID = -1;
            Application.Exit();*/

        }

        private void btncikis_Click_1(object sender, EventArgs e)
        {
            

        }

        private void btnkgirisi_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from kullanicigirisi where kullaniciadi = '" + tbkadi.Text + "' and sifre = '" + tbsifre.Text + "'", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                if (dr.Read())
                {

                    if (checkBox1.Checked)
                    {

                        Properties.Settings.Default.KullaniciAdi = tbkadi.Text;
                        Properties.Settings.Default.Sifre = tbsifre.Text;
                        Properties.Settings.Default.BeniHatirla = true;

                    }
                    else
                    {
                        Properties.Settings.Default.KullaniciAdi = "";
                        Properties.Settings.Default.Sifre = "";
                        Properties.Settings.Default.BeniHatirla = false;
                    }

                    Properties.Settings.Default.Save();

                    kullanicibilgileridegeleri.kullaniciadi = dr["kullaniciadi"].ToString();
                    kullanicibilgileridegeleri.sifre = dr["sifre"].ToString();
                    kullanicibilgileridegeleri.isim = dr["isim"].ToString();
                    kullanicibilgileridegeleri.soyisim = dr["soyisim"].ToString();
                    kullanicibilgileridegeleri.mail = dr["mail"].ToString();
                    kullanicibilgileridegeleri.YetkiliID = Convert.ToInt32(dr["id"]);
                    this.Hide();
                    Form form = new frmkullanici();
                    form.Show();
                    tbkadi.Clear();
                    tbsifre.Clear();
                    if (checkBox1.Checked)
                    {
                        kullanicibilgileridegeleri.bhkadi = kullanicibilgileridegeleri.kullaniciadi;
                        kullanicibilgileridegeleri.bhsifre = kullanicibilgileridegeleri.sifre;
                    }
                    else
                    {
                        kullanicibilgileridegeleri.bhkadi = null;
                        kullanicibilgileridegeleri.bhsifre = null;
                    }
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
                }
            }

        }

        private void btnpgirisi_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from yetkiligirisi where kullaniciadi = '" + tbkadi.Text + "' and sifre = '" + tbsifre.Text + "'", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    if (checkBox1.Checked)
                    {

                        Properties.Settings.Default.KullaniciAdi = tbkadi.Text;
                        Properties.Settings.Default.Sifre = tbsifre.Text;
                        Properties.Settings.Default.BeniHatirla = true;

                    }
                    else
                    {
                        Properties.Settings.Default.KullaniciAdi = "";
                        Properties.Settings.Default.Sifre = "";
                        Properties.Settings.Default.BeniHatirla = false;
                    }

                    Properties.Settings.Default.Save();
                    kullanicibilgileridegeleri.kullaniciadi = dr["kullaniciadi"].ToString();
                    kullanicibilgileridegeleri.sifre = dr["sifre"].ToString();
                    kullanicibilgileridegeleri.isim = dr["isim"].ToString();
                    kullanicibilgileridegeleri.soyisim = dr["soyisim"].ToString();
                    kullanicibilgileridegeleri.mail = dr["mail"].ToString();
                    kullanicibilgileridegeleri.telefon = Convert.ToInt64(dr["telefon"]);
                    kullanicibilgileridegeleri.YetkiliID = Convert.ToInt64(dr["id"]);
                    this.Hide();
                    Form form = new frmkurumsal();
                    form.Show();

                    tbkadi.Clear();
                    tbsifre.Clear();
                    if (checkBox1.Checked)
                    {
                        kullanicibilgileridegeleri.bhkadi = kullanicibilgileridegeleri.kullaniciadi;
                        kullanicibilgileridegeleri.bhsifre = kullanicibilgileridegeleri.sifre;
                    }
                    else
                    {
                        kullanicibilgileridegeleri.bhkadi = null;
                        kullanicibilgileridegeleri.bhsifre = null;
                    }
                    baglanti.Close();

                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
                }
            }

        }

        private void btnagirisi_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("Select * from admingirisi where kullaniciadi = '" + tbkadi.Text + "' and sifre = '" + tbsifre.Text + "'", baglanti);
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    if (checkBox1.Checked)
                    {

                        Properties.Settings.Default.KullaniciAdi = tbkadi.Text;
                        Properties.Settings.Default.Sifre = tbsifre.Text;
                        Properties.Settings.Default.BeniHatirla = true;

                    }
                    else
                    {
                        Properties.Settings.Default.KullaniciAdi = "";
                        Properties.Settings.Default.Sifre = "";
                        Properties.Settings.Default.BeniHatirla = false;
                    }

                    Properties.Settings.Default.Save();
                    this.Hide();
                    Form form = new frmadmin();
                    form.Show();
                    tbkadi.Clear();
                    tbsifre.Clear();
                    if (checkBox1.Checked)
                    {
                        kullanicibilgileridegeleri.bhkadi = kullanicibilgileridegeleri.kullaniciadi;
                        kullanicibilgileridegeleri.bhsifre = kullanicibilgileridegeleri.sifre;
                    }
                    else
                    {
                        kullanicibilgileridegeleri.bhkadi = null;
                        kullanicibilgileridegeleri.bhsifre = null;
                    }
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
                }
            }

        }

        private void formgiris_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.BeniHatirla)
            {
                tbkadi.Text = Properties.Settings.Default.KullaniciAdi;
                tbsifre.Text = Properties.Settings.Default.Sifre;
                checkBox1.Checked = true;
            }
            if (tbsifre.Text == Properties.Settings.Default.Sifre)
            {
                tbsifre.PasswordChar = '*';
            }

        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!checkBox2.Checked)
            {
                tbsifre.PasswordChar = '*';
            }
            else
            {
                tbsifre.PasswordChar = '\0';
            }

        }

        private void tbkadi_Enter_1(object sender, EventArgs e)
        {
            if (tbkadi.Text == "Nickname")
            {
                tbkadi.Text = "";
                tbkadi.ForeColor = Color.White;
            }

        }

        private void tbkadi_Leave_1(object sender, EventArgs e)
        {
            if (tbkadi.Text == "")
            {
                tbkadi.Text = "Nickname";
                tbkadi.ForeColor = Color.Silver;
            }

        }

        private void tbsifre_Leave_1(object sender, EventArgs e)
        {
            if (tbsifre.Text == "")
            {
                tbsifre.Text = "Password";
                tbsifre.ForeColor = Color.Silver;
                tbsifre.PasswordChar = '\0';
            }

        }

        private void tbsifre_Enter_1(object sender, EventArgs e)
        {
            if (tbsifre.Text == "Password")
            {
                tbsifre.Text = "";
                tbsifre.ForeColor = Color.White;
                tbsifre.PasswordChar = '*';
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            kullanicibilgileridegeleri.kullaniciadi = null;
            kullanicibilgileridegeleri.sifre = null;
            kullanicibilgileridegeleri.isim = null;
            kullanicibilgileridegeleri.soyisim = null;
            kullanicibilgileridegeleri.mail = null;
            kullanicibilgileridegeleri.telefon = -1;
            kullanicibilgileridegeleri.YetkiliID = -1;
            Application.Exit();
        }
    }
}






