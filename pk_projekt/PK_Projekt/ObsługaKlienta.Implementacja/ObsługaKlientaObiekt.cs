using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObsługaKlienta.Kontrakt;
using TypOperacji.Kontrakt;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace ObsługaKlienta.Implementacja
{
    public class ObsługaKlientaObiekt : GetObsługaKlienta
    {
        public Kontrakt.ObsługaKlienta GetObsługaKlienta()
        {
            return new Kontrakt.ObsługaKlienta();
        }
    }
}
