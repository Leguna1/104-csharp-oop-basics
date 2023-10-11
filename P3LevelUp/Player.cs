namespace P3LevelUp;

public class Player
{
    public int Experience = 0;
    public int Level = 0;

    public void GrantExperience()
    {
        while (true)
        {
            Console.WriteLine($"{Level} Level and {Experience} Experience.");
            int input = int.Parse(Console.ReadLine()!);

            if (input <= 0)
            {
                Console.WriteLine("Invalid input. Enter a positive number.");
                continue; // skip and restart.
            }
            
            Experience += input;
            while (Experience >= 100)
            {
                Level++;
                Experience -= 100;
            }
        } 
    }
}