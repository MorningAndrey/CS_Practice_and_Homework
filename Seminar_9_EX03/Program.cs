// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
int n = GetNumberFromUser($"Введите число ", "Ошибка ввода!");  //  вызов метода
int sum = 0;
int i = 10;
Console.Write($"{n} ");
GetResult(n, sum, i);


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

void GetResult(int n, int sum, int i)
{
    if (n / i < 1) Console.Write($"-> {sum + n}");
    else
    {
        sum += (n % i);
        GetResult(n / 10, sum, i);
    }
}