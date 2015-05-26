using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypOperacji.Kontrakt;
using Rejestracja.Kontrakt;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Rejestracja.Implementacja
{
    public class RejestracjaObiekt : GetRejestracja
    {
        public Dodaj GetDodaj()
        {
            return new Dodaj();
        }
    }
}
