void FillArray (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr [i] = new Random().Next (0,1000);
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
int P = 0;
int Q = array[1];
for (int i = 0; i < array.Length; i++)
{
    if (P < array [i])
    {   
        P = array [i];
    }
}
for (int i = 0; i < array.Length; i++)
{
    if (Q > array [i])
    {   
        Q = array [i];
    }
}
count = P - Q;

 Console.WriteLine();
 Console.WriteLine(P);
 Console.WriteLine(Q);
  Console.WriteLine("Разница: ");
 Console.WriteLine(count);
