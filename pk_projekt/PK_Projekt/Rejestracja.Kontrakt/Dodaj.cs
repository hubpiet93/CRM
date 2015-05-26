using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rejestracja.Kontrakt
{
    [DataContract]
    public class Dodaj : IDodaj
    {
        private SqlConnection Połączenie;


        public void DodajKlienta(string Polecenie)
        {
            SqlCommand kwerenda;
            try
            {
                kwerenda = new SqlCommand(Polecenie);
                Połączenie.Open();
                kwerenda.Connection = Połączenie;


                kwerenda.ExecuteNonQuery();
                Połączenie.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Dodanie klienta nie udało się");
            }
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
