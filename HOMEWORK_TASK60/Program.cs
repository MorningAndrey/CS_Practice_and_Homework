// Задача 60: 
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

//-------------------------- Начало программы ----------------------------------
Console.Clear();
Console.WriteLine("Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
Console.WriteLine($"\nВведите размер массива и диапазон случайных значений:");
int x = GetNumberFromUser("Введите размерность X массива: ", "Ошибка ввода!");
int y = GetNumberFromUser("Введите размерность Y массива: ", "Ошибка ввода!");
int z = GetNumberFromUser("Введите размерность Z массива: ", "Ошибка ввода!");
int[,,] array = new int[x, y, z];
GetArray(array);
PrintArray(array);
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
// метод определения трехмерного массива из неповторяющихся целых двузначных чисел
void GetArray(int[,,] result)
{
    int[] temp = new int[result.GetLength(0) * result.GetLength(1) * result.GetLength(2)]; //  создаем одномерный массив из количества элементов трехмерного массива
    if (temp.Length <= 90)   // условие наполнения трехмерного массива неповторяющимися целыми двузначными числами
    {
        for (int i = 0; i < temp.GetLength(0); i++)
        {
            temp[i] = new Random().Next(10, 100);
            if (i >= 1)
            {
                for (int j = 0; j < i; j++)
                {
                    while (temp[i] == temp[j])  // цикл для заполнения одномерного массива неповторяющимися двузначными значениями
                    {
                        temp[i] = new Random().Next(10, 100);
                        j = 0;
                    }
                }
            }
        }

        int count = 0;
        for (int x = 0; x < result.GetLength(0); x++)
        {
            for (int y = 0; y < result.GetLength(1); y++)
            {
                for (int z = 0; z < result.GetLength(2); z++)
                {
                    result[x, y, z] = temp[count];
                    count++;
                }
            }
        }
    }
}

// метод вывода массива в консоль
void PrintArray(int[,,] inArray)
{
    int i = 0;
    int j = 0;
    int k = 0;
    if ((inArray.GetLength(0) * inArray.GetLength(1) * inArray.GetLength(2)) <= 90 && inArray[i, j, k] != 0)
    {
        for (i = 0; i < inArray.GetLength(0); i++)
        {
            for (j = 0; j < inArray.GetLength(1); j++)
            {
                for (k = 0; k < inArray.GetLength(2); k++)
                {
                    Console.Write($"{inArray[i, j, k]} ({i},{j},{k}) ");
                }
                Console.WriteLine();
            }
        }
    }
    else Console.WriteLine("Ошибка ввода размерности массива: X * Y * Z не должно превышать 90");
}

