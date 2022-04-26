// Удалить вторую цифру трёхзначного числа
Console.Write("Введите 3-х значное число: ");
int n = int.Parse(Console.ReadLine());
if (n > 99 && n < 1000)
{
    int dig1 = n / 100;
    int dig3 = n % 10;
    Console.WriteLine($"Число после удаления второй цифры: {dig1}{dig3}");
}
else
{
    Console.WriteLine("Введено не 3-х значное число!");
}