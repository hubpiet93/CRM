using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyświetl.Kontrakt
{
    [DataContract]
    public class Wyświetl : IWyświetl
    {
        private SqlConnection Połączenie;


        public SqlDataReader WyświetlDanePersonalne(int IdKlienta)
        {
            SqlDataReader Czytnik;
            SqlCommand Kwerenda;
            string Polecenie;
            try
            {
                Połączenie.Open();
                Polecenie = String.Format("select * from [dbo].[Klienci] where IdKlienta = {0}", IdKlienta);
                Kwerenda = new SqlCommand(Polecenie);
                Kwerenda.Connection = Połączenie;
                Kwerenda.Clone();
                Czytnik = Kwerenda.ExecuteReader();
            }
            catch (Exception)
            {
                MessageBox.Show("Coś się nie powiodło");
                Czytnik = null;
            }
            return Czytnik;
        }
        public SqlDataReader WyświetlWszystkichKlientów()
        {
            SqlDataReader Czytnik;
            SqlCommand Kwerenda;
            string Polecenie;
            try
            {
                Połączenie.Open();
                Polecenie = String.Format("select * from [dbo].[Klienci]");
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
        public SqlDataReader WyświetlWszystkieTransakcje()
        {
            SqlDataReader Czytnik;
            SqlCommand Kwerenda;
            string Polecenie;
            try
            {
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
                                            on t.[IdUsługi] = u.[IdUsługi]");
                Kwerenda = new SqlCommand(Polecenie);
                Kwerenda.Connection = Połączenie;
                Połączenie.Open();
                Czytnik = Kwerenda.ExecuteReader();
            }
            catch (Exception)
            {
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

        public SqlDataReader WyświetlTransakcjeZOdroczeniem()
        {
            SqlDataReader Czytnik;
            SqlCommand Kwerenda;
            string Polecenie;
            try
            {
                Polecenie = String.Format("select * from [dbo].[Transakcje] where [Zapłacone] = 'false'");
                Kwerenda = new SqlCommand(Polecenie);
                Kwerenda.Connection = Połączenie;
                Połączenie.Open();
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
