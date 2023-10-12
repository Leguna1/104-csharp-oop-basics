namespace P5Classified;

public class Sword : Spear
{
    public string name = "Sword";
    public string look = "sharp";

    public void Child2()
    {
        Console.WriteLine($"This {name} looks {look}.");
    }
}