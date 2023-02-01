// Задача 60: 
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

//-------------------------- Начало программы ----------------------------------
Console.Clear();
Console.WriteLine("Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
Console.WriteLine($"\nВведите размер массива и диапазон случайных значений:");
int x = GetNumberFromUser("Введите размерность X массива: ");
int y = GetNumberFromUser("Введите размерность Y массива: ");
int z = GetNumberFromUser("Введите размерность Z массива: ");
int[,,] array = new int[x, y, z];
GetArray(array);
PrintArray(array);
// -------------------------- Конец программы ----------------------------------
// -------------------------Определение методов ---------------------------------
// ------------------------------------------------------------------------------
// Метод запроса числа у пользователя сс проверкой на ошибки ввода
int GetNumberFromUser(string message)
{
    Console.Write(message);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
// метод определения трехмерного массива из неповторяющихся целых двузначных чисел
void GetArray(int[,,] result)
{
    int[] temp = new int[result.GetLength(0) * result.GetLength(1) * result.GetLength(2)];  //  создаем одномерный массив из количества элементов трехмерного массива
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

// метод вывода массива в консоль
void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

