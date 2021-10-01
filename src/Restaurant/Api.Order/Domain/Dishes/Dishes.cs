namespace Api.Order.Domain.Dishes;
public interface IDishes
{
    string[] GetDishes(int[] dishesTypes);
}

public abstract class Dishes : IDishes
{
    protected abstract IList<int> GetAllowedMultiples();
    protected abstract IDictionary<int, string> DishDictionary { get; }

    public string[] GetDishes(int[] dishesTypes)
    {
        var dishes = LoadDishes(dishesTypes);

        return BuildDishes(dishes);
    }

    private string[] BuildDishes(SortedDictionary<int, int> dishes)
    {
        List<string> list = new();
        var dishDictionary = DishDictionary;
        foreach (var item in dishes)
        {
            dishDictionary.TryGetValue(item.Key, out var value);

            if (item.Value > 1 && !CanHaveMultiples(item.Key))
                continue;

            var text = value ?? "error";

            if (item.Value > 1)
                text += $"(x{item.Value})";
            list.Add(text);
        }

        return list.ToArray();
    }

    private bool CanHaveMultiples(int dishType)
        => GetAllowedMultiples().Contains(dishType);

    private static SortedDictionary<int, int> LoadDishes(int[] dishesTypes)
    {
        SortedDictionary<int, int> dishes = new();

        for (int i = 0; i < dishesTypes.Length; i++)
        {
            dishes.TryGetValue(dishesTypes[i], out var value);

            dishes[dishesTypes[i]] = ++value;
        }

        return dishes;
    }
}
