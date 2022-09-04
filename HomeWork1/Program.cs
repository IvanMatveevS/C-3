Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
void RecursionNumbers(int i)
{
    if (i == 0)
    {
        Console.Write($" {i}");
    }
    else
    {
        Console.Write($" {i}");
        i--;
        RecursionNumbers(i);
    }
}
RecursionNumbers(n);
