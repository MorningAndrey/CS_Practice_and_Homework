// Задача 27:
// напишите программу, которая принимает на вход число и выдает сумму цифр в числе.
// 452 -> 11.
// 82 -> 10.

Console.Clear();
int num = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
int sumDig = GetSumDig(num);
Console.WriteLine($"{num} -> {sumDig}");

// Выводит в консоль сообщение message,
// преобразовывает введённую пользователем строку в число типа int.
// В случае ошибки выводит в консоль сообщение errorMessage
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
// Возвращает сумму цифр в числе number
int GetSumDig(int number)
{ 
    int result = 0;
    int Number = Math.Abs(number);
    while(Number > 0)
    {
        result += Number % 10;
        Number = Number / 10;
    }
    return result;
}