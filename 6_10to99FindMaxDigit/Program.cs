// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.Write("Введите число из отрезка [10, 99]: ");
int num = int.Parse(Console.ReadLine());
if (num < 10 || num > 99)
{
    Console.WriteLine("Введен неверный диапазон!");
}
else
{
    Console.Write("Наибольшая цифра числа: ");
    int dig1 = num / 10;
    int dig2 = num % 10;
    if (dig1 >= dig2)
    {
        Console.WriteLine(dig1);
    }
    else
    {
        Console.WriteLine(dig2);
    }
}