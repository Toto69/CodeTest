namespace FruitService.DataBase;

public class MockFruitData: IFruitData
{
    private Dictionary<int, Fruit> _fruitData;
    public MockFruitData()
    {
        _fruitData = new Dictionary<int, Fruit>();
        _fruitData.Add(1, new Fruit("Apple"));
        _fruitData.Add(2, new Fruit("Banana"));
        _fruitData.Add(3, new Fruit("Lemon"));
        _fruitData.Add(4, new Fruit("Pina"));
        _fruitData.Add(5, new Fruit("Mango"));
        _fruitData.Add(6, new Fruit("Pineapple"));
        _fruitData.Add(7, new Fruit("Watermelon"));
        _fruitData.Add(8, new Fruit("Tomato"));
    }

    public Fruit? GetById(int id)
    {
        if (!_fruitData.ContainsKey(id))
            return null;
        
        return _fruitData[id];
    }

    public IEnumerable<Fruit> GetAll()
    {
        return _fruitData.Count == 0 ? Enumerable.Empty<Fruit>() : _fruitData.ToArray().Select(x => x.Value);
    }
}