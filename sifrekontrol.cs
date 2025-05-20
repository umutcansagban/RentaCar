using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Linq.Expressions;
namespace Rent_a_Car_Uygulaması
{
    public class sifrekontrol
    {
        public static int uzunlukkontrol (string sifre)
        {
            int uzunluk = sifre.Length;
            return uzunluk;
        }
        public static int buyukkontrol(string sifre)
        {
            int uzunluk = sifre.Length - Regex.Replace(sifre, "[A-Z]", "").Length;
            return uzunluk;
        }
        public static int kucukkontrol(string sifre)
        {
            int uzunluk = sifre.Length - Regex.Replace(sifre, "[a-z]", "").Length;
            return uzunluk;
        }
        public static int sayikontrol(string sifre)
        {
            int uzunluk = sifre.Length - Regex.Replace(sifre, "[0-9]", "").Length;
            return uzunluk;
        }
        public static bool mailkontrol(string mail)
        {
            try
            {
                MailAddress m = new MailAddress(mail);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static int mailkodgonderme(string mail)
        {
            int random = 0;
            Random rand = new Random();
            random = rand.Next(100000, 999999);
            SmtpClient smtp = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential("rentacarapp1@gmail.com", "jgaw xehq movu bwjc"),
            };
            MailMessage mailMessage = new MailMessage()
            {
                From = new MailAddress("rentacarapp1@gmail.com"),
                Subject = "Eposta Doğrulama",
                Body = "Merhaba,\r\n\r\nGiriş işleminizi tamamlamak için aşağıdaki kodu kullanın:\r\n\r\nKod:" + random.ToString() + "\r\n\r\nEğer bu işlemi siz başlatmadıysanız, lütfen bizimle iletişime geçin.\r\n\r\nTeşekkürler,  \r\n[Rent A Car]",
            };
            mailMessage.To.Add(mail);
            smtp.Send(mailMessage);
            return random;
        }
           
        public static bool maildogrulama(int random,int kod)
        {
            
            if (kod == random)
            {
                return true;
            }
            else return false;
        }
    }
}
