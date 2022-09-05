using Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Context
{
    public static class DataExtension
    {
        public static void UseAppDbContext(this IServiceCollection builder, IConfiguration configuration, bool isIntegrationTest = false)
        {
            builder.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ComprasGadoConnection"),
                sqlServerOptionsAction: sqlOptions =>
                {
                    sqlOptions.EnableRetryOnFailure(
                    maxRetryCount: 10,
                    maxRetryDelay: TimeSpan.FromSeconds(10),
                    errorNumbersToAdd: null);
                });
            });

            builder.AddScoped<DbContext, AppDbContext>();

            builder.AddScoped<AnimalRepository>();
            builder.AddScoped<PecuaristaRepository>();
            builder.AddScoped<CompraGadoRepository>();
            builder.AddScoped<CompraGadoItemRepository>();
        }
    }
}
