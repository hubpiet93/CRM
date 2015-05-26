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

namespace PK_Projekt.Kontrolki
{
    public partial class DaneKlientaOkno : UserControl
    {
        private List<object> Operacje;
        private SqlDataReader Czytacz;
        private List<int> ListaIndeksów;
        private int wybranyklient;
        private bool wybieranie = false;

        public DaneKlientaOkno(List<object> ListaOperacji)
        {
            InitializeComponent();
            Operacje = ListaOperacji;
            ListaIndeksów = new List<int>();
            WypełnijCombo();
        }

        private void CofnijButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
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

        private void Zobacz_Click(object sender, EventArgs e)
        {
            
            if (ComboKlienci.SelectedIndex != -1)
            {
                String DaneKlineta;
                wybranyklient = ListaIndeksów[ComboKlienci.SelectedIndex];
                Czytacz = (Operacje[3] as IWyświetl).WyświetlDanePersonalne(wybranyklient);
                Czytacz.Read();
                DaneKlineta = String.Format(@"Imie/Firma : " + Czytacz[1] +
                                           "\r\nNazwisko : " + Czytacz[2] +
                                           "\r\nPesel : " + Czytacz[3] +
                                           "\r\nNip : " + Czytacz[4] +
                                           "\r\nKod pocztowy : " + Czytacz[5] +
                                           "\r\nMiasto : " + Czytacz[6] +
                                           "\r\nUlica : " + Czytacz[7] +
                                           "\r\nNumer domu : " + Czytacz[8] +
                                           "\r\nNumer mieszkania : " + Czytacz[9] +
                                           "\r\nEMail : " + Czytacz[10] +
                                           "\r\nNumer telefonu : " + Czytacz[11]);
                DaneKlientaText.Text = DaneKlineta;
                (Operacje[3] as IWyświetl).PołączenieClose();

            }
        }
    }
}
