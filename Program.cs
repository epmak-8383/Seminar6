int[] CreateMassive(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива {i}: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > 0)
        {
            count++;
        }
    }
        Console.WriteLine(count);
    Console.WriteLine("Массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.ReadLine();
    return array;
}

Console.Write("Введите число чисел: ");
int length = int.Parse(Console.ReadLine());
CreateMassive(length);