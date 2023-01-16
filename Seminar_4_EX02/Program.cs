// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
int num = CorrectUserInput("Введите число: ", "Ошибка ввода");
int figureNumbers = GetFigureNumbers(num);
Console.WriteLine($"{num} -> {figureNumbers}");


int CorrectUserInput(string number, string errorMessage)
{
    while(true)
    {
        Console.Write(number);
        bool correctNumber = int.TryParse(Console.ReadLine(), out int userNumber);
        if(correctNumber)
        return userNumber;
        Console.Write(errorMessage);
    }
}

int GetFigureNumbers(int result)
{
    int count = 0;
    while(result > 0)
    {
        result = result / 10;
        count++;
    }
    return count;
}