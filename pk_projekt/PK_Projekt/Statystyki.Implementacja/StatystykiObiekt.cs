using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypOperacji;
using Statystyki.Kontrakt;
using System.Data.SqlClient;
namespace Statystyki.Implementacja
{
    public class StatystykiObiekt : GetBudujStatystyki
    {

        public BudujStatystyki GetBudujStatystyki()
        {
            return new BudujStatystyki();
        }
    }
}
