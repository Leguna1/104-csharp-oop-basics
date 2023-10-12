namespace P5Classified;

public class Axe : Sword
{
    public string name = "Axe";
    public string material = "steel";
    
    public void Child1()
    {
        Console.WriteLine($"This {name} is made of {material}.");
    }
}