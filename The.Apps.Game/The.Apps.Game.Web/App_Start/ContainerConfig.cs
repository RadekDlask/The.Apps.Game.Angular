using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using System.Data.Entity;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using The.Apps.Game.Core.Data.Database;
using The.Apps.Game.Core.Data.Repositories;

namespace The.Apps.Game.Web.App_Start
{
    internal static class ContainerConfig
    {
        public static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            RegisterServices(builder);
                        
            builder.RegisterType<GameDatabaseContext>().As<DbContext>().InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            var container = builder.Build();
            
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            var config = GlobalConfiguration.Configuration;
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            return container;
        }

        private static void RegisterServices(ContainerBuilder containerBuilder)
        {
            ServicesConfig.RegisterServices(containerBuilder);
        }
    }
}