//-------------------------- Начало программы ----------------------------------
Console.Clear();
Console.WriteLine("Задача : задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов");
Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
int rows = GetNumberFromUser("Введите количество строк массива: ", "Ошибка ввода!");
int columns = GetNumberFromUser("Введите количество столбцов массива: ", "Ошибка ввода!");
int range = GetNumberFromUser("Введите диапазон значений элементов: от 1 до ", "Ошибка ввода!");
int[,] array = new int[rows, columns];
GetArray(array);
PrintArray(array);
Console.WriteLine("\nСумма элементов построчно: ");
int[] inArr = new int[array.GetLength(0)];
int[] arrayOfSums = GetSumOfEachLine(array, inArr);
Console.WriteLine(String.Join(" ", arrayOfSums));
GetResult(arrayOfSums);
// -------------------------- Конец программы ----------------------------------
// -------------------------Определение методов ---------------------------------
// ------------------------------------------------------------------------------
// Метод запроса числа у пользователя сс проверкой на ошибки ввода
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
// метод определения двумерного массива целых чисел
void GetArray(int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(range);
        }
    }
}
// метод вывода массива в консоль
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
// Метод определения суммы элементов построчно
int[] GetSumOfEachLine(int[,] arr, int[] sums)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        foreach(int q in sums) 
        {
            if(sum > q) sums[i] = sum;
        }
        sum = 0;
    }
    return sums;
}
// Метод вывода минимальной суммы в строках с выводом результатов пользователю
void GetResult(int[] sums)
{
    int position = 0;
    int min = sums[0];
    for (int i = 1; i < sums.Length; i++)
    {
        if (sums[i] < min)
        {
            min = sums[i];
            position = i;
        }
    }
    if(position == 1) Console.WriteLine($"\nНаименьшая сумма элементов, равная {min}, находится во {position+1}й строке");
    else Console.WriteLine($"\nНаименьшая сумма элементов, равная {min}, находится в {position+1}й строке");
}