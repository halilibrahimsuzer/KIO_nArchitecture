using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using nApplication.Services.Repositories;
using nPersistence.Repositories;
using nPersistence.Contexts;

namespace nPersistence
{
	public static class PersistenceServiceRegistration
	{
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
                                                                IConfiguration configuration)
        {
            services.AddDbContext<BaseDbContext>(options =>
                                                     options.UseSqlServer(
                                                         configuration.GetConnectionString("RentACarCampConnectionString")));
            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<ISomeFeatureEntityRepository, SomeFeatureEntityRepository>();

            return services;
        }
    }
}

