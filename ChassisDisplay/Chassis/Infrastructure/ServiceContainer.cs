using System;
using System.Collections.Generic;

namespace Chassis.Infrastructure
{
    public class ServiceContainer
    {
        private readonly Dictionary<Type, object> _instances = new Dictionary<Type, object>();

        public static ServiceContainer Instance;

        static ServiceContainer()
        {
            Instance = new ServiceContainer();
        }

        private ServiceContainer()
        {
        }

        public T Get<T>()
        {
            var type = typeof(T);
            return (T)_instances[type];
        }

        public void Register<T>(T obj)
        {
            var type = typeof(T);
            _instances[type] = obj;
        }
    }
}
