//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом. 
// -------------------------- Начало программы ----------------------------------
Console.Clear();
int num = 0;
double exc1 = 0;
CorrectUserInput(ref num, ref exc1);    // Вызов метода с передачей параметров по ссылке (ref)
PrintResult(num);                      // Вызов метода с передачей параметра по значению
// -------------------------- Конец программы ----------------------------------
// -------------------------Определение методов --------------------------------
//------------------------------------------------------------------------------
/*Определяем функцию, выполняющую ввод корректного пятизначного числа*/
static void CorrectUserInput(ref int num, ref double exc1)
{
    try
    {
        Console.Write("Введите целое пятизначное число: ");
        num = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"{exc.Message}");
    }
    exc1 = num / 10000;
    if (exc1 < 1 && exc1 >= 0 || exc1 > 10 || exc1 < -10)
    {
        Console.WriteLine("Ошибка ввода!");
        CorrectUserInput(ref num, ref exc1);
    }
}
// -----------------------------------------------------------------------------
// Определяем функцию, принимающую аргумент (введенное пользователем пятизначное целое число)
// и выводящую в консоль результат: является ли оно палиндромом
static void PrintResult(int num)
{
    int a = num / 10000;
    int b = num % 10;
    int c = (num / 1000) % 10;
    int d = (num % 100) / 10;
    if (a == b || a == b && c == d)
        Console.Write($"{num} -> Да");
    else
        Console.Write($"{num} -> Нет");
}