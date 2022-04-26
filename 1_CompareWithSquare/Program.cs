//По двум заданным числам проверять является ли первое квадратом второго
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
if (a == b * b)
{
    Console.WriteLine("Число a является квадратом числа b!");
}
else
{
    Console.WriteLine("Число a не является квадратом числа b!");
}