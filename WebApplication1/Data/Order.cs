namespace WebApplication1.Data;

public class Order
{
    public Order(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; private set; }

    public string Name { get; private set; }

}

