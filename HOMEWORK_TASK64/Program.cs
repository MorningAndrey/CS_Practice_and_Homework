// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
//-------------------------- Начало программы ----------------------------------
Console.Clear();
int n = GetNumberFromUser($"Введите число N: ", "Ошибка ввода!");
int count = 2;
Console.Write($"N = {n} -> ");
Console.Write("'");
GetResult(n, count);
Console.Write(1);
Console.Write("'");
// -------------------------- Конец программы ----------------------------------
// -------------------------Определение методов ---------------------------------
// ------------------------------------------------------------------------------
// Метод запроса числа у пользователя с проверкой на ошибки ввода
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
// метод определения натуральных чисел в промежутке от N до 1
void GetResult(int n, int count)
{
    if (count > n) return;
    GetResult(n, count + 1);
    Console.Write(count + ", ");
}