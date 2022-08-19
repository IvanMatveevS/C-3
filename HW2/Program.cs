// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
/*Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int p = 0;
int q = 0;
while(A % 10 != 0)
{
    p = A % 10;
    A = A / 10;
    q = q + p; 
}

Console.WriteLine(q);*/

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int p = 0;
int q = 0;
while ( A > 0 )
{
    p = A % 10;
    A = A / 10;
    q = q + p; 
}

Console.WriteLine(q);

/*Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[15];
int p = 0;
for (int i = 0; i < 15; i++) 
{
    array[i] = n % 10;
    n /= 10;
}
for (int i = 0; i <= 1000; i++)
{
    p = p + array[i];
}
Console.WriteLine(array);*/
