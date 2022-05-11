// Найти третью цифру числа или сообщить, что её нет
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num > 99 && num < 1000 || num > -1000 && num < -99)
{
    Console.WriteLine($"3-я цифра введенного числа равна {Math.Abs(num % 10)}!");
}
else if (num >= 0 && num <= 99 || num < 0 && num >= -99)
{
     Console.WriteLine("У введенного числа нет 3-ей цифры!");
}
else
{
    int count = 0;
    int num2 = Math.Abs(num);
    int dig3 = Math.Abs(num);
    while (num2 > 0) //Считаем количество цифр введенного числа
        {
            num2 = num2 / 10;
            count++;
        }
        while (count > 3) //Убираем лишние цифры числа до 3-х
        {
            dig3 = dig3 / 10;
            count = count - 1;
        }
    Console.WriteLine($"3-я цифра введенного числа равна {dig3 % 10}");
}
