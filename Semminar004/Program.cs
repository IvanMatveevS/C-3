int[]  array = new int[8];

int i = 0;
while ( i < array.Length)
{
    array[i] = new Random().Next(0,2);
    Console.WriteLine(array[i]);
    i++;
    
}