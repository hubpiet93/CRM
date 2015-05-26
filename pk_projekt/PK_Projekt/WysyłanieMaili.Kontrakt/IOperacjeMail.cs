using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using TypOperacji.Kontrakt;
namespace WysyłanieMaili.Kontrakt
{
    public interface IOperacjeMail 
    {
        void PojedyńczyMail(string AdresNadawcy, string hasło, string SMTPAdres, int port, string AdresOdbiorcy, string TematWiadomości, string Wiadomość);
        void SeryjnyMail(string AdresNadawcy, string hasło, string SMTPAdres, int port, List<String> AdresOdbiorcy, string TematWiadomości, string Wiadomość);
    }
}
