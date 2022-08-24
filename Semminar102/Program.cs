void FillArray (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr [i] = new Random().Next (0,150);
    }
}
int [] array = new int [123];
FillArray(array);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 10 & array[i] < 99)
    {   
        // Console.Write($"{array[i]} ");
        count++;

    }
}
Console.WriteLine(count);
Console.WriteLine();
Console.WriteLine();
PrintArray(array);

void PrintArray (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arr [i]} ");
    }
}
