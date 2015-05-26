using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Konfiguracja;
using Ninject;
using TypOperacji.Kontrakt;
using System.Data.SqlClient;
namespace PK_Projekt
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static IKernel Kontener = Konfiguracja.Konfiguracja.KONTENER;
        [STAThread]
        static void Main()
        {
            Kontener = Konfiguracja.Konfiguracja.KONTENER;
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public   static IKernel GetKontener
        {
            get
            {
                if (Kontener == null)
                {
                    return Konfiguracja.Konfiguracja.KONTENER;
                }
                else
                {
                    return Kontener;
                }
                
            }
        }
        public static List<object> LISTAOPERACJI
        {
            get
            {
                SqlConnection Połączenie =  new SqlConnection(GetKontener.Get<BazaDanych.Kontrakt.IListaOperacji>().GetPołączenie);
                List<object> ListaOperacji = new List<object>();
                ListaOperacji.Add(GetKontener.Get<BazaDanych.Kontrakt.IListaOperacji>().DodajKlienta);
                        (ListaOperacji[0] as Rejestracja.Kontrakt.Dodaj).SetPołączenie = Połączenie;
                ListaOperacji.Add(GetKontener.Get<BazaDanych.Kontrakt.IListaOperacji>().WysyłanieMaili);
                ListaOperacji.Add(GetKontener.Get<BazaDanych.Kontrakt.IListaOperacji>().ObsługaKlienta);
                        (ListaOperacji[2] as ObsługaKlienta.Kontrakt.ObsługaKlienta).SetPołączenie = Połączenie;
                ListaOperacji.Add(GetKontener.Get<BazaDanych.Kontrakt.IListaOperacji>().Wyświetl);
                        (ListaOperacji[3] as Wyświetl.Kontrakt.Wyświetl).SetPołączenie = Połączenie;
                ListaOperacji.Add(GetKontener.Get<BazaDanych.Kontrakt.IListaOperacji>().DodajUsługę);
                        (ListaOperacji[4] as NowaUsługa.Kontrakt.DodajUsługę).SetPołączenie = Połączenie;
                ListaOperacji.Add(GetKontener.Get<BazaDanych.Kontrakt.IListaOperacji>().Statystyki);
                        (ListaOperacji[5] as Statystyki.Kontrakt.BudujStatystyki).SetPołączenie = Połączenie;
                ListaOperacji.Add(GetKontener.Get<BazaDanych.Kontrakt.IListaOperacji>().HistoriaTransakcji);
                        (ListaOperacji[6] as HistoriaTransakcji.Kontrakt.HistoriaTransakcji).SetPołączenie = Połączenie;
                return ListaOperacji;
            }
        }
    }
}
