// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Clear();
int m=GetNumberFromUser($"Введите число ", "Ошибка ввода!");  //  вызов метода
int n=GetNumberFromUser($"Введите число ", "Ошибка ввода!");  //  вызов метода
if(m == n) Console.Write($"M = {m}; N = {n} -> '0' ");
else 
{
    if (m>n) 
    {
        string result = GetResult(m, n);
        Console.Write($"M = {m}; N = {n} -> '{result}' ");
    }
}

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

string GetResult (int start, int end)
{
    if(start == end) return end.ToString();
    else return start  + " " + GetResult(start +1, end);
}