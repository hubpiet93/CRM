using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypOperacji.Kontrakt;
using System.ServiceModel;
using System.Data.SqlClient;

namespace HistoriaTransakcji.Kontrakt
{
    
    public interface IHistoriaTransakcji
    {
        SqlDataReader Historia(int IdKlienta);
        void PołączenieClose();
        SqlConnection SetPołączenie { set; }
    }
}
