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
using HistoriaTransakcji.Kontrakt;

namespace PK_Projekt.Kontrolki
{
    public partial class HistoriaTransakcjiOkno : UserControl
    {
        private SqlDataReader Czytacz;
        private List<object> Operacje;
        private List<int> ListaIndeksów;
        private int wybranyklient;
        public HistoriaTransakcjiOkno(List<object> ListaOperacji)
        {
            InitializeComponent();
            ListaIndeksów = new List<int>();
            Operacje = ListaOperacji;
            
            WypełnijCombo();
        }

        private void CofnijButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ZobaczHistorięTransakcji_Click(object sender, EventArgs e)
        {
            if (ComboKlienci.SelectedIndex > -1)
            {
                wybranyklient = ListaIndeksów[ComboKlienci.SelectedIndex];
                try
                {
                    Czytacz = (Operacje[6] as IHistoriaTransakcji).Historia(wybranyklient);
                    if (Czytacz.HasRows)
                    {
                        ListViewItem listitems;
                        ListView tabela = new ListView();
                        HistoriaTransakcji.Items.Clear();
                        while (Czytacz.Read())
                        {
                            listitems = new ListViewItem(Czytacz[0].ToString());

                            listitems.SubItems.Add(Czytacz[2].ToString());
                            listitems.SubItems.Add(Czytacz[3].ToString().Substring(0, 10));
                            listitems.SubItems.Add(Czytacz[4].ToString());
                            listitems.SubItems.Add(Czytacz[5].ToString());
                            listitems.SubItems.Add(Czytacz[6].ToString());
                            HistoriaTransakcji.Items.Add(listitems);
                        } 
                        (Operacje[6] as IHistoriaTransakcji).PołączenieClose();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void WypełnijCombo()
        {
            ComboKlienci.Items.Clear();
            ComboKlienci.SelectedItem = null;
            Czytacz = (Operacje[3] as IWyświetl).WyświetlWszystkichKlientów();
            if (Czytacz.HasRows)
            {
                while (Czytacz.Read())
                {
                    ListaIndeksów.Add(Convert.ToInt32(Czytacz[0]));
                    ComboKlienci.Items.Add("Id: " + Czytacz[0] + " " + Czytacz[1] + " " + Czytacz[2] + " Pesel: " + Czytacz[3]);
                }
            }
            (Operacje[3] as IWyświetl).PołączenieClose();
        }
    }
}
