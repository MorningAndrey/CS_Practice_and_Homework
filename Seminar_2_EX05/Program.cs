Console.Clear();
Console.Write("Введите первое целое число: ");
int a1 = int.Parse(Console.ReadLine() ??"");

Console.Write("Введите второе целое число: ");
int a2 = int.Parse(Console.ReadLine() ??"");

int A2 = a1*a1;
int A1 = a2*a2;

if (A1 == a1 || A2 == a2)
    Console.Write($"{a1},{a2} -> да");
else
    Console.Write($"{a1},{a2} -> нет");