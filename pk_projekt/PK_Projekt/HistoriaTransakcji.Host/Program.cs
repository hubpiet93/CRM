using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.Wcf;
using HistoriaTransakcji.Implementacja;
using HistoriaTransakcji.Kontrakt;

namespace HistoriaTransakcji.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<HistoriaTransakcji.Implementacja.HistoriaObiekt>().ToSelf();
            kernel.Bind<GetHistoriaTransakcji>().To<HistoriaTransakcji.Implementacja.HistoriaObiekt>();

            using (var host = kernel.Get<NinjectServiceHost<HistoriaTransakcji.Implementacja.HistoriaObiekt>>())
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
