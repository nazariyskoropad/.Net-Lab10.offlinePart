using System;
using System.Collections.Generic;
using System.Linq;

namespace Epam.DiService
{
    public class IoCContainer
    {
        List<ServiceDescriptor> _serviceDescriptors = null;
        public IoCContainer(List<ServiceDescriptor> serviceDescriptors)
        {
            _serviceDescriptors = serviceDescriptors;
        }
        public object GetService(Type serviceType)
        {
            var descriptor = _serviceDescriptors.SingleOrDefault(x => x.ServiceType == serviceType);

            if (descriptor == null)
            {
                throw new Exception(serviceType.Name + " - service hasn't been registered yet");
            }

            if (descriptor.ImplementationInstance != null)
            {
                return descriptor.ImplementationInstance;
            }

            Type actualType;
            if (descriptor.ImplementationType == null)
                actualType = descriptor.ServiceType;
            else
                actualType = descriptor.ImplementationType;

            var implementation = Activator.CreateInstance(actualType,
                actualType.GetConstructors().First().GetParameters()
                .Select(x => GetService(x.ParameterType)).ToArray());

            if (descriptor.lifetime == Lifetime.Singleton)
            {
                descriptor.ImplementationInstance = implementation;
            }

            return implementation;
        }
        public T GetService<T>()
        {
            return (T)GetService(typeof(T));
        }
    }
}
