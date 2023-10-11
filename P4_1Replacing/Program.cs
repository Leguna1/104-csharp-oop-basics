using P4_1Replacing;

static void Main()
{
    Plant plant = new Plant();

    plant.PrintStatus();
    plant.Grow();
    plant.PrintStatus();
    plant.Grow();
    
    plant = new Plant();

    plant.PrintStatus();
}
Main();