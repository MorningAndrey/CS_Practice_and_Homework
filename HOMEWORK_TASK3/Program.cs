Console.Write("Введите первое целое число: ");
string input1 = Console.ReadLine() ??"";
int a = int.Parse(input1);

Console.Write("Введите второе целое число: ");
string input2 = Console.ReadLine() ??"";
int b = int.Parse(input2);

Console.Write("Введите третье целое число: ");
string input3 = Console.ReadLine() ??"";
int c = int.Parse(input3);

// Наиболее коротким вариантом решения является применение метода Math.Max():
int first_comparison = Math.Max(a, b);
int result = Math.Max(first_comparison, c);

Console.WriteLine($"максимальным из трех чисел является число {result}");

// либо ветвление через if:
//int max = a;
//if(a < b)
//{
//    max = b;
//}
//if( max < c)
//{
//    max = c;
//}
//Console.WriteLine($"максимальным из трех чисел является число {max}");

