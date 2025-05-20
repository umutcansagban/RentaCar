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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Rent_a_Car_Uygulaması
{
    public partial class frmkayit : Form
    {
        public frmkayit()
        {

            InitializeComponent();

            tbkkod.Visible = false;
            tbpkod.Visible = false;
            btnkkayit.Visible = false;
            btnpkayit.Visible = false;

        }
        int random;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-MONNBD4\TEW_SQLEXPRESS;Initial Catalog=kullanicibilgileri;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");

        /*



             }
             private void btnkayit_Click(object sender, EventArgs e)
             {

                   if (cbkayit.Text == "Kullanıcı Kayıtı")
                   {
                       if (sifrekontrol.uzunlukkontrol(tbsifre1.Text) < 8)
                       {
                           MessageBox.Show("Şifre Uzunluğu 8 karakterden küçük olamaz");
                       }
                       else if (sifrekontrol.kucukkontrol(tbsifre1.Text) < 1)
                       {
                           MessageBox.Show("Şifrenizde en az bir tane küçük harf bulunmak zorundadır.");
                       }
                       else if (sifrekontrol.sayikontrol(tbsifre1.Text) < 1)
                       {
                           MessageBox.Show("Şifrenizde en az bir tane sayı bulunmak zorundadır.");
                       }
                       else if (sifrekontrol.buyukkontrol(tbsifre1.Text) < 1)
                       {
                           MessageBox.Show("Şifrenizde en az bir tane büyük harf bulunmak zorundadır.");
                       }
                       else
                       {
                           if (tbsifre1.Text == tbsifre2.Text)
                           {
                             if(sifrekontrol.mailkontrol(tbmail.Text) == true)
                             {
                                 if(sifrekontrol.maildogrulama(random,Convert.ToInt32(tbkod.Text)) == true)
                                 {
                                     string sorgu = "insert into kullanicigirisi(isim,soyisim,kullaniciadi,sifre,mail,telefon)values(@isim,@soyisim,@kullaniciadi,@sifre,@mail,@telefon)";
                                     SqlCommand komut = new SqlCommand(sorgu, baglanti);
                                     komut.Parameters.AddWithValue("@isim", tbisim.Text);
                                     komut.Parameters.AddWithValue("@soyisim", tbsoyisim.Text);
                                     komut.Parameters.AddWithValue("@kullaniciadi", tbkadi.Text);
                                     komut.Parameters.AddWithValue("@sifre", tbsifre1.Text);
                                     komut.Parameters.AddWithValue("@mail", tbmail.Text);
                                     komut.Parameters.AddWithValue("@telefon", tbtelefon.Text);
                                     baglanti.Open();
                                     komut.ExecuteNonQuery();
                                     tbisim.Clear();
                                     tbsoyisim.Clear();
                                     tbkadi.Clear();
                                     tbsifre1.Clear();
                                     tbsifre2.Clear();
                                     tbmail.Clear();
                                     tbtelefon.Clear();
                                     baglanti.Close();
                                     MessageBox.Show("Kaydınız Tamamlanmıştır. Giriş Ekranına Dönebilirsiniz.");
                                 }
                                else
                                 {
                                     MessageBox.Show("Doğrulama Kodunuz Hatalı");
                                 }
                             }
                             else
                             {
                                 MessageBox.Show("Mail adresinizi doğru girdiğinize emin olunuz");
                             }

                           }
                           else
                           {
                               MessageBox.Show("Şifrenizi Doğru Girdiğinize Emin Olunuz.");
                           }
                       }



                   }
                   else if (cbkayit.Text == "Rent a Car Kayıtı")
                   {
                       if (sifrekontrol.uzunlukkontrol(tbsifre1.Text) < 8)
                       {
                           MessageBox.Show("Şifre Uzunluğu 8 karakterden küçük olamaz");
                       }
                       else if (sifrekontrol.kucukkontrol(tbsifre1.Text) < 1)
                       {
                           MessageBox.Show("Şifrenizde en az bir tane küçük harf bulunmak zorundadır.");
                       }
                       else if (sifrekontrol.sayikontrol(tbsifre1.Text) < 1)
                       {
                           MessageBox.Show("Şifrenizde en az bir tane sayı bulunmak zorundadır.");
                       }
                       else if(sifrekontrol.buyukkontrol(tbsifre1.Text) < 1)
                       {
                           MessageBox.Show("Şifrenizde en az bir tane büyük harf bulunmak zorundadır.");
                       }
                       else
                       {
                           if (tbsifre1.Text == tbsifre2.Text)
                           {
                             if (sifrekontrol.mailkontrol(tbmail.Text) == true)
                             {
                                 if(sifrekontrol.maildogrulama(random, Convert.ToInt32(tbkod.Text)) == true)
                                 {
                                     string sorgu = "insert into yetkiligirisi(isim,soyisim,kullaniciadi,sifre,mail,telefon)values(@isim,@soyisim,@kullaniciadi,@sifre,@mail,@telefon)";
                                     SqlCommand komut = new SqlCommand(sorgu, baglanti);
                                     komut.Parameters.AddWithValue("@isim", tbisim.Text);
                                     komut.Parameters.AddWithValue("@soyisim", tbsoyisim.Text);
                                     komut.Parameters.AddWithValue("@kullaniciadi", tbkadi.Text);
                                     komut.Parameters.AddWithValue("@sifre", tbsifre1.Text);
                                     komut.Parameters.AddWithValue("@mail", tbmail.Text);
                                     komut.Parameters.AddWithValue("@telefon", tbtelefon.Text);
                                     baglanti.Open();
                                     komut.ExecuteNonQuery();
                                     tbisim.Clear();
                                     tbsoyisim.Clear();
                                     tbkadi.Clear();
                                     tbsifre1.Clear();
                                     tbsifre2.Clear();
                                     tbmail.Clear();
                                     tbtelefon.Clear();
                                     baglanti.Close();
                                     MessageBox.Show("Kaydınız Tamamlanmıştır. Giriş Ekranına Dönebilirsiniz.");
                                 }
                                 else
                                 {
                                     MessageBox.Show("Doğrulama Kodunuz Hatalı");
                                 }

                             }
                             else
                             {
                                 MessageBox.Show("Mail adresinizi doğru girdiğinize emin olunuz");
                             }
                           }
                           else
                           {
                               MessageBox.Show("Şifrenizi Doğru Girdiğinize Emin Olunuz.");
                           }
                       }
                   }

             }


             private void btndon_Click(object sender, EventArgs e)
             {
                 this.Close();
                 frmgiris form = new frmgiris();
                 form.Show();
             }

             private void checkBox1_CheckedChanged(object sender, EventArgs e)
             {
                 if (checkBox1.Checked)
                 {
                     tbsifre1.PasswordChar = '\0';
                     tbsifre2.PasswordChar = '\0';
                 }
                 else
                 {
                     tbsifre1.PasswordChar = '*';
                     tbsifre2.PasswordChar = '*';
                 }

             }
             */
        private void btnkkod_Click(object sender, EventArgs e)
        {

            baglanti.Open();

            SqlCommand mailKontrol = new SqlCommand("SELECT COUNT(*) FROM kullanicigirisi WHERE mail = @mail", baglanti);
            mailKontrol.Parameters.AddWithValue("@mail", tbkmail.Text);
            int mailSayisi = (int)mailKontrol.ExecuteScalar();

            SqlCommand kullaniciAdiKontrol = new SqlCommand("SELECT COUNT(*) FROM kullanicigirisi WHERE kullaniciadi = @kadi", baglanti);
            kullaniciAdiKontrol.Parameters.AddWithValue("@kadi", tbkkadi.Text);
            int kullaniciAdiSayisi = (int)kullaniciAdiKontrol.ExecuteScalar();

            SqlCommand telefonKontrol = new SqlCommand("SELECT COUNT(*) FROM kullanicigirisi WHERE telefon = @telefon", baglanti);
            telefonKontrol.Parameters.AddWithValue("@telefon", tbktelefon.Text);
            int telefonSayisi = (int)telefonKontrol.ExecuteScalar();

            baglanti.Close();

            if (mailSayisi > 0)
            {
                MessageBox.Show("Bu mail adresiyle daha önce kayıt yapılmış.");
                return;
            }
            if (kullaniciAdiSayisi > 0)
            {
                MessageBox.Show("Bu kullanıcı adı daha önce alınmış.");
                return;
            }
            if (telefonSayisi > 0)
            {
                MessageBox.Show("Bu telefon numarası zaten kullanılıyor.");
                return;
            }
            if (sifrekontrol.uzunlukkontrol(tbksifre1.Text) < 8)
            {
                MessageBox.Show("Şifre Uzunluğu 8 karakterden küçük olamaz");
            }
            else if (sifrekontrol.kucukkontrol(tbksifre1.Text) < 1)
            {
                MessageBox.Show("Şifrenizde en az bir tane küçük harf bulunmak zorundadır.");
            }
            else if (sifrekontrol.sayikontrol(tbksifre1.Text) < 1)
            {
                MessageBox.Show("Şifrenizde en az bir tane sayı bulunmak zorundadır.");
            }
            else if (sifrekontrol.buyukkontrol(tbksifre1.Text) < 1)
            {
                MessageBox.Show("Şifrenizde en az bir tane büyük harf bulunmak zorundadır.");
            }
            else
            {
                if (tbksifre1.Text == tbksifre2.Text)
                {
                    if (sifrekontrol.mailkontrol(tbkmail.Text) == true)
                    {
                        random = sifrekontrol.mailkodgonderme(tbkmail.Text);
                        MessageBox.Show("Mail Adresinize Kod Gönderildi");
                        btnkkayit.Visible = true;
                        tbkkod.Visible = true;
                        btnkkod.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Mail adresinizi doğru girdiğinize emin olunuz");
                    }

                }
                else
                {
                    MessageBox.Show("Şifrenizi Doğru Girdiğinize Emin Olunuz.");
                }




            }
        }

        private void btpkod_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand mailKontrol = new SqlCommand("SELECT COUNT(*) FROM kullanicigirisi WHERE mail = @mail", baglanti);
            mailKontrol.Parameters.AddWithValue("@mail", tbpmail.Text);
            int mailSayisi = (int)mailKontrol.ExecuteScalar();

            SqlCommand kullaniciAdiKontrol = new SqlCommand("SELECT COUNT(*) FROM kullanicigirisi WHERE kullaniciadi = @kadi", baglanti);
            kullaniciAdiKontrol.Parameters.AddWithValue("@kadi", tbpkadi.Text);
            int kullaniciAdiSayisi = (int)kullaniciAdiKontrol.ExecuteScalar();

            SqlCommand telefonKontrol = new SqlCommand("SELECT COUNT(*) FROM kullanicigirisi WHERE telefon = @telefon", baglanti);
            telefonKontrol.Parameters.AddWithValue("@telefon", tbptelefon.Text);
            int telefonSayisi = (int)telefonKontrol.ExecuteScalar();

            baglanti.Close();

            if (mailSayisi > 0)
            {
                MessageBox.Show("Bu mail adresiyle daha önce kayıt yapılmış.");
                return;
            }
            if (kullaniciAdiSayisi > 0)
            {
                MessageBox.Show("Bu kullanıcı adı daha önce alınmış.");
                return;
            }
            if (telefonSayisi > 0)
            {
                MessageBox.Show("Bu telefon numarası zaten kullanılıyor.");
                return;
            }
            if (sifrekontrol.uzunlukkontrol(tbpsifre1.Text) < 8)
            {
                MessageBox.Show("Şifre Uzunluğu 8 karakterden küçük olamaz");
            }
            else if (sifrekontrol.kucukkontrol(tbpsifre1.Text) < 1)
            {
                MessageBox.Show("Şifrenizde en az bir tane küçük harf bulunmak zorundadır.");
            }
            else if (sifrekontrol.sayikontrol(tbpsifre1.Text) < 1)
            {
                MessageBox.Show("Şifrenizde en az bir tane sayı bulunmak zorundadır.");
            }
            else if (sifrekontrol.buyukkontrol(tbpsifre1.Text) < 1)
            {
                MessageBox.Show("Şifrenizde en az bir tane büyük harf bulunmak zorundadır.");
            }
            else
            {
                if (tbpsifre1.Text == tbpsifre2.Text)
                {
                    if (sifrekontrol.mailkontrol(tbpmail.Text) == true)
                    {
                        random = sifrekontrol.mailkodgonderme(tbpmail.Text);
                        MessageBox.Show("Mail Adresinize Kod Gönderildi");
                        btnpkayit.Visible = true;
                        tbpkod.Visible = true;
                        btnpkod.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Mail adresinizi doğru girdiğinize emin olunuz");
                    }
                }
                else
                {
                    MessageBox.Show("Şifrenizi Doğru Girdiğinize Emin Olunuz.");
                }
            }
        }

        private void btnkkayit_Click(object sender, EventArgs e)
        {
            if (sifrekontrol.uzunlukkontrol(tbksifre1.Text) < 8)
            {
                MessageBox.Show("Şifre Uzunluğu 8 karakterden küçük olamaz");
            }
            else if (sifrekontrol.kucukkontrol(tbksifre1.Text) < 1)
            {
                MessageBox.Show("Şifrenizde en az bir tane küçük harf bulunmak zorundadır.");
            }
            else if (sifrekontrol.sayikontrol(tbksifre1.Text) < 1)
            {
                MessageBox.Show("Şifrenizde en az bir tane sayı bulunmak zorundadır.");
            }
            else if (sifrekontrol.buyukkontrol(tbksifre1.Text) < 1)
            {
                MessageBox.Show("Şifrenizde en az bir tane büyük harf bulunmak zorundadır.");
            }
            else
            {
                if (tbksifre1.Text == tbksifre2.Text)
                {
                    if (sifrekontrol.mailkontrol(tbkmail.Text) == true)
                    {
                        if (sifrekontrol.maildogrulama(random, Convert.ToInt32(tbkkod.Text)) == true)
                        {
                            string sorgu = "insert into kullanicigirisi(isim,soyisim,kullaniciadi,sifre,mail,telefon)values(@isim,@soyisim,@kullaniciadi,@sifre,@mail,@telefon)";
                            SqlCommand komut = new SqlCommand(sorgu, baglanti);
                            komut.Parameters.AddWithValue("@isim", tbkisim.Text);
                            komut.Parameters.AddWithValue("@soyisim", tbksoyisim.Text);
                            komut.Parameters.AddWithValue("@kullaniciadi", tbkkadi.Text);
                            komut.Parameters.AddWithValue("@sifre", tbksifre1.Text);
                            komut.Parameters.AddWithValue("@mail", tbkmail.Text);
                            komut.Parameters.AddWithValue("@telefon", tbktelefon.Text);
                            baglanti.Open();
                            komut.ExecuteNonQuery();
                            tbkisim.Clear();
                            tbksoyisim.Clear();
                            tbkkadi.Clear();
                            tbksifre1.Clear();
                            tbksifre2.Clear();
                            tbkmail.Clear();
                            tbktelefon.Clear();
                            baglanti.Close();
                            MessageBox.Show("Kaydınız Tamamlanmıştır. Giriş Ekranına Dönebilirsiniz.");
                        }
                        else
                        {
                            MessageBox.Show("Doğrulama Kodunuz Hatalı");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mail adresinizi doğru girdiğinize emin olunuz");
                    }

                }
                else
                {
                    MessageBox.Show("Şifrenizi Doğru Girdiğinize Emin Olunuz.");
                }
            }
        }

        private void btnpkayit_Click(object sender, EventArgs e)
        {
            if (sifrekontrol.uzunlukkontrol(tbpsifre1.Text) < 8)
            {
                MessageBox.Show("Şifre Uzunluğu 8 karakterden küçük olamaz");
            }
            else if (sifrekontrol.kucukkontrol(tbpsifre1.Text) < 1)
            {
                MessageBox.Show("Şifrenizde en az bir tane küçük harf bulunmak zorundadır.");
            }
            else if (sifrekontrol.sayikontrol(tbpsifre1.Text) < 1)
            {
                MessageBox.Show("Şifrenizde en az bir tane sayı bulunmak zorundadır.");
            }
            else if (sifrekontrol.buyukkontrol(tbpsifre1.Text) < 1)
            {
                MessageBox.Show("Şifrenizde en az bir tane büyük harf bulunmak zorundadır.");
            }
            else
            {
                if (tbpsifre1.Text == tbpsifre2.Text)
                {
                    if (sifrekontrol.mailkontrol(tbpmail.Text) == true)
                    {
                        if (sifrekontrol.maildogrulama(random, Convert.ToInt32(tbpkod.Text)) == true)
                        {
                            string sorgu = "insert into yetkiligirisi(isim,soyisim,kullaniciadi,sifre,mail,telefon)values(@isim,@soyisim,@kullaniciadi,@sifre,@mail,@telefon)";
                            SqlCommand komut = new SqlCommand(sorgu, baglanti);
                            komut.Parameters.AddWithValue("@isim", tbpisim.Text);
                            komut.Parameters.AddWithValue("@soyisim", tbpsoyisim.Text);
                            komut.Parameters.AddWithValue("@kullaniciadi", tbpkadi.Text);
                            komut.Parameters.AddWithValue("@sifre", tbpsifre1.Text);
                            komut.Parameters.AddWithValue("@mail", tbpmail.Text);
                            komut.Parameters.AddWithValue("@telefon", tbptelefon.Text);
                            baglanti.Open();
                            komut.ExecuteNonQuery();
                            tbpisim.Clear();
                            tbpsoyisim.Clear();
                            tbpkadi.Clear();
                            tbpsifre1.Clear();
                            tbpsifre2.Clear();
                            tbpmail.Clear();
                            tbptelefon.Clear();
                            baglanti.Close();
                            MessageBox.Show("Kaydınız Tamamlanmıştır. Giriş Ekranına Dönebilirsiniz.");
                        }
                        else
                        {
                            MessageBox.Show("Doğrulama Kodunuz Hatalı");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Mail adresinizi doğru girdiğinize emin olunuz");
                    }
                }
                else
                {
                    MessageBox.Show("Şifrenizi Doğru Girdiğinize Emin Olunuz.");
                }
            }
        }

        private void btnpdon_Click(object sender, EventArgs e)
        {
            this.Close();
            frmanasayfa form = new frmanasayfa();
            form.Show();
        }

        private void btnkdon_Click(object sender, EventArgs e)
        {
            this.Close();
            formgiris form = new formgiris();
            form.Show();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                tbksifre1.PasswordChar = '\0';
                tbksifre2.PasswordChar = '\0';
            }
            else
            {
                tbksifre1.PasswordChar = '*';
                tbksifre2.PasswordChar = '*';
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                tbpsifre1.PasswordChar = '\0';
                tbpsifre2.PasswordChar = '\0';
            }
            else
            {
                tbpsifre1.PasswordChar = '*';
                tbpsifre2.PasswordChar = '*';
            }
        }

        private void tbkisim_Enter(object sender, EventArgs e)
        {
            if(tbkisim.Text == "Name")
            {
                tbkisim.Text = "";
                tbkisim.ForeColor = Color.White;
            }
        }

        private void tbkisim_Leave(object sender, EventArgs e)
        {
            if (tbkisim.Text == "")
            {
                tbkisim.Text = "Name";
                tbkisim.ForeColor = Color.Silver;
            }
        }

        private void tbksoyisim_Enter(object sender, EventArgs e)
        {
            if (tbksoyisim.Text == "Surname")
            {
                tbksoyisim.Text = "";
                tbksoyisim.ForeColor = Color.White;
            }
        }

        private void tbksoyisim_Leave(object sender, EventArgs e)
        {
            if (tbksoyisim.Text == "")
            {
                tbksoyisim.Text = "Surname";
                tbksoyisim.ForeColor = Color.Silver;
            }
        }

        private void tbkkadi_Enter(object sender, EventArgs e)
        {
            if (tbkkadi.Text == "Nickname")
            {
                tbkkadi.Text = "";
                tbkkadi.ForeColor = Color.White;
            }
        }

        private void tbkkadi_Leave(object sender, EventArgs e)
        {
            if (tbkkadi.Text == "")
            {
                tbkkadi.Text = "Nickname";
                tbkkadi.ForeColor = Color.Silver;
            }
        }

        private void tbksifre1_Enter(object sender, EventArgs e)
        {
            if (tbksifre1.Text == "Password")
            {
                tbksifre1.Text = "";
                tbksifre1.ForeColor = Color.White;
                tbksifre1.PasswordChar = '*';
            }
        }

        private void tbksifre1_Leave(object sender, EventArgs e)
        {
            if (tbksifre1.Text == "")
            {
                tbksifre1.Text = "Password";
                tbksifre1.ForeColor = Color.Silver;
                tbksifre1.PasswordChar = '\0';
            }
        }

        private void tbksifre2_Enter(object sender, EventArgs e)
        {
            if (tbksifre2.Text == "Password(Again)")
            {
                tbksifre2.Text = "";
                tbksifre2.ForeColor = Color.White;
                tbksifre2.PasswordChar = '*';
            }
        }

        private void tbksifre2_Leave(object sender, EventArgs e)
        {
            if (tbksifre2.Text == "")
            {
                tbksifre2.Text = "Password(Again)";
                tbksifre2.ForeColor = Color.Silver;
                tbksifre2.PasswordChar = '\0';
            }
        }

        private void tbkmail_Enter(object sender, EventArgs e)
        {
            if (tbkmail.Text == "Mail")
            {
                tbkmail.Text = "";
                tbkmail.ForeColor = Color.White;
            }
        }

        private void tbkmail_Leave(object sender, EventArgs e)
        {
            if (tbkmail.Text == "")
            {
                tbkmail.Text = "Mail";
                tbkmail.ForeColor = Color.Silver;
            }
        }

        private void tbktelefon_Enter(object sender, EventArgs e)
        {
            if (tbktelefon.Text == "Phone")
            {
                tbktelefon.Text = "";
                tbktelefon.ForeColor = Color.White;
            }
        }

        private void tbktelefon_Leave(object sender, EventArgs e)
        {
            if (tbktelefon.Text == "")
            {
                tbktelefon.Text = "Phone";
                tbktelefon.ForeColor = Color.Silver;
            }
        }

        private void tbkkod_Enter(object sender, EventArgs e)
        {
            if (tbkkod.Text == "Code")
            {
                tbkkod.Text = "";
                tbkkod.ForeColor = Color.White;
            }
        }

        private void tbkkod_Leave(object sender, EventArgs e)
        {
            if (tbkkod.Text == "")
            {
                tbkkod.Text = "Code";
                tbkkod.ForeColor = Color.Silver;
            }
        }

    
    }
}
