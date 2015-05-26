using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using TypOperacji.Kontrakt;
using System.Data.SqlClient;

namespace NowaUsługa.Kontrakt
{
    public interface IDodajUsługę
    {
        void DodajNowąUsługę(string NazwaUsługi);
        SqlDataReader GetUsługi();
        string GetUsługa(int id);
        void PołączenieClose();
        SqlConnection SetPołączenie { set; }
    }
}
