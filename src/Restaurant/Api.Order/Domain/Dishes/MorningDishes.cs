namespace Api.Order.Domain.Dishes;
public class MorningDishes : Dishes
{
    public const string Name = nameof(MorningDishes);

    private static System.Collections.Generic.IList<int> AllowedMultiples => new System.Collections.Generic.List<int> { 3 };

    private static System.Collections.Generic.IDictionary<int, string> InternalDishDictionary => new System.Collections.Generic.Dictionary<int, string>
    {
        [1] = "eggs",
        [2] = "toast",
        [3] = "coffee",
    };

    protected override System.Collections.Generic.IList<int> GetAllowedMultiples() => AllowedMultiples;

    protected override System.Collections.Generic.IDictionary<int, string> DishDictionary => InternalDishDictionary;
}
