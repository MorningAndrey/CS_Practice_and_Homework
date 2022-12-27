Console.Clear();
int N;
int n;
while (true)
{
        Console.Write("Введите целое число: ");
        if (int.TryParse(Console.ReadLine(), out N))
            break;
        Console.WriteLine("Ошибка ввода!");
}
n = Math.Abs(N);
Console.Write($"{N} -> ");

for(int count = 1; count < n; count++)
{
    Console.Write($" {Math.Pow(count, 3)}, ");
}
Console.Write($" {Math.Pow(n, 3)}. ");