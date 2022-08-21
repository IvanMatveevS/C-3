void FillArray (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr [i] = new Random().Next (0,10);
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
    if (i % 2 == 1)
    {   
        count = count + array[i];
    }
}
Console.WriteLine();
Console.WriteLine("Сумма: ");
Console.WriteLine(count);