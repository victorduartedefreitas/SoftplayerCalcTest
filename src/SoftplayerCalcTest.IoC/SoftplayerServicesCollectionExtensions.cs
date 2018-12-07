using SoftplayerCalcTest.Application.Services;
using SoftplayerCalcTest.Domain.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class SoftplayerServicesCollectionExtensions
    {
        public static IServiceCollection AddSoftplayerServices(this IServiceCollection services)
        {
            services.AddScoped<ICalculoJurosService, CalculoPadraoJurosService>();

            return services;
        }
    }
}
