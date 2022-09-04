int[,,] array = new int[3, 3, 3];

void Fill3DArrNonRepeat(int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(2); k++)
    {
       for (int i = 0; i < arr.GetLength(0); i++) 
       {
        for (int j = 0; k < arr.GetLength(1); j++)
        {
        Repeat:
        int check = new Random().Next(10, 100) * (new Random().Next(0, 2) * 2 - 1);
        int k1, i1, j1;
            for ( k1 = 0; k1 < arr.GetLength(2); k1++)
            {
                for ( i1 = 0; i1 < arr.GetLength(0); i1++) 
                {
                    for ( j1 = 0; j1 < arr.GetLength(1); j1++)
                    {
                        if (arr[i1, j1, k1] == check)
                        {
                            goto Repeat;
                        }
                        if ((i1 == i) && (j1 == j) && (k1 == k))
                        {
                            arr[i, j , k] = check;
                            break;
                        }
                    }
                }
            }
       }
    }
}
}

void Print3DArray(int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(2); k++)
    {
        Console.WriteLine($"Block {k}------------------------");
        for (int i = 0; i < arr.GetLength(0); i++) 
       {
        Console.Write("|");
        for (int j = 0; k < arr.GetLength(1); j++)
        {
            Console.Write("{0,14]", $"{arr[i, j , k]} ({i}:{j}:{k})|");
        }
        Console.WriteLine();
        Console.WriteLine();
       }
       Console.WriteLine("--------------");
    }
}
Fill3DArrNonRepeat(array);
Print3DArray(array);