// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
//

int[] array = GetArray(7, -5, 5);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine("-------------");
int[] array2= Create_New_Array(array);
Console.WriteLine(String.Join(" ", array2));


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}


int[] Create_New_Array(int[] arr)
{
    int size=0;
    if (arr.Length%2==1) size=arr.Length/2+1;
    else size=arr.Length/2;
    
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        if ((arr.Length%2==1)&&(i==size-1)) res[i]=arr[i];
        else res[i] = arr[i]*arr[arr.Length-i-1];
    }
    return res;
}



