using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using System.ServiceModel;
using BazaDanych.Implementacja;
using BazaDanych.Kontrakt;
namespace Konfiguracja.Moduły
{
    class BazaDanychModuł : NinjectModule
    {
        public override void Load()
        {
            Bind<IListaOperacji>().ToMethod(ctx =>
            {
                var factory = new ChannelFactory<IListaOperacji>("BazaDanych");
                return factory.CreateChannel();
            }).InSingletonScope();
        }
    }
}
