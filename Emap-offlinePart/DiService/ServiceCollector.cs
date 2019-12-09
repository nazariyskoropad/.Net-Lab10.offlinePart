using System.Collections.Generic;

namespace Epam.DiService
{
    public class ServiceCollector
    {
        private List<ServiceDescriptor> _serviceDescriptors = new List<ServiceDescriptor>();
        public void RegisterTransient<TService>()
        {
            _serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), typeof(TService), Lifetime.Transient));
        }

        public void RegisterTransient<TService, TImplementation>()
        {
            _serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), typeof(TImplementation), Lifetime.Singleton));
        }
        public void RegisterSingleton<TService>()
        {
            _serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), Lifetime.Singleton));
        }

        public void RegisterSingleton<TService>(TService implementation)
        {
            _serviceDescriptors.Add(new ServiceDescriptor(implementation, Lifetime.Singleton));
        }

        public void RegisterSingleton<TService, TImplementation>()
        {
            _serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), typeof(TImplementation), Lifetime.Singleton));
        }
        public IoCContainer CreateContainer()
        {
            return new IoCContainer(_serviceDescriptors);
        }

    }
}
