namespace RPG;

public class Monster
{
    public int Health = 3;
    
    public void Attack(Player target)
    {
        target.Health--;
        Console.WriteLine($"The monster attacks you. You have {target.Health} Health.");
    }
}
    