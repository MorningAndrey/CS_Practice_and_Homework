Console.Clear();
//INPUT by random number generator:
//var rnd = new Random();
//int num = rnd.Next(-2147483647, 2147483647); //   в соответствии с объемом выделенной памяти под тип данных int
//Console.WriteLine(num);

//INPUT manually by user:
Console.Write("Введите любое целое число: ");
int num = int.Parse(Console.ReadLine() ?? "");

int Num = Math.Abs(num); //   возведение числа в модуль
int i = 10;

if (Num < 100)
    Console.Write($"{num} -> третьей цифры нет");
else
{
    while (Num > 1000)
    {
        Num = Num / i;
    }
    int final = Num % 10;
    Console.Write($"третья цифра числа {num} -> {final}");
}



