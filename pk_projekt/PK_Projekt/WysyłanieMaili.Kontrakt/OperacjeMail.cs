using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace WysyłanieMaili.Kontrakt
{
    [DataContract]
   public class OperacjeMail : IOperacjeMail
    {
        public void PojedyńczyMail(string AdresNadawcy, string Hasło, string SMTPAdres, int Port, string AdresOdbiorcy, string TematWiadomości, string Wiadomość)
        {
            try
            {
                MailMessage mail = new MailMessage(AdresNadawcy, AdresOdbiorcy, TematWiadomości, Wiadomość);
                SmtpClient klient = new SmtpClient(SMTPAdres);

                klient.Port = Port;
                klient.Credentials = new NetworkCredential(AdresNadawcy, Hasło);
                klient.EnableSsl = true;
                klient.Send(mail);
            }
            catch (Exception)
            {
                MessageBox.Show("Coś poszło nie tak");
            }
        }
        public void SeryjnyMail(string AdresNadawcy, string Hasło, string SMTPAdres, int Port, List<string> AdresOdbiorcy, string TematWiadomości, string Wiadomość)
        {
            try
            {
                SmtpClient klient = new SmtpClient(SMTPAdres);
                klient.Credentials = new NetworkCredential(AdresNadawcy, Hasło);
                klient.Port = Port;
                klient.EnableSsl = true;
                ProgressBar a = new ProgressBar();
                a.Show();
                a.Minimum = 0;
                a.Maximum = AdresOdbiorcy.Count;
                a.Width = 350;
                a.Height = 50;
                Form f = new Form();
                f.Size= new System.Drawing.Size(360, 65);
                f.Controls.Add(a);
                f.Enabled = false;
                f.Show();
               
                foreach (String adresobiorcy in AdresOdbiorcy)
                {
                    try
                    {
                        MailMessage mail = new MailMessage(AdresNadawcy, adresobiorcy, TematWiadomości, Wiadomość);
                        klient.Send(mail);
                        a.Increment(1);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Wysłanie wiadomości do: " + adresobiorcy + " nie powiodło się");
                    } 
                }
                MessageBox.Show("Wiadomości zostały wysłane");
                f.Dispose();

            }
            catch (Exception)
            {
                MessageBox.Show("Coś poszło nie tak");
            }
        }
    }
}
