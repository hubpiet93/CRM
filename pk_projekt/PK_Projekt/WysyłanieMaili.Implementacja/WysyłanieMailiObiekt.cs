using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using TypOperacji.Kontrakt;
using WysyłanieMaili.Kontrakt;
namespace WysyłanieMaili.Implementacja
{
    public class WysyłanieMailiObiekt : GetOperacjeMail
    {

        public OperacjeMail GetOperacjeMail()
        {
            return new OperacjeMail();
        }
    }
}
