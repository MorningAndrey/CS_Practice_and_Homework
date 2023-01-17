//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//

int[] array3 = GetArray(5, -10, 10);
Console.WriteLine(String.Join(" ", array3));

int n = GetNumberFromUser($"Введите число ", "Ошибка ввода!");

if (Check(n, array3)) Console.WriteLine("да");
else Console.WriteLine("нет");


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
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

bool Check(int x, int[] arr)
{
    int i = 0;
    bool f = false;
    while ((f == false) && (i < arr.Length))
    {
        if (x == arr[i]) f = true;
        i++;
    }
    return f;
}

