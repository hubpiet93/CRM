using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wyświetl.Kontrakt;
using System.Data.SqlClient;
using Statystyki.Kontrakt;

namespace PK_Projekt.Kontrolki.StatystykiOkienka
{
    public partial class ZobowiązaniaNaKliencieOkno : UserControl
    {
        private List<object> Operacje;
        private SqlDataReader Czytacz;
        private List<int> ListaIndeksówKlienci;
        private int wybranyklient;
        private bool wybieranie = false;

        public ZobowiązaniaNaKliencieOkno(List<object> ListaOperacji)
        {
            InitializeComponent();
            Operacje = ListaOperacji;
            ListaIndeksówKlienci = new List<int>();
            WypełnijComboKlienci();

        }

        private void Zobacz_Click(object sender, EventArgs e)
        {
            if (!(ComboKlienci.SelectedIndex == -1))
            {
                wybranyklient = ListaIndeksówKlienci[ComboKlienci.SelectedIndex];
                Czytacz = (Operacje[5] as IBudujStatystyki).ZobowiązaniaNaKliencie(DataOd.Value.ToShortDateString().ToString(),
                                                                                DataDo.Value.ToShortDateString().ToString(),
                                                                                wybranyklient);
                try
                {
                    ZobowiązaniaList.Items.Clear();
                    if (Czytacz.HasRows)
                    {
                        while (Czytacz.Read())
                        {
                            
                            ListViewItem listitems = new ListViewItem(Czytacz[0].ToString());
                            listitems.SubItems.Add(Czytacz[1].ToString());
                            listitems.SubItems.Add(Czytacz[2].ToString());
                            listitems.SubItems.Add(Czytacz[3].ToString());
                            listitems.SubItems.Add(Czytacz[4].ToString());
                            listitems.SubItems.Add(Czytacz[5].ToString());
                            listitems.SubItems.Add(Czytacz[6].ToString());
                            listitems.SubItems.Add(Czytacz[7].ToString().Substring(0, 11));
                            ZobowiązaniaList.Items.Add(listitems);
                        }
                    }
                    (Operacje[5] as IBudujStatystyki).PołączenieClose();
                }
                catch (Exception ee)
                {
                    ZobowiązaniaList.Items.Clear();
                   // (Operacje[5] as IBudujStatystyki).PołączenieClose();
                }
           
            }
        }



        private void WypełnijComboKlienci()
        {
            ComboKlienci.Items.Clear();
            ComboKlienci.SelectedItem = null;
            Czytacz = (Operacje[3] as IWyświetl).WyświetlWszystkichKlientów();
            if (Czytacz.HasRows)
            {
                while (Czytacz.Read())
                {
                    ListaIndeksówKlienci.Add(Convert.ToInt32(Czytacz[0]));
                    ComboKlienci.Items.Add("Id: " + Czytacz[0] + " " + Czytacz[1] + " " + Czytacz[2] + " Pesel: " + Czytacz[3]);
                }
            }
            (Operacje[3] as IWyświetl).PołączenieClose();
        }
    }
}
