Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (A / 10 != 0)
{
   A = A / 10;
   i = i + 1;
}
 Console.WriteLine(i + 1);