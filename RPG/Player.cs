namespace RPG;

public class Player
{
    public int Health; //Field

    public void Attack(Monster target) //method
    {
        target.Health--;
        Console.WriteLine($"You attack the monster. It has {target.Health} Health.");
    }

    public void Heal() //method
    {
        this.Health = 3;
    }
}