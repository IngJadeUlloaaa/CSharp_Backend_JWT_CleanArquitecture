using Microsoft.EntityFrameworkCore;
using Products_CleanArquitecture.Domain.Interfaces;
using Products_CleanArquitecture.Domain.Entities;
using Products_CleanArquitecture.Infrastructure.Repositories;
using Products_CleanArquitecture.Infrastructure.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Products_CleanArquitecture.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICustomersRepository, CustomersRepository>();
            services.AddScoped<IEdtProductsRepository, EditProductsRepository>();
            services.AddScoped<INewProductsRepository, NewProductsRepository>();
            services.AddScoped<IDeleteProductsRepository, DeleteProductsRepository>();

            return services;
        }
    }
}
