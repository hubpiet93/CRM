using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.Wcf;
using Rejestracja.Implementacja;
using Rejestracja.Kontrakt;

namespace Rejestracja.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<Rejestracja.Implementacja.RejestracjaObiekt>().ToSelf();
            kernel.Bind<GetRejestracja>().To<Rejestracja.Implementacja.RejestracjaObiekt>();

            using (var host = kernel.Get<NinjectServiceHost<Rejestracja.Implementacja.RejestracjaObiekt>>())
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
