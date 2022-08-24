void FillArray (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr [0] = Convert.ToInt32(Console.ReadLine());
        arr [1] = Convert.ToInt32(Console.ReadLine());
        arr [2] = Convert.ToInt32(Console.ReadLine());
        arr [3] = Convert.ToInt32(Console.ReadLine());
        arr [4] = Convert.ToInt32(Console.ReadLine());
        arr [5] = Convert.ToInt32(Console.ReadLine());
        arr [6] = Convert.ToInt32(Console.ReadLine());
        arr [7] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arr [i]} ");
    }
}
int [] array = new int [8];
FillArray(array);
PrintArray(array);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {   
        count++;
    }
}
Console.WriteLine();
Console.WriteLine("Количество больших нуля: ");
Console.WriteLine(count);