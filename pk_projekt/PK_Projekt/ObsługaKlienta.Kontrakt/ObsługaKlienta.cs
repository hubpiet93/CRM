using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.Serialization;
namespace ObsługaKlienta.Kontrakt
{
    [DataContract]
    public class ObsługaKlienta : IObsługaKlienta
    {

        private SqlConnection Połączenie;


        public void DodajTransakcję(SqlCommand Polecenie)
        {
            try
            {

                Połączenie.Open();
                Polecenie.Connection = Połączenie;
                Polecenie.ExecuteNonQuery();
                Połączenie.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void EdytujKlienta(string Polecenie)
        {
            SqlCommand kwerenda;
            try
            {
                kwerenda = new SqlCommand(Polecenie);
                Połączenie.Open();
                kwerenda.Connection = Połączenie;
                // Połączenie.Clone();
                kwerenda.ExecuteNonQuery();
                Połączenie.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void ZapłaćObciążenie(int idtransakcji)
        {
            SqlCommand Polecenie;
            SqlCommand Polecenie2;
            try
            {
                Połączenie.Open();
                string polecenie1 = String.Format(@"
                UPDATE [dbo].[Transakcje]
                SET [Zapłacone] = '{0}'
                WHERE [IdTransakcji] = '{1}'
                ", true.ToString(), idtransakcji.ToString());

                Polecenie = new SqlCommand(polecenie1);
                Polecenie.Connection = Połączenie;
                Polecenie.ExecuteNonQuery();
                Połączenie.Close();
                //=========================================================
                Połączenie.Open();
                Polecenie2 = new SqlCommand();
                string polecenie2 = String.Format(@"
                UPDATE [dbo].[Zobowiazania]
                SET [DataZapłaty] = " + "'" + DateTime.Now.ToShortDateString() + "'" +
                @"WHERE [IdTransakcji] = '{0}' ", idtransakcji.ToString());

                Polecenie2 = new SqlCommand(polecenie2);
                Polecenie2.Connection = Połączenie;
                Polecenie2.ExecuteNonQuery();
                Połączenie.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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
