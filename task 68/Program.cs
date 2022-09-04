Console.WriteLine("введите первое число");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите второе число ");
int n = int.Parse(Console.ReadLine());


int RecursionNumbers(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m != 0 && n == 0)
    {
        return RecursionNumbers(m - 1, 1) ;  
    }
    else
    {
        return RecursionNumbers(m - 1, RecursionNumbers(m, n - 1));    
    }
}
Console.WriteLine(RecursionNumbers (m , n));