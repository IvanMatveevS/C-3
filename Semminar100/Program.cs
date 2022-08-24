void FillArray (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr [i] = new Random().Next (-100,100);
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

int [] array = new int [5];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    array [i] = - array [i];
}

PrintArray(array);



/*int i = 0;
while ( i < array.Length)
{
    array[i] = new Random().Next(-10,10);
    Console.WriteLine(array[i]);
    i++;
}
if(array[i]>0)
{
    int p = p + array[i];
}
else
{
    int q = q + array[i];
}
Console.WriteLine(q);
Console.WriteLine(p);*/