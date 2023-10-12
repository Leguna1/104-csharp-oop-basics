namespace P5Classified;

public class Spear : Shield
{
    public string name = "Spear";
    public string condition = "broken";

    public void Child3()
    {
        Console.WriteLine($"Why is this {name} {condition}.");
    }
}