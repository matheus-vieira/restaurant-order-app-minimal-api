namespace Api.Order.Domain.Dishes;
public class NightDishes : Dishes
{
    public const string Name = nameof(NightDishes);

    private static System.Collections.Generic.IList<int> AllowedMultiples => new System.Collections.Generic.List<int> { 2 };

    private static System.Collections.Generic.IDictionary<int, string> InternalDishDictionary => new System.Collections.Generic.Dictionary<int, string>
    {
        [1] = "steak",
        [2] = "potato",
        [3] = "wine",
        [4] = "cake",
    };

    protected override System.Collections.Generic.IList<int> GetAllowedMultiples() => AllowedMultiples;

    protected override System.Collections.Generic.IDictionary<int, string> DishDictionary => InternalDishDictionary;
}
