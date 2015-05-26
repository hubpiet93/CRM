using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.Wcf;
using NowaUsługa.Implementacja;
using NowaUsługa.Kontrakt;
namespace NowaUsługa.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<NowaUsługa.Implementacja.NowaUsługaObiekt>().ToSelf();
            kernel.Bind<GetDodajUsługę>().To<NowaUsługa.Implementacja.NowaUsługaObiekt>();

            using (var host = kernel.Get<NinjectServiceHost<NowaUsługa.Implementacja.NowaUsługaObiekt>>())
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
