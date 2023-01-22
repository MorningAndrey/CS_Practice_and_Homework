// Задача 41:
// Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше нуля ввел пользователь.
// 0, 7, 8, -2, -2 -> 2.
//-------------------------- Начало программы ----------------------------------
Console.Clear();
int[] num = CorrectUserInput("Введите число: ", "Ошибка ввода", 5);     // метод создания одномерного массива из чисел, вводимых пользователем
Console.Write(String.Join(" ,", num));                                  
int res = GetResult(num);                                               // метод определения количества положительных чисел, введенных пользователем
Console.Write($" -> {res}");
// -------------------------- Конец программы ----------------------------------
// -------------------------Определение методов ---------------------------------
// ------------------------------------------------------------------------------
//метода создания одномерного массива из чисел, вводимых пользователем
int[] CorrectUserInput(string number, string errMessage, int size)
{
    int[] a = new int[size];
    int q = 0;
    for (int i = 0; i < size; i++)
    {
        while (true)
        {
            Console.WriteLine(number);
            bool userNumber = int.TryParse(Console.ReadLine(), out int correctNumber);
            if (userNumber)
            {
                q = correctNumber;
                break;
            }
            else Console.WriteLine(errMessage);
        }
        a[i] = q;
    }
    return a;
}
// метод определения количества положительных чисел, введенных пользователем
int GetResult (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if(array[i] > 0)
            sum++;
    return sum;
}
