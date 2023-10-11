using P4_3PassingReferences;

void Sell()
{
    House house = new House();
    house.PrintOwner();
    house.Owner = "Alex";
    house.PrintOwner();
}
Sell();

