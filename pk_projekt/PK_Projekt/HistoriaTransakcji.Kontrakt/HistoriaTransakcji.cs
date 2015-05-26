using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoriaTransakcji.Kontrakt
{
    [DataContract]
    public class HistoriaTransakcji : IHistoriaTransakcji
    {
        private SqlConnection Połączenie;

        public SqlDataReader Historia(int IdKlienta)
        {
            SqlDataReader Czytnik;
            SqlCommand Kwerenda;
            string Polecenie;
            try
            {
                Połączenie.Open();
                Polecenie = String.Format(@"select
                                            t.[IdTransakcji],
                                            t.[IdKlienta],
                                            u.[NazwaUsługi],
                                            t.[DataTransakcji],
                                            t.[FormaPłatności],
                                            t.[WartośćTransakcji],
                                            t.[Zapłacone]
                                            from [Transakcje] as t
                                            join [Uslugi] as u
                                            on t.[IdUsługi] = u.[IdUsługi]
                                            where t.[IdKlienta] = {0}", IdKlienta);
                Kwerenda = new SqlCommand(Polecenie);
                Kwerenda.Connection = Połączenie;
                Kwerenda.Clone();
                Czytnik = Kwerenda.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show("Coś się nie powiodło");
                Czytnik = null;
            }
            return Czytnik;
        }


        public void PołączenieClose()
        {
            this.Połączenie.Close();
        }


        public SqlConnection SetPołączenie
        {
            set { this.Połączenie = value; }
        }
    }
}
