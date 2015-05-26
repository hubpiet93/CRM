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
using Wyświetl.Kontrakt;
using ObsługaKlienta.Kontrakt;

namespace PK_Projekt.Kontrolki
{
    public partial class UregulowanieOkno : UserControl
    {
        private List<object> Operacje;
        private SqlDataReader Czytacz;
        private List<int> ListaIndeksówTransakcje;
        private int wybranatransakcja;
        private bool wybieranie = false;

        public UregulowanieOkno(List<object> ListaOperacji)
        {
            InitializeComponent();
            Operacje = ListaOperacji;
            ListaIndeksówTransakcje = new List<int>();
            WypełnijCombo();
        }

        private void WypełnijCombo()
        {
            ComboTransakcje.Items.Clear();
            ComboTransakcje.SelectedItem = null;

            try
            {
                Czytacz = (Operacje[3] as IWyświetl).WyświetlTransakcjeZOdroczeniem();
                if (Czytacz.HasRows)
                {
                    ListaIndeksówTransakcje = new List<int>();
                    while (Czytacz.Read())
                    {
                        ListaIndeksówTransakcje.Add(Convert.ToInt32(Czytacz[0]));
                        ComboTransakcje.Items.Add("Id transakcji: " + Czytacz[0] + ", Id klienta " + Czytacz[1] + ", Id Usługi " + Czytacz[2] + ", Data transakcji: " + Czytacz[3].ToString().Substring(0, 10));
                    }
                }
                (Operacje[3] as IWyświetl).PołączenieClose();
            }
            catch (Exception)
            {
            }
        }

        private void Zapłać_Click_1(object sender, EventArgs e)
        {
            if (ComboTransakcje.SelectedIndex != -1)
            {
                wybranatransakcja = ListaIndeksówTransakcje[ComboTransakcje.SelectedIndex];
                (Operacje[2] as IObsługaKlienta).ZapłaćObciążenie(wybranatransakcja);
            }
            WypełnijCombo();
        }

        private void CofnijButton_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
