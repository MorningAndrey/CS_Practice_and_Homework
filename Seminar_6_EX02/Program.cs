// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.


Console.Clear();
int num1 = CorrectUserInput("Введите число: ", "Ошибка ввода");
int num2 = CorrectUserInput("Введите число: ", "Ошибка ввода");
int num3 = CorrectUserInput("Введите число: ", "Ошибка ввода");

GetResult(num1, num2, num3);

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

void GetResult(int a, int b, int c)
{
    if (a + b > c)
        if (b + c > a)
            if (a + c > b)
                Console.WriteLine("Yes");
    else Console.WriteLine("No");
}


