using System.Linq;
using Api.Order.Controllers;
using Api.Order.Domain.Dishes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq.AutoMock;

namespace Api.Order.Tests.Controllers;

public abstract class OrderControllersTestBase
{
    private readonly AutoMocker _mocker;
    private readonly IDishes _service;
    protected readonly OrdersControllers _controller;
    private readonly System.Func<System.Type, IDishes> _serviceResolver;

    public OrderControllersTestBase(IDishes service)
    {
        _service = service;
        _serviceResolver = (type) => _service;
        _mocker = new AutoMocker();
        _mocker.Use(_serviceResolver);
        _controller = _mocker.CreateInstance<OrdersControllers>();
    }

    protected abstract object CallMethod(int[] dishTypes);

    protected void CheckPossibilities(int[] dishTypes, string[] expected)
    {
        // act
        var actionResult = CallMethod(dishTypes) as OkObjectResult;

        // assert
        Assert.IsNotNull(actionResult);
        Assert.IsInstanceOfType(actionResult.Value, typeof(string[]));
        var dishes = actionResult.Value as string[];
        Assert.IsTrue(dishes.Any(d => expected.Contains(d)));
    }
}