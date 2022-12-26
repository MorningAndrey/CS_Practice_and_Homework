Console.Clear();
int num;

try
{
    Console.Write("Введите номер четверти от 1 до 4: ");
    num = int.Parse(Console.ReadLine() ?? "");
}
catch (Exception exc)
{
    Console.WriteLine($"Ошибка ввода! {exc.Message}");
    return;
}

if (num == 1) 
{
    Console.WriteLine("X > 0 && Y > 0");
}
else if (num == 2) 
{
    Console.WriteLine("X < 0 && Y > 0");
}
else if (num == 3)
{
    Console.WriteLine("X < 0 && Y < 0");
}
else if (num == 4)
{
    Console.WriteLine("X > 0 && Y < 0");
}
else
{
    Console.WriteLine("Ошибка! Точка попадает на оси координат!");
}