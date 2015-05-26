using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypOperacji.Kontrakt;
using System.ServiceModel;
using System.Data.SqlClient;
namespace Wyświetl.Kontrakt
{
    [ServiceContract]
    public interface GetWyświetl
    {
        [OperationContract]
        Wyświetl GetWyświetl();
    }
}
