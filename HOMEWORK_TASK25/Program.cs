// Задача 25:
// напишите цикл, который принимает на вход два числа (А) и (В) и возводит число А
// в натуральную степень В.  
// 2, 4 -> 16.

int A = CorrectUserNumberA("Ведите число А: ", "Ошибка ввода"); // метод ввода числа А и вывод сообщения об ошибке
int B = CorrectUserNumberB("Ведите число B: ", "Ошибка ввода"); // метод ввода числа B и вывод сообщения об ошибке
int result = GetResult(A, B);                                   // метод возведения числа А в натуральную степень В
Console.Write($"{A}, {B} -> {result}");                         // вывод результата пользователю

// Выводит в консоль сообщение для ввода числа A,
// преобразовывает введённую пользователем строку в число типа int.
// В случае ошибки выводит в консоль сообщение errorMessage
int CorrectUserNumberA(string A, string errorMessage)
{
    while (true)
    {
        Console.Write(A);
        bool isCorrectA = int.TryParse(Console.ReadLine(), out int userNumberA);
        if (isCorrectA)
            return userNumberA;
        Console.WriteLine(errorMessage);
    }
}

// Выводит в консоль сообщение для ввода числа B,
// преобразовывает введённую пользователем строку в число типа int.
// В случае ошибки выводит в консоль сообщение errorMessage
int CorrectUserNumberB(string B, string errorMessage)
{
    while (true)
    {
        Console.Write(B);
        bool isCorrectB = int.TryParse(Console.ReadLine(), out int userNumberB);
        if (isCorrectB)
            if (userNumberB >= 0)
                return userNumberB;
        Console.WriteLine(errorMessage);
    }
}

// возводит число А в натуральную степень В
int GetResult(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result = result * A;
    }
    return result;
}
