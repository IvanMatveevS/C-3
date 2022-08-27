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
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
       for (int j = 0; j < matr.GetLength(1); j++)
       {
        Console.Write(matr[i,j] + " ");
       } 
    }
}
FillArray(array);
PrintArray(array);