namespace P5Classified;

public class Food 
{
    public bool CanBeEaten = true;
    public bool CanHoldInHand =true;
    public bool UsedInCombat =false;
    public bool LivingBeing =false;
    public bool KnownForVitamins = true;
    
    public void Edible()
    {
       Console.WriteLine("You can eat Apple, Pear, Banana, Bread");
       Console.WriteLine("They are known for many vitamins and can be held in hand.");
       Console.WriteLine("If you dont belive me, ask them!");
    }
}