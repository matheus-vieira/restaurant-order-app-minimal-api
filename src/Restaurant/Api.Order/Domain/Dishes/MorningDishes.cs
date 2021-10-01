namespace Api.Order.Domain.Dishes;
public class MorningDishes : Dishes
{
    public const string Name = nameof(MorningDishes);

    private static IList<int> AllowedMultiples => new List<int> { 3 };

    private static IDictionary<int, string> InternalDishDictionary => new Dictionary<int, string>
    {
        [1] = "eggs",
        [2] = "toast",
        [3] = "coffee",
    };

    protected override IList<int> GetAllowedMultiples() => AllowedMultiples;

    protected override IDictionary<int, string> DishDictionary => InternalDishDictionary;
}
