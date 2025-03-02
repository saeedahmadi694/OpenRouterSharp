using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OpenRouterSharp.AspNetCore.Config;
using OpenRouterSharp.Core.InfraServices;
using OpenRouterSharp.Core.Repositories;

namespace OpenRouterSharp.AspNetCore.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddOpenRouterService(this IServiceCollection services, Action<OpenRouterSetting> configure)
    {
        services.Configure(configure);

        services.AddScoped((Func<IServiceProvider, IOpenRouterService>)(sp =>
        {
            var setting = sp.GetRequiredService<IOptionsMonitor<OpenRouterSetting>>().CurrentValue;
            return new OpenRouterService(
                setting.BaseUrl,
                setting.ApiKey
            );
        }));

        return services;
    }
}

