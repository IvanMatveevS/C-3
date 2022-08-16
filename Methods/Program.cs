//////////////////Метод1

/*void Method1() 
{
    Console.WriteLine("Автор: Матвеев И.С.");
}
Method1();*/


/////////////////Метод2


/*void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст ");*/



/*void Method21(string msg, int count)
{
   int i = 0;
   while(i < count)
   {
    Console.WriteLine(msg);
    i++;
   }

}
Method21(count:9, msg:"Текст");*/



/////////////////Метод3

/*int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);*/


/////////////////Метод4

/*string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // записывает и прочитывает как пустая строка


    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;

}

string res = Method4(10, "z9");
Console.WriteLine(res);*/

/////////////////Метод4 используя for

/*string Method4(int count, string text)
{

    string result = String.Empty; // записывает и прочитывает как пустая строка

    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;

}

string res = Method4(10, "z9");
Console.WriteLine(res);*/


/////////////////Метод4 цикл в цикле Таблица умножения

/*string Method4(int count, string text)
{

    string result = String.Empty; // записывает и прочитывает как пустая строка

    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;

}

string res = Method4(10, "z9");
//Console.WriteLine(res);

    for(int i = 2; i <= 10; i++)
    {
        for(int j = 2; j <= 10; j++)
        {
            Console.WriteLine($"{i} * {j} = {i*j}");
        }
         Console.WriteLine();
    }

*/

/*string text = "Собака пошла - Сказал князь, улыбаясь, - что"
            + "ккккктккккккккккк   ССССССССшССССССССССС    ";


string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for(int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) 
        {
            result = result + $"{newValue}";
        }
        else 
        {
            result = result + $"{text[i]}";
        }
    } 

    return result;

}
string newText = Replace(text, ' ', '|' );*/



///////////////////Работа с массивом