Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int B = 1;
while (A!= 0)
{
   
   B  = B * A ;
   A = A - 1;
}
 Console.WriteLine(B);