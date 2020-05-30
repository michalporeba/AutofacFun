using Autofac;

namespace AutofacFun.Service
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterSource(new ConfigurationRegistrationSource());
            builder.RegisterType<ConfigurableAction>().As<IConfigurableAction>();
            builder.RegisterType<ActionOne>().As<IActionOne>();
            builder.RegisterType<ActionTwo>().As<IActionTwo>();
        }
    }
}