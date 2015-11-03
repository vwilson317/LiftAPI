using System.Reflection;
using Autofac;
using Autofac.Integration.WebApi;
using Resources;

namespace IoC
{
    public class Bootstrapper
    {
        public static IContainer Initialize(Assembly webAssembly)
        {
            var builder = new ContainerBuilder();

            if (webAssembly != null)
            {
                builder.RegisterApiControllers(webAssembly);
                builder.RegisterAssemblyTypes(webAssembly).AsImplementedInterfaces();
            }
            builder.RegisterAssemblyTypes(typeof (IocAssemblyStarter).Assembly).AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(typeof (Domain.IocAssemblyStarter).Assembly).AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(typeof (Repository.IocAssemblyStarter).Assembly).AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(typeof (RepositoryService.IocAssemblyStarter).Assembly).AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(typeof (Resources.IocAssemblyStarter).Assembly).AsImplementedInterfaces();

            return builder.Build();
        }


    }
}
