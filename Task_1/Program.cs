//Вариант 1.
/*Console.WriteLine("Введи первое число: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введи второе число: ");
int num2 = int.Parse(Console.ReadLine()!);

int max = num1;

if(num1 > num2) max = num1;
if(num1 < num2) max = num2;

Console.Write("max= ");
Console.WriteLine(max);*/

//Вариант 2.
Console.WriteLine("Введи первое число: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введи второе число: ");
int num2 = int.Parse(Console.ReadLine()!);

int max = num1;
int min = num2;

if(num1 > num2) max = num1;
if(num1 > num2) min = num2;
if(num1 < num2) max = num2;
if(num1 < num2) min = num1;

Console.Write("max= ");
Console.WriteLine(max);

Console.Write("min= ");
Console.WriteLine(min);