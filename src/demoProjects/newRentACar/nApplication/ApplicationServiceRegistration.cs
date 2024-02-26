using System;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using nApplication.Features.someFeature.Rules;
using FluentValidation;
using nApplication.Features.Brands.Profiles;
using AutoMapper.Internal;
using nApplication.Features.Brands.Rules;

namespace nApplication
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            //services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //services.AddAutoMapper(typeof(MappingProfiles));

            services.AddAutoMapper(cfg => cfg.Internal().MethodMappingEnabled = false, typeof(MappingProfiles).Assembly);

            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddScoped<SomeFeatureEntityBusinessRules>();
            services.AddScoped<BrandBusinessRules>();

            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(AuthorizationBehavior<,>));
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(CachingBehavior<,>));
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(CacheRemovingBehavior<,>));
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

            return services;

        }
    }
}

