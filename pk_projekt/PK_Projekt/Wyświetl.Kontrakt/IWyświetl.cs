using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using TypOperacji.Kontrakt;
namespace Wyświetl.Kontrakt
{
    public interface IWyświetl 
    {
        SqlDataReader WyświetlDanePersonalne(int IdKlienta);
        SqlDataReader WyświetlWszystkichKlientów();
        SqlDataReader WyświetlWszystkieTransakcje();
        SqlDataReader WyświetlTransakcjeZOdroczeniem();
        void PołączenieClose();
        SqlConnection SetPołączenie { set; }
    }
}
