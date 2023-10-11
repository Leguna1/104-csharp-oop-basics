namespace P4_1Replacing;
public class Plant
{
    private static bool? isGrown;

    public Plant()
    {
        isGrown = false;
    }
    public void PrintStatus()
    {
        if (isGrown == false)
        {
            Console.WriteLine("Plant is a seed.");
        }
        else
        {
            Console.WriteLine("Plant is a tree.");
            Console.WriteLine("Plant has already grown.");
        }
    }
    public void Grow()
    {
            Console.WriteLine("Plant is growing");
        isGrown = true;
    }
}