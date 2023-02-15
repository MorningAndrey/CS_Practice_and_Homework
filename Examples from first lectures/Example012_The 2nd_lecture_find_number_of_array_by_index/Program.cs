int[] array = { 1, 2, 3, 53, 5, 6, 67, 8, 9, 45, 67, 53 };

int n = array.Length;
int find = 53;

int index = 0;

while (index < n)
{

    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

