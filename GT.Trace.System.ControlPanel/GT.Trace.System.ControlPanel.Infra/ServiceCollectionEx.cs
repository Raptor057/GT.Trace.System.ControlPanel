using Common.Common.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GT.Trace.System.ControlPanel.Infra
{
    public static class ServiceCollectionEx
    {
        public static IServiceCollection AddInfraServices(this IServiceCollection services, IConfigurationRoot configuration)
        {
            return services
                .AddLoggingServices(configuration);
                //.AddSingleton(typeof(ConfigurationSqlDbConnectionFactory<>))
                //.AddSingleton(typeof(ConfigurationSqlDbConnection<>))
                //.AddSingleton<GttSqlDB>()
                //.AddSingleton<ILabelParserService, LabelParserService>()
                //.AddSingleton<ITolerancesConfigService, TolerancesConfigService>()
                //.AddSingleton<ISaveEzMotorsGateway, SqlSaveEzMotorsGateway>();
        }

    }
}
