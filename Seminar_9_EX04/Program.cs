// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();
int a = GetNumberFromUser($"Введите число ", "Ошибка ввода!");  //  вызов метода
int b = GetNumberFromUser($"Введите число ", "Ошибка ввода!");  //  вызов метода
int result = GetResult(a, b);
Console.Write($"A = {a}; B = {b} -> {result}");


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

int GetResult(int a, int b)
{
    if (b == 1) return a;
    {
        return a*GetResult(a, b-1);
    }
}