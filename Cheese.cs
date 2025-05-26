public class Cheese
{
    public Cheese(int id, string name, decimal price, int strength)
    {
        Id = id; Name = name; Price = price; Strength = strength;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Strength { get; set; }

}
