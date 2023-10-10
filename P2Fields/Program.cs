using P2Fields;

PlayerA playerInfo = new PlayerA();
Console.WriteLine("Player A");
Console.WriteLine($"Name: {playerInfo.name}");
Console.WriteLine($"Email: {playerInfo.email}");

Resource inventory =new Resource();
Console.WriteLine("Resources");
Console.WriteLine($"Gold:[{inventory.gold}] Stone:[{inventory.stone}] Wood:[{inventory.wood}]");

Level playerLevel = new Level();
Console.WriteLine($"Level: {playerLevel.level}");

Experience exp= new Experience();
Console.WriteLine($"Total EXP: {exp.experience}");

PvPMode pvpMode = new PvPMode();
Console.WriteLine("Do you want to turn on PvP mode? (y/n");
string pvpInput =Console.ReadLine();
if (pvpInput == "y")
    Console.WriteLine($"PvP Mode [Enabled] {pvpMode.enablded}");
else if (pvpInput =="n")
    Console.WriteLine($"PvP Mode [Disabled]{pvpMode.disabled}");

VIPSubscription status = new VIPSubscription();
Console.WriteLine("Do you want to renew VIP Subscription?");
string vipSubscription = Console.ReadLine();

if (vipSubscription == "y")
    Console.WriteLine($"PvP Mode [Active]:{status.active}");
else if (vipSubscription =="n")
    Console.WriteLine($"PvP Mode [Disabled]:{status.inactive}");



