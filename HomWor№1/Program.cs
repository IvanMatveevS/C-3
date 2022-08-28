Console.Write("Введите высоту матрицы ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите ширину матрицы ");
int n = int.Parse(Console.ReadLine());


double [,] array = new double[m,n];
void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
       for (int j = 0; j < matr.GetLength(1); j++)
       {
        matr[i,j] = new Random ().Next(-10, 10);
       } 
    }
}
void PrintArray(double[,] matr)
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