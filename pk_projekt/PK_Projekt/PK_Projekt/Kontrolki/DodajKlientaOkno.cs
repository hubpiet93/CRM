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
using Rejestracja.Kontrakt;
using System.Text.RegularExpressions;
namespace PK_Projekt.Kontrolki
{
    public partial class DodajKlientaOkno : UserControl
    {
        private List<object> Operacje;
        private bool poprawność;
        public DodajKlientaOkno(List<object> ListaOperacji)
        {
            InitializeComponent();
            poprawność = true;
            Operacje = ListaOperacji;
        }

        private void CofnijButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DodajButton_Click(object sender, EventArgs e)
        {
            sprawdzpoprawnosc();
            if ((!(Imię.Text == "" || Pesel.Text == "" || KodPocztowy.Text == "" || Miasto.Text == "" || NumerDomu.Text == ""))&&poprawność)
            {
                string PolecenieSql = String.Format(
                                       @"insert into [dbo].[Klienci]
                                       ([Imię/NazwaFirmy],[Nazwisko],[PESEL/REGON],[NIP],[Kod],[Miasto],[Ulica],[NumerDomu],[NumerMieszkania] ,[EMail],[Telefon])
                                       values
                                       ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", Imię.Text, Nazwisko.Text, Pesel.Text, Nip.Text, KodPocztowy.Text, Miasto.Text, Ulica.Text, NumerDomu.Text, NumerMieszkania.Text, EMail.Text, Telefon.Text);
                try
                {
                    (Operacje[0] as IDodaj).DodajKlienta(PolecenieSql);
                    Imię.Text = "";
                    Nazwisko.Text = "";
                    Pesel.Text = "";
                    Nip.Text = "";
                    KodPocztowy.Text = "";
                    Miasto.Text = "";
                    Ulica.Text = "";
                    NumerDomu.Text = "";
                    NumerMieszkania.Text = "";
                    EMail.Text = "";
                    Telefon.Text = "";
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message);
                }
            }
        }

