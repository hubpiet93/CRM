using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypOperacji.Kontrakt;
using System.Data.SqlClient;
using Wyświetl.Kontrakt;
using NowaUsługa.Kontrakt;

namespace PK_Projekt.Kontrolki
{
    public partial class WyświetlanieOkno : UserControl
    {
        private List<object> Operacje;

        public WyświetlanieOkno(List<object> ListaOperacji)
        {
            InitializeComponent();
            Operacje = ListaOperacji;
        }

        private void WyświetlButton_Click(object sender, EventArgs e)
        {
            try
            {
                ListaKlientów.Items.Clear();
                SqlDataReader Czytacz;
                Czytacz = (Operacje[3] as IWyświetl).WyświetlWszystkichKlientów();
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
                        listitems.SubItems.Add(Czytacz[7].ToString());
                        listitems.SubItems.Add(Czytacz[8].ToString());
                        listitems.SubItems.Add(Czytacz[9].ToString());
                        listitems.SubItems.Add(Czytacz[10].ToString());
                        listitems.SubItems.Add(Czytacz[11].ToString());
                        ListaKlientów.Items.Add(listitems);
                    }
                }
                (Operacje[3] as IWyświetl).PołączenieClose();

                Czytacz = (Operacje[3] as IWyświetl).WyświetlWszystkieTransakcje();
                if (Czytacz.HasRows)
                {
                    ListViewItem listitems;
                    ListView tabela = new ListView();
                    while (Czytacz.Read())
                    {
                        listitems = new ListViewItem(Czytacz[0].ToString());

                        listitems.SubItems.Add(Czytacz[1].ToString());
                        listitems.SubItems.Add(Czytacz[2].ToString());
                        listitems.SubItems.Add(Czytacz[3].ToString().Substring(0, 11));
                        listitems.SubItems.Add(Czytacz[4].ToString());
                        listitems.SubItems.Add(Czytacz[5].ToString());
                        listitems.SubItems.Add(Czytacz[6].ToString());
                        ListaTransakcji.Items.Add(listitems);
                   
                    } // na razie wyświetlanie będzie tylko tak 

                }

                (Operacje[3] as IWyświetl).PołączenieClose();
            }
            catch (Exception)
            {
            }
            
        }
        

    }
}
