// Задача 59: 
// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

Console.Clear();
int rows = CorrectInputByUser("Введите количество строк массива: ", "Ошибка ввода!" );
int columns = CorrectInputByUser("Введите количество столбцов массива: ","Ошибка ввода!");
int[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);
GetResult(array);

// метод ввода числа
int CorrectInputByUser(string message, string errorMessage)
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
// метод определения двумерного массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
// метод возврата массива
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
// метод удаления строки и столбца на пересечении наименьшего элемента массива и возврата обновленного массива
void GetResult(int[,] array)
{
    int min = 0;
    int a = 0;
    int b = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j])
            {
                min = array[i, j];
                a = i;
                b = j;
            }
        }
    }
    Console.WriteLine($"Наименьший элемент: {min}. На выходе получим следующий массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i != a && j != b) Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
