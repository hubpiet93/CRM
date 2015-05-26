using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BazaDanych.Kontrakt;
using TypOperacji.Kontrakt;
using HistoriaTransakcji.Kontrakt;
using NowaUsługa.Kontrakt;
using ObsługaKlienta.Kontrakt;
using Statystyki.Kontrakt;
using TypOperacji.Kontrakt;
using WysyłanieMaili.Kontrakt;
using Wyświetl.Kontrakt;
using System.Data.SqlClient;
using Rejestracja.Kontrakt;
using System.Windows.Forms;
namespace BazaDanych.Implementacja
{
    public class BazaDanych : IListaOperacji
    {
        private GetHistoriaTransakcji HistoriaTransakcjiIn;
        private GetDodajUsługę DodajUsługęIn;
        private GetObsługaKlienta ObsługaKlientaIn;
        private GetRejestracja RejestracjaIn;
        private GetBudujStatystyki BudujStatystykiIn;
        private GetOperacjeMail WysyłanieMailiIn;
        private GetWyświetl WyświetlIn;

        private string Połączenie = String.Format(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + @"\BazaDanychProjekt.mdf" + @";Integrated Security=True");                                                                             //(@"Data Source=(localdb)\Projects;Initial Catalog=" + "\"BazaDanych\"" + ";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");         
       
        public BazaDanych(GetRejestracja RejestracjaIn,
            GetOperacjeMail WysyłanieMailiIn,
            GetObsługaKlienta ObsługaKlientaIn,
            GetWyświetl WyświetlIn,
            GetDodajUsługę DodajUsługęIn,
            GetBudujStatystyki BudujStatystykiIn,
            GetHistoriaTransakcji HistoriaTransakcjiIn
            )
        {
            this.RejestracjaIn = RejestracjaIn;
            this.WysyłanieMailiIn = WysyłanieMailiIn;
            this.ObsługaKlientaIn = ObsługaKlientaIn;
            this.WyświetlIn = WyświetlIn;
            this.DodajUsługęIn = DodajUsługęIn;
            this.BudujStatystykiIn = BudujStatystykiIn;
            this.HistoriaTransakcjiIn = HistoriaTransakcjiIn;
        }

        public string GetPołączenie
        {
            get 
            {
                return Połączenie;
            }
        }

        public Dodaj DodajKlienta
        {
            get 
            {
                Dodaj RejestracjaTmp = this.RejestracjaIn.GetDodaj();
                return RejestracjaTmp;
            }
        }

        public ObsługaKlienta.Kontrakt.ObsługaKlienta ObsługaKlienta
        {
            get 
            {
                ObsługaKlienta.Kontrakt.ObsługaKlienta ObsługaTmp = this.ObsługaKlientaIn.GetObsługaKlienta();
                return ObsługaTmp;
            }
        }

        public DodajUsługę DodajUsługę
        {
            get 
            {
                DodajUsługę DodajUsługęTmp = this.DodajUsługęIn.GetDodajUsługę();
                return DodajUsługęTmp;
            }
        }

        public HistoriaTransakcji.Kontrakt.HistoriaTransakcji HistoriaTransakcji
        {
            get 
            {
                HistoriaTransakcji.Kontrakt.HistoriaTransakcji HistoriaTransakcjiTmp = this.HistoriaTransakcjiIn.GetHistoriaTransakcji();
                return HistoriaTransakcjiTmp;
            }
        }

        public BudujStatystyki Statystyki
        {
            get 
            {
                BudujStatystyki BudujStatystykiTmp = this.BudujStatystykiIn.GetBudujStatystyki();
                return BudujStatystykiTmp;
            }
        }

        public OperacjeMail WysyłanieMaili
        {
            get 
            {
                OperacjeMail OperacjeMailTmp = this.WysyłanieMailiIn.GetOperacjeMail();
                return OperacjeMailTmp;
            }
        }

        public Wyświetl.Kontrakt.Wyświetl Wyświetl
        {
            get 
            {
                Wyświetl.Kontrakt.Wyświetl WyświetlTmp = this.WyświetlIn.GetWyświetl();
                return WyświetlTmp;
            }
        }
    }
}
