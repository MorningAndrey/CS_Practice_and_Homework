// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Clear();
int num = CorrectNumber("Введите число N: ", "Ошибка ввода");
int multiplication = GetResult(num);
Console.WriteLine($" {num} -> {multiplication}");

int CorrectNumber(string number, string errorMessage)
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

int GetResult(int result)
{
    int m = 1;
    for (int i = 1; i <= result; i++)
    {
        m = m * i;
    }
    return m;
}