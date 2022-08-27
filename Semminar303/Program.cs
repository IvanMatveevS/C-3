Console.Write("Введите высоту матрицы ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите ширину матрицы ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m,n];
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
       for (int j = 0; j < matr.GetLength(1); j++)
       {
        matr[i,j] = new Random().Next(1,10);
       } 
    }
}

void sqrt (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i = i + 2)
    {
       for (int j = 0; j < matr.GetLength(1); j = j + 2)
       {
        matr[i,j] =  matr[i,j] *  matr[i,j];
       } 
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
       for (int j = 0; j < matr.GetLength(1); j++)
       {
        Console.Write(matr[i,j] + " ");
       } 
       Console.WriteLine();
    }
}
FillArray(array);
PrintArray(array);
sqrt(array);
Console.WriteLine();
PrintArray(array);