using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypOperacji.Kontrakt;
using System.ServiceModel;
using System.Data.SqlClient;
using HistoriaTransakcji.Kontrakt;

namespace HistoriaTransakcji.Kontrakt
{
    [ServiceContract]
    public interface GetHistoriaTransakcji
    {
        [OperationContract]
        HistoriaTransakcji GetHistoriaTransakcji();
    }
}
