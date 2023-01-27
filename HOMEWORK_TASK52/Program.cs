// Задача 52:
// Задайте двумерный массив из целых чисел, найдите среднее арифметическое элементов в каждом столбце.
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
//-------------------------- Начало программы ----------------------------------
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = GetArray(rows, columns);
PrintArray(array);
GetAverage(array, rows);
// -------------------------- Конец программы ----------------------------------
// -------------------------Определение методов ---------------------------------
// ------------------------------------------------------------------------------
// метод определения двумерного массива целых чисел
int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(-100, 100);
        }
    }
    return result;
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
// метод определения среднего арифметического каждого элемента столбца
void GetAverage(int[,] Array, int Rows)
{
    double sum = 0;
    double result = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < Array.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < Array.GetLength(0); j++)
        {
            sum = sum + Array[j, i];
        }
        result =Math.Round((sum / Rows), 2);
        if (i == Rows) Console.Write($" {result}.");
        else Console.Write($" {result};");
    }
}