using Services;

namespace API.DependencyInjection
{
    public static class DependencyContext
    {
        public static void ServicesInjection(this IServiceCollection services, bool disableHanFire = false, bool isIntegrationTest = false)
        {
            services.AddScoped<AnimalService>();
            services.AddScoped<CompraGadoService>();
            services.AddScoped<CompraGadoItemService>();
            services.AddScoped<PecuaristaService>();
        }
    }
}
