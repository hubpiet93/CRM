using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using TypOperacji.Kontrakt;
using System.Data.SqlClient;
using HistoriaTransakcji.Kontrakt;
using WysyłanieMaili.Kontrakt;
using Wyświetl.Kontrakt;
using NowaUsługa.Kontrakt;
using Statystyki.Kontrakt;
using ObsługaKlienta.Kontrakt;
using Rejestracja.Kontrakt;
namespace BazaDanych.Kontrakt
{
    [ServiceContract]
    public interface IListaOperacji : IOperacja
    {

        Dodaj DodajKlienta 
        {
            [OperationContract]
            get;
        }
        ObsługaKlienta.Kontrakt.ObsługaKlienta ObsługaKlienta
        {
            [OperationContract]
            get;
        }
        NowaUsługa.Kontrakt.DodajUsługę DodajUsługę
        {
            [OperationContract]
            get;
        }
        HistoriaTransakcji.Kontrakt.HistoriaTransakcji HistoriaTransakcji
        {
            [OperationContract]
            get;
        }
        Statystyki.Kontrakt.BudujStatystyki Statystyki
        {
            [OperationContract]
            get;
        }
        WysyłanieMaili.Kontrakt.OperacjeMail WysyłanieMaili
        {
            [OperationContract]
            get;
        }
        Wyświetl.Kontrakt.Wyświetl Wyświetl
        {
            [OperationContract]
            get;
        }
        string GetPołączenie
        {
            [OperationContract] 
            get; 
        }
    }
}
