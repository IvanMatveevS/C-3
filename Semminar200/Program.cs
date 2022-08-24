int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int C = Convert.ToInt32(Console.ReadLine());
if (A < B + C && B < A + C && C < A + B )
{
    Console.WriteLine("Может");
}
else
{
    Console.WriteLine("Неможет");
}