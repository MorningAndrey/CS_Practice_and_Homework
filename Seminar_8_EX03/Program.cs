// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
//-------------------------- Начало программы ----------------------------------
Console.Clear();
int rows =GetNumberFromUser($"Введите количество строк массива: ", "Ошибка ввода!");
int columns =GetNumberFromUser($"Введите количество столбцов массива: ", "Ошибка ввода!");
int[,] array = GetArray(rows, columns);
PrintArray(array);
string[] final = GetResult(array);
Console.WriteLine(String.Join("\n", final.Distinct()));            // вывод результата пользователю
// -------------------------- Конец программы ----------------------------------
// -------------------------Определение методов ---------------------------------
// ------------------------------------------------------------------------------
// Метод корректного ввода числа пользователем 
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            if(userNumber <=100 && userNumber > 0)              // допустимый диапазон ввода (0, 100]
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
// Метод определения двумерного массива заполненного случайными числами из диапазона [0, 10)
int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(10);
        }
    }
    return result;
}
// Метод вывода массива пользователю
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
// метод определения частотного словаря
string[] GetResult(int[,] arr)
{
    int temp = 0;
    int sum = 0;
    string text = String.Empty;
    string[] res = new string[10000];
    int d = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            temp = arr[i, j];
            sum = 0;
            foreach (int q in arr)
            {
                if (q == temp) sum++;
            }
            if (sum == 2 || sum == 3 || sum == 4)
                text = ($"{arr[i, j]} встречается {sum} раза");
            else text = ($"{arr[i, j]} встречается {sum} раз");
            res[d] = text;
            d++;
        }
    }
    return res;
}
