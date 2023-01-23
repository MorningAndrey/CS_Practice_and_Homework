// Задача 43: 
// Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями
// y = k1*x + b1, y = k2*x + b2; значения b1, k1, b2, k2 задаются пользователем
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// -------------------------- Начало программы ----------------------------------
Console.Clear();
double b1 = 0, k1 = 0, b2 = 0, k2 = 0;                  // объявление переменных 
InitNumbersByUser(ref b1, ref k1, ref b2, ref k2);      // функция ввода значений пользователем с проверкой на ошибки ввода данных
GetResult(b1, k1, b2, k2);                              // метод вычисления точки пересечения двух прямых
// -------------------------- Конец программы ----------------------------------
// -------------------------Определение методов ---------------------------------
// ------------------------------------------------------------------------------
// Определяем функцию, выполняющую ввод значений для определения точек прямой на координатной плоскости
void InitNumbersByUser(ref double B1, ref double K1, ref double B2, ref double K2)
{
    while(true)
    {
        try
        {
            Console.Write("Введите b1: ");
            B1 = double.Parse(Console.ReadLine() ?? "");
            Console.Write("Введите k1: ");
            K1 = double.Parse(Console.ReadLine() ?? "");
            Console.Write("Введите b2: ");
            B2 = double.Parse(Console.ReadLine() ?? "");
            Console.Write("Введите k2: ");
            K2 = double.Parse(Console.ReadLine() ?? "");
            return;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        }
    }
}
// метод вычисления точки пересечения двух прямых
void GetResult(double B1, double K1, double B2, double K2)
{ 
    if (K1 != K2 )
    {
        double x = Math.Round((B2 - B1) / (K1 - K2), 2);
        double y = Math.Round((K2 * x + B2), 2);
        Console.WriteLine($"b1 = {B1}, k1 = {K1}, b2 = {B2}, k2 = {K2} -> ({x};{y})");
    }
        else if (B1 == B2 )
            Console.Write("Прямые совпадают");
        else Console.Write("Прямые параллельны между собой (нет точек пересечения)");
}