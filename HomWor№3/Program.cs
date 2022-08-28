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

int count = 0;
void sqrt (int[,] matr)
{
   
    for (int i = 0; i < matr.GetLength(0); i++)
    {
       for (int j = 0; j < matr.GetLength(1); j++)
       {
        for (int p = 0; p <= matr.GetLength(1); p++)
          {  
            if(j == p ) count = count + matr[i,j];
          }
        //if( j == p ) count = count + matr[i,j]; 
       } 
    Console.WriteLine(count);
    count = 0;
    }
    
    

//    Console.WriteLine(count);
//     count = 0;
    
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
Console.WriteLine("Сумма :");
// p++;
// count = 0;
// sqrt(array);
// Console.WriteLine("Сумма :");
// p++;
// count = 0;
// sqrt(array);
// Console.WriteLine("Сумма :");
// p++;
// count = 0;
// sqrt(array);
