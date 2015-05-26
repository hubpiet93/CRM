using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.Wcf;
using Statystyki.Implementacja;
using Statystyki.Kontrakt;

namespace Statystyki.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<Statystyki.Implementacja.StatystykiObiekt>().ToSelf();
            kernel.Bind<GetBudujStatystyki>().To<Statystyki.Implementacja.StatystykiObiekt>();

            using (var host = kernel.Get<NinjectServiceHost<Statystyki.Implementacja.StatystykiObiekt>>())
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
