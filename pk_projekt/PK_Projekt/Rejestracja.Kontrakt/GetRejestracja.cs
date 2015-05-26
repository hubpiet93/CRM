using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypOperacji.Kontrakt;
using System.ServiceModel;
using System.Data.SqlClient;
namespace Rejestracja.Kontrakt
{
    [ServiceContract]
    public interface GetRejestracja
    {
        [OperationContract]
        Dodaj GetDodaj();
    }
}
