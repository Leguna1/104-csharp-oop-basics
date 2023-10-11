using P4_2AllTheSame;

ScoreCounter one= new ScoreCounter();
ScoreCounter two=one;
ScoreCounter three=one;
ScoreCounter four=one;


one.IncreaseScore();
one.IncreaseScore();
one.IncreaseScore();
one.IncreaseScore();

Console.WriteLine(one.Score);
Console.WriteLine(two.Score);
Console.WriteLine(three.Score);
Console.WriteLine(four.Score);

