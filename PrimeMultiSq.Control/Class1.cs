using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.Practices.Unity;

namespace PrimeMultiSq.Control
{
    public class DiContainer : IDisposable
    {
        private readonly IUnityContainer _container;
        private DiContainer _instance;

        private DiContainer()
        {
            _container = new UnityContainer();
            RegisterToContainer();
        }

        public DiContainer Instance => _instance ?? (_instance = new DiContainer());

        public IUnityContainer Container => _container;


        private void RegisterTypes(IEnumerable<Type> types)
        {
            if(types == null)
                throw new ArgumentNullException(nameof(types));

            _container.RegisterTypes(types, WithMappings.FromAllInterfaces, WithName.TypeName,
                WithLifetime.ContainerControlled);
        }

        private void RegisterToContainer()
        {
            foreach (var assembly in GetAssemblies())
            {
                RegisterTypes(assembly.GetTypes());
            }
        }

        private IEnumerable<Assembly> GetAssemblies()
        {
            return AppDomain.CurrentDomain.GetAssemblies().Where(a => a.FullName.StartsWith("PrimeMultiSq"));
        }

        public void Dispose()
        {
            _container.Dispose();
        }
    }
}
