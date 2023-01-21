﻿// Задача 36:
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.
//[3, 7, 23, 12] -> 19.
//-------------------------- Начало программы ----------------------------------
Console.WriteLine("Выполняется создание массива... ");
int[] arr = GetRandomArray(4);                                // вызов метода создания одномерного массива чисел
int Sum = GetSum(arr);                                        // вызов метода нахождения суммы элементов, стоящих на нечетных позициях
Console.WriteLine($"[{String.Join(", ", arr)}] -> {Sum}");    // вывод массива и суммы элементов, стоящих на нечетных позициях в массиве
// -------------------------- Конец программы ----------------------------------
// -------------------------Определение методов ---------------------------------
// ------------------------------------------------------------------------------
//метода создания одномерного массива случайных трехзначных положительных чисел
int[] GetRandomArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-100, 100);
    }
    return result;
}

//метода нахождения суммы элементов, стоящих на нечетных позициях
int GetSum(int[] randomArray)
{
    int sum = 0;
    for (int i = 0; i < randomArray.Length; i++)
    {
        if (i % 2 == 1)
            sum = sum + randomArray[i];
    }
    return sum;
}
