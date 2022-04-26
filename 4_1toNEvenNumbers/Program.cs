// Показать четные числа от 1 до N
Console.Write("Введите диапазон N: ");
int n = int.Parse(Console.ReadLine());
int count = 2;
if (n < 2)
{
    Console.WriteLine("Введен неверный диапазон!");
}
else
{
    Console.WriteLine("Четные числа от 1 до N:");
    while (count <= n)
    {
        Console.Write($"{count} ");
        count = count + 2;
    }
    Console.WriteLine();
}