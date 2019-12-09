using System;

namespace Epam.DiService
{
    public class ServiceDescriptor
    {
        public object ImplementationInstance { get; set; }
        public Type ServiceType { get; set; }
        public Type ImplementationType { get; set; }
        public Lifetime lifetime { get; set; }
        public ServiceDescriptor(Type serviceType, Lifetime _lifetime)
        {
            ServiceType = serviceType;
            lifetime = _lifetime;
        }
        public ServiceDescriptor(object implementation, Lifetime _lifetime)
        {
            ServiceType = implementation.GetType();
            ImplementationInstance = implementation;
            lifetime = _lifetime;
        }
        public ServiceDescriptor(Type serviceType, Type implementationType, Lifetime _lifetime)
        {
            ServiceType = serviceType;
            ImplementationType = implementationType;
            lifetime = _lifetime;
        }
    }
}
