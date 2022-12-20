double varA;

while (true)
{
        Console.Write("Введите А: ");
        if (double.TryParse(Console.ReadLine(), out varA))
            break;
        Console.WriteLine("Ошибка ввода!");
}

Console.WriteLine($"A={varA}");
