using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.Wcf;
using Wyświetl.Implementacja;
using Wyświetl.Kontrakt;

namespace Wyświetl.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<Wyświetl.Implementacja.WyświetlObiekt>().ToSelf();
            kernel.Bind<GetWyświetl>().To<Wyświetl.Implementacja.WyświetlObiekt>();

            using (var host = kernel.Get<NinjectServiceHost<Wyświetl.Implementacja.WyświetlObiekt>>())
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
