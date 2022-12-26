Console.Clear();
int N =0;
try
{
    Console.Write("Введите целое число: ");
    N = int.Parse(Console.ReadLine() ??"");
    N = Math.Abs(N);
}
catch(Exception exc)
{
    Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
}

Console.Write($"{N} -> ");

for(int count = 1; count < N; count++)
{
    Console.Write($"{Math.Pow(count, 2)},");
}
Console.Write($"{Math.Pow(N, 2)}.");