// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 
Решение */
/* Console.WriteLine ("Ввоод трехзначного числа" );*/
//int a;
/*a = Convert.ToInt32 (Console.ReadLine());
if (a < 1000 & a > 99)
{
    a = (a /10) % 10;
    Console.WriteLine (a);
}
else Console.WriteLine ("ошибка ввода" ); */
/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
Решение */

/* Console.WriteLine ("Ввод числа ");
int number;
void SearchForTheNumberThree ( int number){ 
 if (number < 100)
 {
     Console.Write( number + "-> "+ "Третьей цифры нет");
 }
 else if (number >= 100 & number < 1000)
 {
     int a1 = number % 10;
     Console.Write( number + "-> "+ a1);
 }
 else if (number >= 1000 & number < 10000)
 {
      int a1 = number  / 10 % 10;
     Console.Write( number + "-> "+ a1);
 }
 else if (number >= 10000 & number < 100000)
 {
      int a1 = number  / 100 % 10;
     Console.Write( number + "-> "+ a1);
 }
 else if (number >= 100000 & number < 1000000)
 {
      int a1 = number  / 1000 % 10;
     Console.Write( number + "-> "+ a1);
 }
 else
 {
     Console.Write( number + "-> "+ "Введено много символов. ");
 }

 }

 Console.Write("Введите число:");
 int x = Convert.ToInt32(Console.ReadLine());
 SearchForTheNumberThree(x);
*/
/*
принимает цифру, обозначающую день недели и проверяет, 
является ли этот день выходным.
	6->выходной
	7- выходной
	4 - нет*/
/*Console.WriteLine("введите номер дня недели\n");
num = Convert.ToInt32(Console.ReadLine());
      switch (num)
	{
case 1:
Console.WriteLine("это рабочий день. понедельник\n");
break;
case 2:
Console.WriteLine("это рабочий день. вторник\n");
break;
case 3:
Console.WriteLine("это рабочий день. среда\n");
break;
case 4:
Console.WriteLine("это рабочий день. четверг\n");
break;
case 5:
Console.WriteLine("это рабочий день. пятница. завтра выходной\n");
break;
case 6:
Console.WriteLine("это выходной. суббота\n");
break;
case 7:
Console.WriteLine("это выходной. воскресенье. завтра на работу\n");
break;
default:
Console.WriteLine("в неделе только 7 дней!\n");
break;
}
Console.WriteLine("нажмите любую клавишу");
Console.ReadKey();*/
					


