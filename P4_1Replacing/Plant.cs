public class Plant
{
    public bool isGrown;

    public void PrintStatus()
    {
        if (isGrown == true)
        {
            Console.WriteLine("The seed has grown into a Tree.");
        }

        if (isGrown == false)
        {
            Console.WriteLine("It's still a seed.");
        }
    }
    public void Grow()
    {
        Console.WriteLine("The seed is growing..");
        isGrown = true;
    }
}