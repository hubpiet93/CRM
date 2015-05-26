using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.Wcf;
using ObsługaKlienta.Implementacja;
using ObsługaKlienta.Kontrakt;
namespace ObsługaKlienta.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<ObsługaKlienta.Implementacja.ObsługaKlientaObiekt>().ToSelf();
            kernel.Bind<GetObsługaKlienta>().To<ObsługaKlienta.Implementacja.ObsługaKlientaObiekt>();

            using (var host = kernel.Get<NinjectServiceHost<ObsługaKlienta.Implementacja.ObsługaKlientaObiekt>>())
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
