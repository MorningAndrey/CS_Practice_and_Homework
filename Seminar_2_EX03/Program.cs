Console.Clear();
Console.Write("Введите первое число: ");
int userInput1 = int.Parse(Console.ReadLine() ??"");

Console.Write("Введите второе число: ");
int userInput2 = int.Parse(Console.ReadLine() ??"");

int dev = userInput1 % userInput2;

if (dev == 0)
    Console.Write("кратно");
else
    Console.Write($"- > не кратно, остаток {dev} ");



