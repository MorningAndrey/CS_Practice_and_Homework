//
//Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//

Console.Clear();

int[] array = GetArray(4, -10, 10);            //  вызов метода создания массива из 4х чисел в диапазоне от -10 до 9
Console.WriteLine(String.Join(" ", array));    //  вывода массива в консоль через метод String.Join (только для типа данных String),
                                               //  который объединяет элементы массива и добавляет между ними какой-то знак " ".

ChangeArray(array);                            //  вызов метода замены положительных элементов массива на отрицательные
Console.WriteLine(String.Join(" ", array));    //  вывода массива в консоль через метод String.Join


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}


void ChangeArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
}

