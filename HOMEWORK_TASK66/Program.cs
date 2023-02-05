// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
//-------------------------- Начало программы ----------------------------------
Console.Clear();
int m=GetNumberFromUser($"Введите число ", "Ошибка ввода!");  
int n=GetNumberFromUser($"Введите число ", "Ошибка ввода!");
Console.Write($"M = {m}; N = {n}"); 
int temp = m;
if (m > n)
{
    m = n;
    n = temp;
}
GetResult(m, n, temp = 0);
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
// Метод рекурсивного определения суммы натуральных чисел в промежутке от M до N
void GetResult(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($" -> {sum} ");
        return;
    }
    GetResult(m, n - 1, sum);
}

