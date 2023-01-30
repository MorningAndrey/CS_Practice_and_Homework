/// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();
Console.WriteLine($"Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
int a = GetNumberFromUser("Введите число строк 1-й матрицы: ", "Ошибка ввода!");
int b = GetNumberFromUser("Введите число столбцов 1-й матрицы (и строк 2-й): ", "Ошибка ввода!");
int c = GetNumberFromUser("Введите число столбцов 2-й матрицы: ", "Ошибка ввода!");
int range = GetNumberFromUser("Введите диапазон случайных чисел: от 1 до ", "Ошибка ввода!");

int[,] Matrix1 = new int[a, b];
CreateArray(Matrix1);
Console.WriteLine($"\nПервая матрица:");
WriteArray(Matrix1);

int[,] Matrix2 = new int[b, c];
CreateArray(Matrix2);
Console.WriteLine($"\nВторая матрица:");
WriteArray(Matrix2);

int[,] resultMatrix = new int[a, c]; // число строк первой матрицы должно быть равно числу столбцов 2й матрицы

MatrixMultiplication(Matrix1, Matrix2, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(resultMatrix);

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return Math.Abs(userNumber);
        Console.WriteLine(errorMessage);
    }
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void MatrixMultiplication(int[,] Matrix1, int[,] Matrix2, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < Matrix1.GetLength(1); k++)
            {
                sum += Matrix1[i, k] * Matrix2[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}