Console.Clear();
int m = new Random().Next(2, 11); 
int n = new Random().Next(2, 11); 
Console.WriteLine();

int[,] array = new int[m, n];

void FillPrint2DArray(int[,] arr, int rangeMin, int rangeMax) 
{
for (int i = 0; i < arr.GetLength(0); i++)
{
Console.Write("{");
for (int j = 0; j < arr.GetLength(1); j++)
{
arr[i, j] = new Random().Next(rangeMin, rangeMax);
if (j < arr.GetLength(1) - 1)
{
if (arr[i, j] == -10) Console.Write($"{arr[i, j]}, ");
if ((arr[i, j] >= -9) && (arr[i, j] < 0)) Console.Write($"{arr[i, j]}, ");
if (arr[i, j] == 10) Console.Write($" {arr[i, j]}, ");
if ((arr[i, j] <= 9) && (arr[i, j] >= 0)) Console.Write($" {arr[i, j]}, ");

}
else
{
if (arr[i, j] == -10) Console.Write($"{arr[i, j]} ");
if ((arr[i, j] >= -9) && (arr[i, j] < 0)) Console.Write($"{arr[i, j]} ");
if (arr[i, j] == 10) Console.Write($" {arr[i, j]} ");
if ((arr[i, j] <= 9) && (arr[i, j] >= 0)) Console.Write($" {arr[i, j]} ");
}
}
Console.Write("}");
Console.WriteLine();
}

}

Console.WriteLine($"Given randomly sized array of {m} rows and {n} columns is: ");
FillPrint2DArray(array, -10, 11);

Console.WriteLine();
Console.WriteLine("Enter the index of the element to find, i.e. the row index, then the column index: ");
int m1 = Convert.ToInt32(Console.ReadLine());
int n1 = Convert.ToInt32(Console.ReadLine());

void FindElement(int[,] arr) // Find the element by its index
{
if (m1 > m - 1 || n1 > n - 1) Console.WriteLine("There is no such index it this array.");
else Console.WriteLine($"The value of the element in position [{m1}, {n1}] of the array is: {arr[m1, n1]}");
}

FindElement(array);
Console.WriteLine();