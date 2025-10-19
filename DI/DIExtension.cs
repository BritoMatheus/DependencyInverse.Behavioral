using DI.Behavioral.Dictionary.Enums;
using DI.Behavioral.Dictionary.Factories;
using DI.Behavioral.Dictionary.Interfaces;
using DI.Behavioral.Dictionary.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DI.Behavioral.Dictionary.DI;

public static class DIExtension
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<SqlEmailService>();
        services.AddScoped<DynamoEmailService>();

        services.AddScoped<IServiceFactory, ServiceFactory>(provider =>
            new ServiceFactory(
                new Dictionary<EType, Func<IEmailService>>()
                {
                    { EType.SQL, () => (IEmailService)provider.GetRequiredService(typeof(SqlEmailService)) },
                    { EType.DynamoDb, () => (IEmailService)provider.GetRequiredService(typeof(DynamoEmailService)) }
                }
            )
        );
    }
}
