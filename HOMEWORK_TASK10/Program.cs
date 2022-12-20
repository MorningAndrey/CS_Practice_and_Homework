Console.Clear();
var rnd = new Random();
int num = rnd.Next(100, 1000);

int a1 = num % 100;
int a2 = a1 / 10;

Console.Write($"{num} -> {a2}");