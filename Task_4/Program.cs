Console.Write("Введи число: ");
int num = int.Parse(Console.ReadLine()!);
int result = 1;

while (result <= num)
{
    if (result%2 == 0)
    Console.WriteLine(result);
    result++;
}