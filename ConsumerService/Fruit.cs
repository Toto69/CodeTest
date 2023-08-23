namespace ConsumerService;

public class Fruit
{
    public string Name { get; set; }

    public override string ToString()
    {
        return this.Name;
    }
}

public class FruitViewmodel
{
    public Fruit[] Fruits { get; set; }
}