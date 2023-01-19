// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10


Console.Clear();
int num = CorrectUserInput("Введите число: ", "Ошибка ввода");
int dectobin = GetDecToBin(num);
Console.WriteLine($"{dectobin}");

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

int GetDecToBin(int number)
{
    int sum = 0;
    int r = 0;
    while (number > 0)
    {
        sum = sum + number % 2* (int)Math.Pow(10, r);
        r++;
        number /=2;
    }
    return sum;
}

