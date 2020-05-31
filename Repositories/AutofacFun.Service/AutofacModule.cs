using Autofac;

namespace AutofacFun.Service
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<RepositoryAction>().As<IRepositoryAction>();
        }
    }
}