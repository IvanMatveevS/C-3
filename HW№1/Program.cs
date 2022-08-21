void FillArray (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr [i] = new Random().Next (101,1000);
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
    if (array[i] % 2 == 0)
    {   
        count++;
    }
}
Console.WriteLine();
Console.WriteLine("Количество четных:");
Console.WriteLine(count);