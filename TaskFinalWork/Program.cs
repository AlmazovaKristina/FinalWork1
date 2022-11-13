Console.Write("Введите колличество значений:");
int size = Convert.ToInt32(Console.ReadLine());

string[] words = new string[size];
SetWords(words);
PrintArray(words);
Console.WriteLine();
string[] shortWords = FilterShort(words);
PrintArray(shortWords);
Console.WriteLine();

void SetWords(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}е значение: ");
        array[i] = Console.ReadLine();
    }
}

string[] FilterShort(string[] values)
{
    bool[] indexes = new bool[values.Length];
    int size = 0;
    for (int i = 0; i < values.Length; i++)
    {
        if (values[i].Length <= 3)
        {
            indexes[i] = true;
            size++;
        }
    }
    string[] result = new string[size];
    int j = 0;
    for (int i = 0; i < values.Length; i++)
    {
        if (indexes[i] == true)
        {
            result[j] = values[i];
            j++;
        }
    }
    return result;
}

void PrintArray (string[] array)
{
    Console.Write("[");
    for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]},");
    Console.Write($"{array[array.Length - 1]}]");
}
