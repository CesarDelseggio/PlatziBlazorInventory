using Business.Interfaces;
using Business.Services;
using Entities;
using Microsoft.Extensions.DependencyInjection;

namespace PlatzuBlazorInventory.Services
{
    public static class ServicesConfig
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddSingleton<IServices<Product>, Services<Product>>();
            services.AddSingleton<IServices<Category>, Services<Category>>();
            services.AddSingleton<IServices<Storage>, StorageServices>();
            services.AddSingleton<IServices<WereHouse>, Services<WereHouse>>();
            services.AddSingleton<IServices<InputOutput>, Services<InputOutput>>();

            return services;
        }
    }
}
