using Api.Order.Domain.Dishes;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Api.Order.Controllers;
[ApiController]
[Route("[controller]")]
public partial class OrdersControllers : Controller
{
    private readonly Func<Type, IDishes> _serviceResolver;

    public OrdersControllers(Func<Type, IDishes> serviceResolver)
        => _serviceResolver = serviceResolver;

    protected IActionResult InternalGetDishes(Type type, int[] dishType)
        => Ok(_serviceResolver(type)?.GetDishes(dishType));
}
