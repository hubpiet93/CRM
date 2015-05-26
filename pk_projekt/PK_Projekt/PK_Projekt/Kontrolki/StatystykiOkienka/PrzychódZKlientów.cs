using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Statystyki.Kontrakt;

namespace PK_Projekt.Kontrolki.StatystykiOkienka
{
    public partial class PrzychódZKlientów : UserControl
    {

        private List<object> Operacje;
        public PrzychódZKlientów(List<object> ListaOperacji)
        {
            InitializeComponent();
            Operacje = ListaOperacji;
            Wylicz();
        }


        private void Wylicz()
        {
            SqlDataReader Czytacz;

            Czytacz = (Operacje[5] as IBudujStatystyki).PrzychódPoKlinetach();
            if (Czytacz.HasRows)
            {
                Zklienta.Items.Clear();
                while (Czytacz.Read())
                {
                    ListViewItem listitems = new ListViewItem(Czytacz[0].ToString());
                    listitems.SubItems.Add(Czytacz[1].ToString());
                    listitems.SubItems.Add(Czytacz[2].ToString());
                    Zklienta.Items.Add(listitems);
                }
            }
            (Operacje[5] as IBudujStatystyki).PołączenieClose();
        }
    }
}
