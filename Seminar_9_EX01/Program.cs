// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6

Console.Clear();
int n = GetNumberFromUser($"Введите число ", "Ошибка ввода!");  //  вызов метода
GetResult(n);


int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

void GetResult(int n)
{
    if (n == 0) return;
    else
    {
        //Console.Write($"{n},"); // для вывода в обратной последовательности
        GetResult(n - 1);
        Console.Write($"{n},");
    }
}