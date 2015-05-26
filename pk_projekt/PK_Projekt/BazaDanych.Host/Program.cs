using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.Wcf;
using BazaDanych.Implementacja;
using BazaDanych.Kontrakt;
using HistoriaTransakcji.Kontrakt;
using NowaUsługa.Kontrakt;
using ObsługaKlienta.Kontrakt;
using Rejestracja.Kontrakt;
using Statystyki.Kontrakt;
using TypOperacji.Kontrakt;
using WysyłanieMaili.Kontrakt;
using Wyświetl.Kontrakt;
using System.ServiceModel;
namespace BazaDanych.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<BazaDanych.Implementacja.BazaDanych>().ToSelf();
            kernel.Bind<IListaOperacji>().To<BazaDanych.Implementacja.BazaDanych>();

            kernel.Bind<GetRejestracja>().ToMethod(ctx =>
            {
                var factory = new ChannelFactory<GetRejestracja>("Rejestracja");
                return factory.CreateChannel();
            });
            kernel.Bind<GetObsługaKlienta>().ToMethod(ctx =>
            {
                var factory = new ChannelFactory<GetObsługaKlienta>("ObsługaKlienta");
                return factory.CreateChannel();
            });

            kernel.Bind<GetDodajUsługę>().ToMethod(ctx =>
            {
                var factory = new ChannelFactory<GetDodajUsługę>("NowaUsługa");
                return factory.CreateChannel();
            });

            kernel.Bind<GetHistoriaTransakcji>().ToMethod(ctx =>
            {
                var factory = new ChannelFactory<GetHistoriaTransakcji>("HistoriaTransakcji");
                return factory.CreateChannel();
            });

            kernel.Bind<GetBudujStatystyki>().ToMethod(ctx =>
            {
                var factory = new ChannelFactory<GetBudujStatystyki>("Statystyki");
                return factory.CreateChannel();
            });

            kernel.Bind<GetOperacjeMail>().ToMethod(ctx =>
            {
                var factory = new ChannelFactory<GetOperacjeMail>("WysyłanieMaili");
                return factory.CreateChannel();
            });

            kernel.Bind<GetWyświetl>().ToMethod(ctx =>
            {
                var factory = new ChannelFactory<GetWyświetl>("Wyświetl");
                return factory.CreateChannel();
            });


            using (var host = kernel.Get<NinjectServiceHost<BazaDanych.Implementacja.BazaDanych>>())
            {
                host.Open();
                
                Console.WriteLine("Serwis został uruchomiony pod adresem: {0}", host.BaseAddresses[0]);
                Console.WriteLine("Naciśnij dowolny klawisz aby zamknąć serwis");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
