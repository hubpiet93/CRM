using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypOperacji.Kontrakt;
using System.ServiceModel;
using System.Data.SqlClient;
namespace ObsługaKlienta.Kontrakt
{
    [ServiceContract]
    public interface GetObsługaKlienta
    {
        [OperationContract]
        ObsługaKlienta GetObsługaKlienta();
    }
}
