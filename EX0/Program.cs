Console.Write($"Введите любое целое число: ");
string input = Console.ReadLine() ??"";

int number = int.Parse(input);
double result = Math.Pow(number, 2);

Console.WriteLine(result);  












