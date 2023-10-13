namespace P5Classified;

public class CombatTool
{
  public bool CanBeEaten;
  public bool CanHoldInHand =true;
  public bool KnownForVitamins;
  public bool UsedInCombat =true;
  public bool LivingBeing;
  public void Equipments()
  {
    if (CanHoldInHand)
    {
      Console.WriteLine("Yes, you can hold me in your hand.");
    }

    if (CanBeEaten)
    {
      Console.WriteLine("Nope, you cannot eat my sword.");
    }
  }
}