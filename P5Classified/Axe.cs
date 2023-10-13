namespace P5Classified;

public class Axe : CombatTool
{

    public void Axspear()
    {
        if (UsedInCombat)
        {
            Console.WriteLine("Yes you can hold me in your hand.");
        }
    }
    
}