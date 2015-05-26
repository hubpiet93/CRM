using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypOperacji.Kontrakt;
using Wyświetl.Kontrakt;
namespace Wyświetl.Implementacja
{
    public class WyświetlObiekt : GetWyświetl
    {
        public Kontrakt.Wyświetl GetWyświetl()
        {
            return new Kontrakt.Wyświetl();
        }
    }
}
