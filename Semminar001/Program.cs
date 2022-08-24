Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int p = 0;
for(int i = 1; i <= A; i++)
{
  p = p + i;
}
Console.WtiteLine(p);