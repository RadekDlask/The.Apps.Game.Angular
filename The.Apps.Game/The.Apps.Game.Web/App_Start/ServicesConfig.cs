using Autofac;
using The.Apps.Game.Core.Services;
using The.Apps.Game.Core.Services.Abstract;

namespace The.Apps.Game.Web.App_Start
{
    internal static class ServicesConfig
    {
        public static void RegisterServices(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<GameService>().As<IGameService>().InstancePerLifetimeScope();
        }
    }
}