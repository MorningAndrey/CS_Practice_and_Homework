// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
//-------------------------- Начало программы ----------------------------------
Console.Clear();
int n = GetNumberFromUser("Введите n: ", "Ошибка ввода!");
int m = GetNumberFromUser("Введите m: ", "Ошибка ввода!");
int functionAkkerman = GetAckermannFunction(m, n);
Console.Write($"m = {m}; n = {n} -> A(m,n) = {functionAkkerman} ");
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
// метод вычисления функции Аккермана с помощью рекурсии
int GetAckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return GetAckermannFunction(m - 1, 1);
    else return GetAckermannFunction(m - 1, GetAckermannFunction(m, n - 1));
}

