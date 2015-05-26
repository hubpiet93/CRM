using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypOperacji.Kontrakt;
using System.ServiceModel;
using System.Data.SqlClient;
namespace WysyłanieMaili.Kontrakt
{
    [ServiceContract]
    public interface GetOperacjeMail
    {
        [OperationContract]
        OperacjeMail GetOperacjeMail();
    }
}
