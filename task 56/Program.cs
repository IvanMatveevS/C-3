Console.WriteLine("введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите n");
int n = Convert.ToInt32(Console.ReadLine());

int[ , ] array = new int[m , n];
CreatArray(array);
WriteArray(array);

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for(int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = SumLineElements(array,i);
    if(sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}

Console.WriteLine($"\n {minSumLine+1} - строка с наименьшей суммой ({sumLine}) элементов ");

int SumLineElements(int[,] array, int i)
{
    int sumLine = array [i, 0];
    for( int j = 0; j < array.GetLength(1); j++)
    {
        sumLine += array[i,j];
    }
    return sumLine;
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreatArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(100);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}