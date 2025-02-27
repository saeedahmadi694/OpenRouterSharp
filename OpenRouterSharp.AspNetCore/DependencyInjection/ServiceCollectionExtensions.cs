using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OpenRouterSharp.AspNetCore.Config;
using OpenRouterSharp.Core.InfraServices;
using OpenRouterSharp.Core.Repositories;

namespace OpenRouterSharp.AspNetCore.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddVandarService(this IServiceCollection services, Action<OpenRouterSetting> configure)
    {
        services.Configure(configure);

        services.AddScoped((Func<IServiceProvider, IOpenRouterChatService>)(sp =>
        {
            var setting = sp.GetRequiredService<IOptionsMonitor<OpenRouterSetting>>().CurrentValue;
            return new OpenRouterChatService(
                setting.BaseUrl,
                setting.ApiKey
            );
        }));

        return services;
    }
}

