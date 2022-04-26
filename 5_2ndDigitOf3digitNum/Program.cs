// Показать вторую цифру трёхзначного числа
Console.Write("Введите 3-х значное число: ");
int n = int.Parse(Console.ReadLine());
if (n > 99 && n < 1000)
{
    n = n / 10 % 10;
    Console.WriteLine($"Вторая цифра 3-х значного числа: {n}");
}
else
{
    Console.WriteLine("Введено не 3-х значное число!");
}