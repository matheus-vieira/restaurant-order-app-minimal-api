using Api.Order.Domain.Dishes;
using Microsoft.AspNetCore.Mvc;

namespace Api.Order.Controllers;
public partial class OrdersControllers
{
    /// <summary>
    /// Get dishes for night
    /// </summary>
    /// <param name="dyshType">The requested dishes</param>
    /// <returns></returns>
    /// <response code="200">OK</response>
    /// <response code="400">Bad Request</response>
    /// <response code="403">Forbidden</response>
    /// <response code="404">Not found</response>
    /// <response code="500">Internal Server Error</response>
    [HttpPost, Route("/night")]
    public IActionResult PostNight([FromBody] int[] dishType)
        => InternalGetDishes(typeof(NightDishes), dishType);
}
