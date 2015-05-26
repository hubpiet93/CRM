using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypOperacji.Kontrakt;
using NowaUsługa.Kontrakt;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.Serialization;
namespace NowaUsługa.Kontrakt
{
    [DataContract]
    public class DodajUsługę : IDodajUsługę
    {
        private SqlConnection Połączenie;

        public void DodajNowąUsługę(string NazwaUsługi)
        {
            SqlCommand kwerenda;
            string Polecenie;
            try
            {
                Polecenie = String.Format("insert into [dbo].[Uslugi] (NazwaUsługi) values ('{0}')", NazwaUsługi);
                kwerenda = new SqlCommand(Polecenie);
                Połączenie.Open();
                kwerenda.Connection = Połączenie;
                kwerenda.ExecuteNonQuery();
                Połączenie.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        public SqlDataReader GetUsługi()
        {
            SqlDataReader Czytnik;
            SqlCommand Kwerenda;
            string Polecenie;
            try
            {
                Połączenie.Open();
                Polecenie = String.Format("select * from [dbo].[Uslugi]");
                Kwerenda = new SqlCommand(Polecenie);
                Kwerenda.Connection = Połączenie;
                Kwerenda.Clone();
                Czytnik = Kwerenda.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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


        public string GetUsługa(int id)
        {
            SqlDataReader Czytnik;
            SqlCommand Kwerenda;
            string Polecenie;
            string NazwaUsługi;
            try
            {
                Połączenie.Open();
                Polecenie = String.Format("select [NazwaUsługi] from [dbo].[Uslugi] where IdUsługi = {0}",id);
                Kwerenda = new SqlCommand(Polecenie);
                Kwerenda.Connection = Połączenie;
                Kwerenda.Clone();
                Czytnik = Kwerenda.ExecuteReader();
                NazwaUsługi = Czytnik[0].ToString();
                Połączenie.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                NazwaUsługi = "";
            }
            return NazwaUsługi;
        }
    }
}
