//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();
int num = CorrectUserInput("Введите число: ", "Ошибка ввода");
GetFibonacci(num);

int CorrectUserInput(string number, string errorMessage)
{
    while (true)
    {
        Console.Write(number);
        bool correctNumber = int.TryParse(Console.ReadLine(), out int userNumber);
        if (correctNumber)
            return userNumber;
        Console.Write(errorMessage);
    }
}

void GetFibonacci(int number)
{
    int a = 0;
    int b = 1;
    Console.Write($"Если N = {number} -> {a} {b}");
    int c = 0;
    for (int i = 3; i <= number; i++)
    {
        c = a + b;
        a = b;
        b = c;
        Console.Write($" {b}");
    }
}


