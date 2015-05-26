using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypOperacji.Kontrakt;
using HistoriaTransakcji.Kontrakt;
using System.Data.SqlClient;
namespace HistoriaTransakcji.Implementacja
{
    public class HistoriaObiekt : GetHistoriaTransakcji
    {
        public Kontrakt.HistoriaTransakcji GetHistoriaTransakcji()
        {
            return new HistoriaTransakcji.Kontrakt.HistoriaTransakcji();
        }
    }
}
