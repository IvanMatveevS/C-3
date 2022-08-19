/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
*/
int[]  array = new int[8];

int i = 0;
while ( i < array.Length)
{
    array[i] = new Random().Next(0,100);
    Console.WriteLine(array[i]);
    i++;
    
}




/*int[]  array = new int[8];

array[0] = 1;
array[1] = 2;
array[2] = 3;
array[3] = 4;
array[4] = 5;
Console.WriteLine(array);
*/

/*int[]  array = new int[8];
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
int e = Convert.ToInt32(Console.ReadLine());
int i = 0;
while ( i < array.Length)
{
    array[0] = a;
    array[1] = b;
    array[2] = c;
    array[3] = d;
    array[4] = e;
    
}
Console.WriteLine(array);
*/
