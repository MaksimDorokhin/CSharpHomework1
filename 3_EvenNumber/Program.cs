//Выяснить является ли число чётным
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine("Введенное число - четное!");
}
else
{
    Console.WriteLine("Введенное число - нечетное!");
}