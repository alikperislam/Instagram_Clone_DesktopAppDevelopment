using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace InstagramApp
{
    public partial class kodGonder : Form
    {
        public kodGonder()
        {
            InitializeComponent();
        }
        int sayi = 120;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayi--;
            saniye.Text = sayi.ToString();
        }

        private void kodGonder_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        Random rastgele = new Random();
        int say;
        private void button1_Click(object sender, EventArgs e)
        {                     
            int deger = int.Parse(txtKod.Text);
            if (say==deger)
            {
                timer1.Stop();
                this.Hide();
                frmAnaEkran f = new frmAnaEkran();
                f.Show();
            }
            else
            {
                MessageBox.Show("Girdiğiniz kod yanlış !!");
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int sayi = rastgele.Next(100000, 999999);
            say = sayi;
            MailMessage mesaj = new MailMessage(); // göndereceğimiz mesaj için bir nesne ürettik.
            //smtp : mail göndermek için kullanılan sunucu ile iletişime geçen bir protokoldur.
            SmtpClient istemci = new SmtpClient(); // istemci nesnesi ürettik.
            // istemci üzerinde kullanıcı mail adresi ve şifremi girmem için networkcredential sınıfı için mail adresimi ve parolamı yazıyorum.
            istemci.Credentials = new System.Net.NetworkCredential("gs_alikper_1905@hotmail.com", "sukru1905");
            istemci.Port = 587; // türkiyede port numarası genellikle 587 olarak kullanılır.
            istemci.Host = "smtp.live.com"; //outlook'un sunucu adresi.
            istemci.EnableSsl = true; // mail doğru adrese ulaşana kadar şifreleme yapması için yani websitelerdeki https işlevi görüyor.
            // göndereceğimiz mesaj ile ilgili içerikleri artık ekleyebiliriz.
            mesaj.To.Add("gs_alikper_1905@hotmail.com"); //mesajın hangi mail adresine gönderileceğini belirtiyoruz.
            mesaj.From = new MailAddress("gs_alikper_1905@hotmail.com"); // hangi mail adresinden yani kimden gönderileceği ile ilgili.
            mesaj.Subject = "İnstagram doğrulama kodu"; // konu ile ilgili bilgi girilecek.
            mesaj.Body = sayi.ToString(); // gönderilecek mesaj içeiriği burda.

            istemci.Send(mesaj); // istemci verileri mesaj sınıfından alacak ve outlook'a gönderecek.
        }
    }
}
