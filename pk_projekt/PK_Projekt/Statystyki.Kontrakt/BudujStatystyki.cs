using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Statystyki.Kontrakt
{
    [DataContract]
    public class BudujStatystyki : IBudujStatystyki
    {
        private SqlConnection Połączenie;


        public void PołączenieClose()
        {
            this.Połączenie.Close() ;
        }


        public SqlConnection SetPołączenie
        {
            set { this.Połączenie = value; }
        }


        public SqlDataReader PrzychódPoKlinetach()
        {
            SqlDataReader Czytnik;
            SqlCommand Kwerenda;
            try
            {
                string Polecenie = String.Format(@"select
                                                k.[Imię/NazwaFirmy],
                                                k.[Nazwisko],
                                                sum(t.WartośćTransakcji) as 'Suma_transakcji'
                                                from [Klienci] as k
                                                join [Transakcje] as t on k.[IdKlienta] = t.[IdKlienta]
                                                where t.[Zapłacone] != 'false'
                                                group by k.[IdKlienta], k.[Nazwisko], K.[Imię/NazwaFirmy]");
                Połączenie.Open();
                Kwerenda = new SqlCommand(Polecenie);
                Kwerenda.Connection = Połączenie;
                Kwerenda.Clone();
                Czytnik = Kwerenda.ExecuteReader();
            }
            catch (Exception)
            {
                Czytnik = null;
            }
            return Czytnik;
        }


        public SqlDataReader ZobowiązaniaNaKliencie(string dataod,string datado,int idklienta)
        {
            SqlDataReader Czytnik;
            SqlCommand Kwerenda;
            try
            {
                string Polecenie = String.Format(@"SELECT
                                                    k.[IdKlienta],
                                                    k.[Imię/NazwaFirmy],
                                                    k.[Nazwisko],
                                                    k.[EMail],
                                                    k.[Telefon],
                                                    u.[NazwaUsługi],
                                                    t.[WartośćTransakcji],
                                                    t.[DataTransakcji]


                                                    FROM [Transakcje] as t
                                                    join [Zobowiazania] as z
                                                    on t.[IdTransakcji] = z.[IdTransakcji]
                                                    join [Klienci] as k on
                                                    k.[IdKlienta] = t.[IdKlienta]
                                                    join [Uslugi] as u
                                                    on t.[IdUsługi] = u.[IdUsługi]
                                                    where t.[Zapłacone] = 'false'
                                                    and (t.[DataTransakcji] between '{0}' and '{1}')
                                                    and k.[IdKlienta] = {2}",dataod,datado,idklienta);
                Połączenie.Open();
                Kwerenda = new SqlCommand(Polecenie);
                Kwerenda.Connection = Połączenie;
                Kwerenda.Clone();
                Czytnik = Kwerenda.ExecuteReader();
            }
            catch (Exception)
            {
                Czytnik = null;
            }
            return Czytnik;
        }


        public SqlDataReader TransakcjeNaUsłudze(string dataod, string datado)
        {
            SqlDataReader Czytnik;
            SqlCommand Kwerenda;
            try
            {
                string Polecenie = String.Format(@"Select
                                                    u.[NazwaUsługi],
                                                    count(u.[IdUsługi]) as 'liczba_usług',
                                                    sum(t.[WartośćTransakcji]) as 'suma_z_usług'
                                                    from [Uslugi] as u
                                                    join [Transakcje] as t
                                                    on u.[IdUsługi] = t.[IdUsługi]
                                                    where t.[DataTransakcji] between '{0}' and '{1}'
                                                    group by [NazwaUsługi]",dataod,datado);
                Połączenie.Open();
                Kwerenda = new SqlCommand(Polecenie);
                Kwerenda.Connection = Połączenie;
                Kwerenda.Clone();
                Czytnik = Kwerenda.ExecuteReader();
            }
            catch (Exception)
            {
                Czytnik = null;
            }
            return Czytnik;
        }


        public SqlDataReader PrzychódCałkowity(string dataod, string datado)
        {
            SqlDataReader Czytnik;
            SqlCommand Kwerenda;
            try
            {
                string Polecenie = String.Format(@"select 
                                                sum([Transakcje].[WartośćTransakcji])
                                                from Transakcje
                                                where Transakcje.DataTransakcji between '{0}' and '{1}'", dataod, datado);
                Połączenie.Open();
                Kwerenda = new SqlCommand(Polecenie);
                Kwerenda.Connection = Połączenie;
                Kwerenda.Clone();
                Czytnik = Kwerenda.ExecuteReader();
            }
            catch (Exception)
            {
                Czytnik = null;
            }
            return Czytnik;
        }


        public SqlDataReader PrzychódProcentowy(string dataod, string datado, int całkowity)
        {
            SqlDataReader Czytnik;
            SqlCommand Kwerenda;
            try
            {
                string Polecenie = String.Format(@"select
                                                    k.[IdKlienta],
                                                    k.[Imię/NazwaFirmy],
                                                    k.[Nazwisko],

                                                    sum(t.[WartośćTransakcji]) as 'Procent'


                                                    from [Transakcje] as t
                                                    join [Klienci] as k
                                                    on t.[IdKlienta] = k.[IdKlienta]
                                                    where t.[DataTransakcji] between '{0}' and '{1}'
                                                    group by k.[IdKlienta],k.[Imię/NazwaFirmy],k.[Nazwisko]", dataod, datado);
                Połączenie.Open();
                Kwerenda = new SqlCommand(Polecenie);
                Kwerenda.Connection = Połączenie;
                Kwerenda.Clone();
                Czytnik = Kwerenda.ExecuteReader();
            }
            catch (Exception)
            {
                Czytnik = null;
            }
            return Czytnik;
        }
    }
}
