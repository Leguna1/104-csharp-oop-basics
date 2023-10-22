using P6GoodKnight;

Knight attacker = new Knight();
Knight defender = new Knight();

defender.EquipShield(); // Give the defender a Shield

attacker.Attack(defender); // Attacker attacks defender

attacker.EquipSword(); // Give the attacker a Sword

attacker.Attack(defender); // Attacker attacks defender

attacker.Attack(defender); // Attacker attacks defender again

Console.ReadLine(); // Wait for user input to close the progra