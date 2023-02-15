void PrintAray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите ограничение по символам:");
int word = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длинну строкового массива:");
int limit = int.Parse(Console.ReadLine());

string[] original = new string[limit];
int k = 0;
string[] result = new string[limit];
string str_user = string.Empty;
int count = 1;
for (int i = 0; i < limit; i++)
{
    Console.WriteLine("Введите " + count + " сроку:");
    str_user = Console.ReadLine();
    original[i] = str_user;
    count++;
    if (original[i].Length < word)
    {
        result[k] = str_user;
        k++;
    }
}

Console.WriteLine("Ваш исходный массив:");
PrintAray(original);
Console.WriteLine();
Console.WriteLine("Ваш итоговый массив:");
PrintAray(result);

