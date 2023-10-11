using P4Heap;

Player player1=new Player();
Player player2=new Player();
Player player3 = new Player();
player1=player3;

Console.WriteLine("Player 1 attacks Player2.");
player1.Attack(player2);
Console.WriteLine($"Player 1 Damage: {player1.Damage}");
Console.WriteLine($"Player 2 Damage: {player2.Damage}");

Console.WriteLine("Player 2 attacks Player 1.");
player2.Attack(player1);
Console.WriteLine($"Player 1 Damage: {player1.Damage}");
Console.WriteLine($"Player 2 Damage: {player2.Damage}");

Console.WriteLine("Player 1 attacks Player 1");
player1.Attack(player1);
Console.WriteLine($"Player 1 Damage: {player1.Damage}");
Console.WriteLine($"Player 2 Damage: {player2.Damage}");

Console.WriteLine("Player 2 attacks Player 1.");
player2.Attack(player1);
Console.WriteLine($"Player 1 Damage: {player1.Damage}");
Console.WriteLine($"Player 2 Damage: {player2.Damage}");
Console.WriteLine($"Player 3 Damage: {player3.Damage}");