        private void sprawdzpoprawnosc()
        {
            Regex Regular;
            bool pimie = true;
            bool pnazwisko = true;
            bool ppesel = true;
            bool pnip = true;
            bool pkod = true;
            bool pmiasto = true;
            bool pulica = true;
            bool pdom = true;
            bool pmieszkanie = true;
            bool pemail = true;
            bool ptelefon = true;
            if (Imię.Text!="")
            {
                  Regular = new Regex(@"^([A-Z][a-z]{2,})|([a-z]{2,})|([A-Z]{2,})$");
                  Match Sprawdzenie = Regular.Match(Imię.Text);
                  if (!Sprawdzenie.Success)
                  {
                      PoprawneImię.Text = "**";
                      pimie = false;
                  }
                  else
                  {
                      PoprawneImię.Text = "";
                      pimie = true;
                  }
            }
            else
            {
                pimie = false;
            }
            
            if (Nazwisko.Text != "")
            {
                Regular = new Regex(@"^([A-Z][a-z]{2,})|([a-z]{2,})|([A-Z]{2,})$");
                Match Sprawdzenie = Regular.Match(Nazwisko.Text);
                if (!Sprawdzenie.Success)
                {
                    PoprawneNazwisko.Text = "**";
                    pnazwisko = false;
                }
                else
                {
                    PoprawneNazwisko.Text = "";
                    pnazwisko = true;
                }
            }
            
            if (Pesel.Text != "")
            {
                Regular = new Regex(@"^[0-9]{11}$");
                Match Sprawdzenie = Regular.Match(Pesel.Text);
                if (!Sprawdzenie.Success)
                {
                    PoprawnyPesel.Text = "**";
                    ppesel = false;
                }
                else
                {
                    PoprawnyPesel.Text = "";
                    ppesel = true;
                }
            }
            else
            {
                ppesel = false;
            }

            if (Nip.Text != "")
            {
                Regular = new Regex("^(([0-9]{10})|(([0-9]{3}-){2}([0-9]{2}-){1}[0-9]{2}))$");
                Match Sprawdzenie = Regular.Match(Nip.Text);
                if (!Sprawdzenie.Success)
                {
                    PoprawnyNip.Text = "**";
                    pnip = false;
                }
                else
                {
                    PoprawnyNip.Text = "";
                    pnip = true;
                }
            }
            
            if (KodPocztowy.Text!= "")
            {
                Regular = new Regex("^[0-9]{2}-[0-9]{3}$");
                Match Sprawdzenie = Regular.Match(KodPocztowy.Text);
                if (!Sprawdzenie.Success)
                {
                    PoprawnyKod.Text = "**";
                    pkod = false;
                }
                else
                {
                    PoprawnyKod.Text = "";
                    pkod = true;
                }
            }
            else
            {
                pkod = false;
            }
           
            if (Miasto.Text != "")
            {
                Regular = new Regex(@"^([A-Z][a-z]{2,})|([a-z]{2,})|([A-Z]{2,})$");
                Match Sprawdzenie = Regular.Match(Miasto.Text);
                if (!Sprawdzenie.Success)
                {
                    PoprawneMiasto.Text = "**";
                    pmiasto = false;
                }
                else
                {
                    PoprawneMiasto.Text = "";
                    pmiasto = true;
                }
            }
            else
            {
                pmiasto = false;
            }
            if (Ulica.Text != "")
            {
                Regular = new Regex(@"^([A-Z][a-z]{2,})|([a-z]{2,})|([A-Z]{2,})$");
                Match Sprawdzenie = Regular.Match(Ulica.Text);
                if (!Sprawdzenie.Success)
                {
                    PoprawnaUlica.Text = "**";
                    pulica = false;
                }
                else
                {
                    PoprawnaUlica.Text = "";
                    pulica = true;
                }
            }

            if (NumerDomu.Text != "")
            {
                Regular = new Regex("^(([0-9]{1,3})|(^$))$");
                Match Sprawdzenie = Regular.Match(NumerDomu.Text);
                if (!Sprawdzenie.Success)
                {
                    PoprawnyDom.Text = "**";
                    pdom = false;   
                }
                else
                {
                    PoprawnyDom.Text = "";
                    pdom = true;
                }
            }
            else
            {
                pdom = false;
            }

            if (NumerMieszkania.Text != "")
            {
                Regular = new Regex("^(([0-9]{1,3})|(^$))$");
                Match Sprawdzenie = Regular.Match(NumerMieszkania.Text);
                if (!Sprawdzenie.Success)
                {
                    PoprawneMieszkanie.Text = "**";
                    pmieszkanie = false;
                }
                else
                {
                    PoprawneMieszkanie.Text = "";
                    pmieszkanie = true;
                }
            }
            
            if (EMail.Text != "")
            {
                Regular = new Regex(@"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@" + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\." + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|" + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$");
                Match Sprawdzenie = Regular.Match(EMail.Text);
                if (!Sprawdzenie.Success)
                {
                    PoprawnyEmail.Text = "**";
                    pemail = false;
                }
                else
                {
                    PoprawnyEmail.Text = "";
                    pemail = true;
                }
            }

            if (Telefon.Text != "")
            {
                Regular = new Regex("^([0-9]{9})|(([0-9]{3}-){2}[0-9]{3})$");
                Match Sprawdzenie = Regular.Match(Telefon.Text);
                if (!Sprawdzenie.Success)
                {
                    PoprawnyTelefon.Text = "**";
                    ptelefon = false;
                }
                else
                {
                    PoprawnyTelefon.Text = "";
                    ptelefon = true;
                }
            }

            if (pimie == true && pnazwisko == true && ppesel == true && pnip == true && pkod == true && pmiasto == true && pulica == true && pdom == true && pmieszkanie == true && pemail == true && ptelefon == true)
            {
                poprawność = true;
            }
            else
            {
                poprawność = false;
            }
        }
    }
}
