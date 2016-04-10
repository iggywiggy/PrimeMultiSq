using System;
using Microsoft.Practices.Unity;
using PrimeMultiSq.BusinessLogic;
using PrimeMultiSq.BusinessLogic.Interfaces;
using PrimeMultiSq.Calculations;
using PrimeMultiSq.Calculations.Interfaces;
using PrimeMultiSq.Control.Interfaces;

namespace PrimeMultiSq.Control
{
    public sealed class DiContainer : IDisposable
    {
        private static DiContainer _instance;

        private DiContainer()
        {
            Container = new UnityContainer();
            RegisterTypes();
        }

        public static DiContainer Instance => _instance ?? (_instance = new DiContainer());

        public IUnityContainer Container { get; }


        public void Dispose()
        {
            Container.Dispose();
        }


        private void RegisterTypes()
        {
            Container.RegisterType<IMainController, MainController>();
            Container.RegisterType<IGridCreator, GridCreator>();
            Container.RegisterType<IOutput, Output>();
            Container.RegisterType<IPrimeGenerator, PrimeGenerator>();
            Container.RegisterType<IRowCreator, RowCreator>();
        }

        public IMainController ResolveMainController()
        {
            return Container.Resolve<MainController>();
        }
    }
}