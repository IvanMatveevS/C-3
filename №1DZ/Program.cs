void FillArray (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine("Введите размер массива: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите массив: ");
void PrintArray (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arr [i]} ");
    }
}
int [] array = new int [M];
FillArray(array);
PrintArray(array);

 Console.Write(array);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >  0)
    {   
        count = count + 1;
    }
}
 Console.WriteLine( );
  Console.WriteLine("Количество числе больших 0 :" );
  Console.WriteLine(count);