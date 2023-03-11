using System.Linq;
using Api.Order.Domain.Dishes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Api.Order.Tests.Domain.Dishes;


public abstract class DishesBaseTests
{
    protected readonly IDishes _service;

    public DishesBaseTests(IDishes service)
    {
        _service = service;
    }

    protected void CheckPossibilities(int[] dishTypes, string[] expected)
    {
        // act
        var dishes = _service.GetDishes(dishTypes);

        // assert
        Assert.IsTrue(dishes.Any(d => expected.Contains(d)));
    }
}
