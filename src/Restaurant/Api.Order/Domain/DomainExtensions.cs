using Api.Order.Domain.Dishes;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Api.Order.Domain;
public static class DomainExtensions
{
    public static IServiceCollection UseDomain(this IServiceCollection services)
    {
        services.AddTransient<MorningDishes>();
        services.AddTransient<NightDishes>();
        services.AddTransient(GetDishServiceByType);

        return services;
    }

    private static Func<Type, IDishes> GetDishServiceByType(IServiceProvider serviceProvider)
        => type => (IDishes)serviceProvider.GetRequiredService(type);
}
