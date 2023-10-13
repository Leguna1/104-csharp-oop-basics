namespace P5Classified;

public class Shield : CombatTool
{
    public void JustShield()
    {
        CanBeEaten = false;
        CanHoldInHand = true;
        KnownForVitamins = false;
        UsedInCombat = true;
        LivingBeing = false;
    }
}