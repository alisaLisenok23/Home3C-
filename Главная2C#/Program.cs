// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 
Решение */
Console.WriteLine ("Ввоод трехзначного числа" );*/
int a;
a = Convert.ToInt32 (Console.ReadLine());
if (a < 1000 & a > 99)
{
    a = (a /10) % 10;
    Console.WriteLine (a);
}
else Console.WriteLine ("ошибка ввода" ); 
/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
Решение */

Console.WriteLine ("Ввод числа ");
int number;
number=Convert.ToInt32(Console.ReadLine());
 if (number < 100)
 {Console.WriteLine("нет третьего числа");
}
  
 else if (number >= 100 & number < 1000)
 {
     for(;number>999;)
{
number=number/10;
}
number=number%10;
Console.WriteLine(number);

 Console.Write("Введите число обозначающее день недели");
 int x = Convert.ToInt32(Console.ReadLine());
 
/*
принимает цифру, обозначающую день недели и проверяет, 
является ли этот день выходным.
	6->выходной
	7- выходной
	4 - нет*/
if(x<6)
Console.WriteLine("рабочий день.")
else if (x==6 | x==7)
Console.WriteLine("выходной день");
else Console.WriteLine("ошибка ввода дня недели");		


