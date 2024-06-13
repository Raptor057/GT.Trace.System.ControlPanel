using Common.Common.CleanArch;
using GT.Trace.System.ControlPanel.App;
using GT.Trace.System.ControlPanel.Infra;

namespace GT.Trace.System.ControlPanel.WebApi
{
    public static class ServiceCollectionEx
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            var config = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", false, true)
                    .Build();

            return services
                .AddSingleton(config)
                .AddInfraServices(config)
                .AddSingleton(typeof(ResultViewModel<>))
                .AddSingleton(typeof(GenericViewModel<>))
                .AddAppServices()
                .AddMediatR(cfg => { cfg.RegisterServicesFromAssembly(typeof(ServiceCollectionEx).Assembly); });
        }
    }
}
