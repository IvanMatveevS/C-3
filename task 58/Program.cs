Console.WriteLine("размер матрицы и диапзаон случ чисел");
int m = InputNumbers("число строк матрицы 1");
int n = InputNumbers("число столбцов матриц 1 и строк 2ой");
int p = InputNumbers("число столбцов матриц 2");

void MultiplyMatrix(int[,] fMatrix, int[,] sMatrix, int[,] rMatrix)
{
    for (int i = 0; i < rMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < rMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; j < fMatrix.GetLength(1); k++)
            {
                sum += fMatrix[i,k] * sMatrix[k,j];
            }
            rMatrix[i,j] = sum;
        }
    }
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
            array[i, j] = new Random().Next(10);
        }
    }
}

void PrintArray(int[,] array)
{
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
}

int[,] fMatrix = new int[m,n];
CreatArray(fMatrix);
Console.WriteLine("первая матрица: ");
PrintArray(fMatrix);

int[,] sMatrix = new int[n,p];
CreatArray(sMatrix);
Console.WriteLine("вторая матрица: ");
PrintArray(sMatrix);

int[,] rMatrix = new int[m,p];
MultiplyMatrix(fMatrix, sMatrix, rMatrix);
Console.WriteLine("произведение ");
PrintArray(rMatrix);

