using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using TypOperacji.Kontrakt;
namespace Statystyki.Kontrakt
{
    public interface IBudujStatystyki 
    {
        SqlDataReader PrzychódPoKlinetach();
        SqlDataReader ZobowiązaniaNaKliencie(string dataod, string datado, int idklienta);
        SqlDataReader TransakcjeNaUsłudze(string dataod, string datado);
        SqlDataReader PrzychódCałkowity(string dataod, string datado);
        SqlDataReader PrzychódProcentowy(string dataod, string datado,int całkowity);
        void PołączenieClose();
        SqlConnection SetPołączenie { set; }
    }
}
