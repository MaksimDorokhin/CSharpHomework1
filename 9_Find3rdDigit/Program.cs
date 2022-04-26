// Найти третью цифру числа или сообщить, что её нет
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num > 99)
{
    if (num < 1000)
    {
        Console.WriteLine($"3-я цифра введенного числа равна {num % 10}!");
    }
    else
    {
        int count = 0;
        int num2 = num;
        int dig3 = num;
        while (num2 > 0) //Считаем количество цифр введенного числа
        {
            num2 = num2 / 10;
            count++;
        }
        while (count > 3) //Убираем лишние цифры числа до 3-го
        {
            dig3 = dig3 / 10;
            count = count - 1;
        }
        
         Console.WriteLine($"3-я цифра введенного числа равна {dig3 % 10}");
    }
}
else
{
     Console.WriteLine("У введенного числа нет 3-ей цифры!");
}