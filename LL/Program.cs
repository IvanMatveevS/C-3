int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[5];

for (int i = 0; i < 5; i++) 
{
    array[i] = n % 10;
    n /= 10;
}

int length = 5;
int errors = 0;

for (int i = 0; i <= 2; i++)
{
    if (array[i] == array[length - i - 1])
    {
        continue;
    }
    else
    {
        errors += 1;
    }
}

if (errors == 0)
{
    Console.WriteLine("Введённое число является палиндромом");
}
else
{
    Console.WriteLine("Введённое число не является палиндромом");
}
