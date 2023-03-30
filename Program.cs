Console.Write("Введите количество элементов массива: ");
int z = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[z];
void mas(int z)
{
    for (int i = 0; i < z; i++)
    {
        Console.Write($"Введите {i+1} элемент массива ");
        Array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int kol(int[] Array)
{
    int i=0;
    int sum = 0;
    while (i < Array.Length)
    {
        if(Array[i]>0)
        sum = sum + 1;
        i = i + 1;
    }
    return sum;
}
mas(z);
Console.WriteLine($"\n Чисел больше нуля: {kol(Array)}");
