// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.WriteLine("Введите 2 числа: ");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int p = A;
int i = 1;

while(i < B)
{
    i++;
    p = p * A;
}
Console.WriteLine(p);