// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"
//-------------------------- Начало программы ----------------------------------
Console.Clear();
int m=GetNumberFromUser($"Введите число ", "Ошибка ввода!");  //  вызов метода
int n=GetNumberFromUser($"Введите число ", "Ошибка ввода!");  //  вызов метода
Console.Write($"M = {m}; N = {n}");
int temp = m;
if (m > n)
{
    m = n;
    n = temp;
}
if(m == n) Console.Write($" -> '{m}' ");
else 
{
    string result = GetResult(m, n);
    Console.Write($" -> '{result}' ");
}
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
// Метод рекурсивного определения натуральных чисел в промежутке от M до N
string GetResult (int start, int end)
{
    if(start == end) return end.ToString();
    else return start  + " " + GetResult(start +1, end);
}