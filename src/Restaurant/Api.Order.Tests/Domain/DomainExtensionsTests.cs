using Api.Order.Domain;
using Api.Order.Domain.Dishes;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq.AutoMock;

namespace Api.Order.Tests.Domain;

[TestClass]
public class DomainExtensionsTests
{
    private readonly AutoMocker _mocker;
    private readonly IServiceCollection _services;

    public DomainExtensionsTests()
    {
        _mocker = new AutoMocker();
        _services = _mocker.CreateInstance<ServiceCollection>();
    }

    [TestMethod]
    [DataRow(typeof(MorningDishes), DisplayName = "Morning Dishes")]
    [DataRow(typeof(NightDishes), DisplayName = "Night Dishes")]
    public void ShouldHaveServicesRegistered(System.Type type)
    {
        // arrange
        _services.UseDomain();

        // act
        var serviceProvider = _services.BuildServiceProvider();
        var service = serviceProvider.GetRequiredService(type);

        // assert
        Assert.IsNotNull(service);
        Assert.IsInstanceOfType(service, type);
        Assert.IsInstanceOfType(service, typeof(IDishes));
    }

    [TestMethod]
    [DataRow(typeof(MorningDishes), DisplayName = "Morning Dishes")]
    [DataRow(typeof(NightDishes), DisplayName = "Night Dishes")]
    public void ShouldReturnIDishesService(System.Type type)
    {
        // arrange
        _services.UseDomain();

        // act
        var serviceProvider = _services.BuildServiceProvider();
        var serviceResolver = serviceProvider.GetRequiredService<System.Func<System.Type, IDishes>>();
        var service = serviceResolver(type);

        // assert
        Assert.IsNotNull(service);
        Assert.IsInstanceOfType(service, typeof(IDishes));
    }

    [TestMethod]
    public void ShouldReturnNullForIncorrectType()
    {
        // arrange
        _services.UseDomain();

        // act
        var serviceProvider = _services.BuildServiceProvider();
        var serviceResolver = serviceProvider.GetRequiredService<System.Func<System.Type, IDishes>>();

        // assert
        Assert.ThrowsException<System.InvalidOperationException>(() => serviceResolver(typeof(object)));
    }
}
