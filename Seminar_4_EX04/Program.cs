// Задача 30: 
// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// Console.Clear();

// int[] arr = CreateArray(8);     // создание массива
// Fill(arr);                      // заполнение массива
// Console.WriteLine(Print(arr));  // вывод массива пользователю


// int[] CreateArray(int count)
// {
//     return new int[count];
// }


// void Fill(int[] elements)
// {
//     int length = elements.Length;
//     int index = 0;
//     while (index < length)
//     {
//         int current = Random.Shared.Next(2);
//         elements[index] = current;
//         index++;
//     }
// }


// string Print(int[] collection)
// {
//     string output = String.Empty;
//     for (int index = 0; index < collection.Length; index++)
//     {
//         int current = collection[index];
//         output = output + $" {current},";
//     }
//     return $"[{output}]";
// }

PrintArray();

void PrintArray()
{
    Console.Write("[");
    for (int i = 0; i < 7; i++)
    {
        Console.Write($"{new Random().Next(0, 2)}, ");
    }
    Console.Write($"{new Random().Next(0, 2)}");
    Console.Write("]");
}


