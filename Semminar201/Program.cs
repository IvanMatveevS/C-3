﻿// перевод в двоичную систему

// Чтобы десятичное число перевести в двоичную систему 
// исчисления, необходимо последовательно делить его на два,
//  каждый раз записывая результат в виде целого числа 
//  и остатка. Деление нужно продолжать до тех пор, 
//  пока не останется число равное единице. 
//  Итоговое число получается путём последовательной записи
//   результата последнего деления и остатков всех делений 
// в обратном порядке

Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
string dec = string.Empty;
while (a > 1)
{
    Console.Write(a % 2);
    dec = Convert.ToString(a % 2) + dec;
    a = a / 2;
}
Console.WriteLine(a);
dec = Convert.ToString(a) + dec;
Console.WriteLine(dec);
