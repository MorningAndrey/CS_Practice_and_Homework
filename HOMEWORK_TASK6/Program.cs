Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine() ??"");

if(number % 2 == 0)
{
    Console.WriteLine($"число {number} -> четное");
}
else
{
    Console.WriteLine($"число {number} -> нечетное");
}