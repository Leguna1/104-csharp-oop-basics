using P2Fields;

var playerInfo = new PlayerA();
Console.WriteLine("Player A");
Console.WriteLine($"Name: {playerInfo.name}");
Console.WriteLine($"Email: {playerInfo.email}");

var inventory =new Resource();
Console.WriteLine("Resources");
Console.WriteLine($"Gold:[{inventory.gold}] Stone:[{inventory.stone}] Wood:[{inventory.wood}]");

var playerLevel = new Level();
Console.WriteLine($"Level: {playerLevel.level}");

var exp= new Experience();
Console.WriteLine($"Total EXP: {exp.experience}");

var pvpMode = new PvPMode();
Console.WriteLine("Do you want to turn on PvP mode? (y/n");
var pvpInput =Console.ReadLine();
if (pvpInput == "y")
    Console.WriteLine($"PvP Mode [Enabled] {pvpMode.enablded}");
else if (pvpInput =="n")
    Console.WriteLine($"PvP Mode [Disabled]{pvpMode.disabled}");

var status = new VIPSubscription();
Console.WriteLine("Do you want to renew VIP Subscription?");
var vipSubscription = Console.ReadLine();

if (vipSubscription == "y")
    Console.WriteLine($"PvP Mode [Active]:{status.active}");
else if (vipSubscription =="n")
    Console.WriteLine($"PvP Mode [Disabled]:{status.inactive}");