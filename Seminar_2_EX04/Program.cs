Console.Clear();
Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine()  ??"");

int condition1 = num % 7;
int condition2 = num % 23;
if (condition1 == 0 && condition2 == 0)
    Console.Write($"{num} - > да");
else
    Console.Write($"{num} - > нет");