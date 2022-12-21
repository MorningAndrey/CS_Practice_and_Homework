Console.Write("Введите число от 1 до 7: ");
int day = int.Parse(Console.ReadLine() ??"");

if( day > 5)
    Console.Write($"{day} -> да");
else
    Console.Write($"{day} -> нет");
    