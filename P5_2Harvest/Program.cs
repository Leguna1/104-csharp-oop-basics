using P5_2Harvest;

Plant plant =new Plant(); //Instrance
Grain grain =new Grain(); //Instance
Wheat wheat =new Wheat(); //Instance

Console.WriteLine("Invoking Plant class method..");
plant.CanGrow(); //Invoke method

Console.WriteLine("Invoking Grain class methods..");
grain.CanGrow();//Invoke method
grain.CanBeHarvested(); 

Console.WriteLine("Invoking Wheat class methods..");
wheat.CanBeHarvested(); //Invoke method
wheat.CanBeProcessedToBread(); 

