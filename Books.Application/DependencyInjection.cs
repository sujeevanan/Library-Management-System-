using System.Reflection;
using Books.Application.Behaviors;
using Books.Application.Mappings;
using FluentValidation;
using Mapster;
using Microsoft.Extensions.DependencyInjection;

namespace Books.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        //mediator 
        services.AddMediatR(cf =>
        {
            cf.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            cf.AddOpenBehavior(typeof(ValidationBehaviour<,>));
        });
        //mapping 
        MappingConfig.Configure();
        var config = TypeAdapterConfig.GlobalSettings;
        config.Scan(Assembly.GetExecutingAssembly());
        services.AddSingleton(config);
        
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        return services;
    }
}