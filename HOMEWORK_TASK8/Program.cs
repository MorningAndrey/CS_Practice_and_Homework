Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine() ??"");
int i = 2;

for(i = 2; i <= number; i+=2)
{
    Console.Write($" {i} ");
}
