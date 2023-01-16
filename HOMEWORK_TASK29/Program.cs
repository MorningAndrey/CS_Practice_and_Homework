// Задача 29:
// напишите задачу, которая задает массив из 8 элементов и выводит их на экран
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

Console.Clear();
int[] arr = CreateArray(8);
Fill(arr);
Console.WriteLine(Print(arr));

//Метод для создания пустого массива из 8 элементов
int[] CreateArray(int count)
{
    return new int[count];
}

//Метод для заполнения массива числами, запрошенными у пользователя с консоли и проверки чисел на ошибку
void Fill(int[] elements)
{
    int length = elements.Length;
    int i = 0;
    while (i < length)
    {
        while (true)
        {
            Console.WriteLine($"Введите {i}й элемент массива: ");
            bool correctNumber = int.TryParse(Console.ReadLine(), out int userNumber);
            if (correctNumber)
            {
                elements[i] = userNumber;
                break;
            }
            Console.Write("Ошибка ввода");
        }
        i++;
    }
}
// Метод вывода результата программы в консоль
string Print(int[] collection)
{
    string output = String.Empty;
    for (int i = 0; i < collection.Length; i++)
    {
        int current = collection[i];
        output = output + $"{current}, ";
        if (i == collection.Length - 1)
            output = output + $"{current} ";
    }
    return $"{output} -> [{output}]";
}
