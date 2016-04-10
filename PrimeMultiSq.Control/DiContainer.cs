using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        private readonly IUnityContainer _container;
        private static DiContainer _instance;

        private DiContainer()
        {
            _container = new UnityContainer();
            RegisterTypes();
        }

        public static DiContainer Instance => _instance ?? (_instance = new DiContainer());

        public IUnityContainer Container => _container;



        private void RegisterTypes()
        {
            _container.RegisterType<IMainController, MainController>();
            _container.RegisterType<IGridCreator, GridCreator>();
            _container.RegisterType<IOutput, Output>();
            _container.RegisterType<IPrimeGenerator, PrimeGenerator>();
            _container.RegisterType<IRowCreator, RowCreator>();


        }

        public IMainController ResolveMainController()
        {
            return _container.Resolve<MainController>();
        }

 


        public void Dispose()
        {
            _container.Dispose();
        }
    }
}
