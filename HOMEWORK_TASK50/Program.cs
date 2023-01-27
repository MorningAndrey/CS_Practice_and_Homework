// Задача 50:
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  17 -> такого числа в массиве нет.
//-------------------------- Начало программы ----------------------------------
Console.Clear();
int coordinates = GetCoordinatesFromUser($"Введите позицию элемента в массиве: ");  //  вызов метода запроса позиции элемента в массиве у пользователя
int m = new Random().Next(3, 10);                                                   //  случайное определение числа строк массива
int n = new Random().Next(3, 10);                                                   //  случайное определение числа столбцов массива
int[,] array = GetArray(m, n);                                                      //  вызов метода создания двумерного массива случайных натуральных чисел
PrintArray(array);                                                                  //  вызов метода вывода массива пользователю
Check(coordinates, array, m, n);                                                    //  вызов метода возврата значения запрошенного пользователем элемента
// -------------------------- Конец программы ----------------------------------
// -------------------------Определение методов ---------------------------------
// ------------------------------------------------------------------------------
// метод запроса позиции элемента в массиве у пользователя c выводом ошибки ввода
int GetCoordinatesFromUser(string message)
{
    while (true)
    {
        try
        {
            Console.Write(message);
            coordinates = int.Parse(Console.ReadLine() ?? "");
            if ((coordinates / 10) >= 1 && (coordinates / 10) < 10) return coordinates;
            else Console.WriteLine("Ошибка ввода данных!");
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        }
    }
}
// метод создания двумерного массива случайных натуральных чисел
int[,] GetArray(int M, int N)
{
    int[,] array = new int[M, N];
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
    return array;
}
// метод вывода массива пользователю
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j] + "\t");  // применение символа управляющей последовательности \t  для вставки горизонтальной табуляции
        }
        Console.WriteLine();
    }
}
// метод возврата значения запрошенного пользователем элемента
void Check(int number, int[,] arr, int rows, int columns)
{
    if ((number / 10) > rows || (number % 10) > columns)
        Console.WriteLine($"{number} -> такого числа в массиве нет");
    else if ((number % 10) == 0)
        Console.WriteLine($"{number} -> {arr[((number / 10) - 1), (number % 10)]}");
    else  Console.WriteLine($"{number} -> {arr[((number / 10) - 1), ((number % 10) - 1)]}");
}




