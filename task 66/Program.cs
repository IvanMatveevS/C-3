Console.WriteLine("введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите второе число ");
int b = int.Parse(Console.ReadLine());


int RecursionNumbers(int a, int b)
{
    
    if (b == a)
    {
        return b;
    }
    else
    {
        return RecursionNumbers(a, b - 1) + b;    
    }
}
Console.WriteLine(RecursionNumbers (a , b));