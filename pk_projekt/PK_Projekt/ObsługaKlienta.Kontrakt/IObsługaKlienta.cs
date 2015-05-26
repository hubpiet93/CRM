using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using TypOperacji.Kontrakt;
using System.Data.SqlClient;
namespace ObsługaKlienta.Kontrakt
{
    public interface IObsługaKlienta 
    {
        void DodajTransakcję(SqlCommand Polecenie);
        void EdytujKlienta(string Polecenie);
        void ZapłaćObciążenie(int idtransakcji);
        void PołączenieClose();
        SqlConnection SetPołączenie { set; }
    }
}
