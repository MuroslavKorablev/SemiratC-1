//Напишите программу, которая принимает на вход трехзначное число и на выход показывает последнюю цифру этого числа.
System.Console.WriteLine("Видите трехзначное число ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a / 100;
System.Console.WriteLine (b);
int c = (a % 100)/10;
System.Console.WriteLine(c);
int d = a % 10;
System.Console.WriteLine(d);