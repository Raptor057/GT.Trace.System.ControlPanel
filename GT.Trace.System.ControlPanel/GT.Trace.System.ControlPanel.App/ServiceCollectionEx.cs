using Common.Common.CleanArch;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace GT.Trace.System.ControlPanel.App
{
    public static class ServiceCollectionEx
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            return services
                .AddTransient(typeof(IPipelineBehavior<,>), typeof(InteractorPipeline<,>))
                .AddMediatR(cfg => { cfg.RegisterServicesFromAssembly(typeof(ServiceCollectionEx).Assembly); });
        }
    }
}
