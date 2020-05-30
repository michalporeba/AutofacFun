using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using Autofac.Core;
using Autofac.Core.Activators.Delegate;
using Autofac.Core.Lifetime;
using Autofac.Core.Registration;
using Microsoft.Extensions.Configuration;

namespace AutofacFun.Service
{
    public class ConfigurationRegistrationSource : IRegistrationSource
    {
        public IEnumerable<IComponentRegistration> RegistrationsFor(Autofac.Core.Service service, Func<Autofac.Core.Service, IEnumerable<IComponentRegistration>> registrationAccessor)
        {
            if (!(service is IServiceWithType swt) 
                || !typeof(IConfiguration).IsAssignableFrom(swt.ServiceType))
            {
                // the requested registration cannot be provided by this source
                return Enumerable.Empty<IComponentRegistration>();
            }
            
            var registration = new ComponentRegistration(
                Guid.NewGuid(),
                new DelegateActivator(swt.ServiceType, (c, p) =>
                {
                    return Activator.CreateInstance(swt.ServiceType);
                }), 
                new CurrentScopeLifetime(), 
                InstanceSharing.None,
                InstanceOwnership.OwnedByLifetimeScope,
                new [] { service },
                new Dictionary<string, object>());
            
            return new IComponentRegistration[] { registration };
        }

        public bool IsAdapterForIndividualComponents => false;
    }
}