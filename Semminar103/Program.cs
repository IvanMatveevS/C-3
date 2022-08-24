int[] array = new int[5];

int length = array.Length;
int index = 0;

while(index < length)
{
    array[index] = new Random().Next(0, 5);
     Console.Write($"{array[index]}  ,");
    index++;
    
   
}
Console.WriteLine();
for ( int i = 0; i <( (length / 2) + 1); i++)
{
    Console.WriteLine();
    if (i != (length -i -1) )
    {
        Console.Write($"{ array[i] * array[length -i -1]}  ,");
        
    }
    else 
    {
    Console.WriteLine(array[i]);
    }

}
//Console.WriteLine();
int[] TotalArray(int col)
{
    int[] array = new int[col];
    int i = 0;
    while (i < array.Length)
    {
        Random rand = new Random();
        array[i] = rand.Next(1, 100);
        Console.WriteLine(Convert.ToString(array[i]) + ", ");
        i++;
    }
    return array;
}


Console.WriteLine("Введите длинну массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = TotalArray(m);
int i = 0;
int w = array.Length -1;
while (i < array.Length)
{
    
    if(i != w){
        Console.Write(Convert.ToString(array[i] + array[w]) + ", ");
    }
    else{
       Console.Write(array[i]); 
       return;
    }
    i++;
    w--;
}
