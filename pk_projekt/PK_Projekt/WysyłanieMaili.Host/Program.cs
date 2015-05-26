using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.Wcf;
using WysyłanieMaili.Implementacja;
using WysyłanieMaili.Kontrakt;

namespace WysyłanieMaili.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<WysyłanieMaili.Implementacja.WysyłanieMailiObiekt>().ToSelf();
            kernel.Bind<GetOperacjeMail>().To<WysyłanieMaili.Implementacja.WysyłanieMailiObiekt>();

            using (var host = kernel.Get<NinjectServiceHost<WysyłanieMaili.Implementacja.WysyłanieMailiObiekt>>())
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
