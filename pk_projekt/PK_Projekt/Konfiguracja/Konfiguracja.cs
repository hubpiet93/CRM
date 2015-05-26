using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Konfiguracja.Moduły;
namespace Konfiguracja
{
    public class Konfiguracja
    {
        private static IKernel Kontener;

        public static IKernel KONTENER
        {
            get
            {
                if (Kontener == null)
                    Kontener = TworzenieKontenera();
                return Kontener;
            }
        }

        private static IKernel TworzenieKontenera()
        {
            var kernel = new StandardKernel(
                new BazaDanychModuł(),
                new LogowanieModuł()
                );
            return kernel;
        }
    }
}
