Console.Write("Введите первое число: "); // вывод информации на консоль
string input_1 = Console.ReadLine() ??""; // считывание строки, введенной пользователем в консоль

Console.Write("введите второе число: "); 
string input_2 = Console.ReadLine() ??"";

int number_1 = int.Parse(input_1); // обработка пользовательского ввода, т.е. преобразование строки в число
int number_2 = int.Parse(input_2);

int result = (int)Math.Pow(number_2, 2);

if(number_1 == result)
{
    Console.WriteLine($"Да, {input_1} является квадратом {input_2}");
}
else
{
    Console.WriteLine($"Нет, {input_1}  не является квадратом {input_2}");
}


