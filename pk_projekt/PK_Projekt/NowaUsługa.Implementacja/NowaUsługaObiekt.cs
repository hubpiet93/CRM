using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypOperacji.Kontrakt;
using NowaUsługa.Kontrakt;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace NowaUsługa.Implementacja
{
    public class NowaUsługaObiekt  : GetDodajUsługę
    {
        public DodajUsługę GetDodajUsługę()
        {
            return new DodajUsługę();
        }
    }
}
