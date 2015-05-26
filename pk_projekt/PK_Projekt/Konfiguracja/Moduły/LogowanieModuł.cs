using Ninject.Modules;

namespace Konfiguracja.Moduły
{
    class LogowanieModuł : NinjectModule
    {
        public override void Load()
        {
            Bind<SystemLogowania.Contract.IUzytkownicy>().To<SystemLogowania.Implementation.Formularz>();
        }
    }
}
