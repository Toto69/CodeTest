namespace FruitService.DataBase;

public interface IFruitData
{
    public Fruit? GetById(int id);
    public IEnumerable<Fruit> GetAll();
}