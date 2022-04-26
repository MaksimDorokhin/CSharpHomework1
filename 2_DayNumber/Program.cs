//По заданному номеру дня недели вывести его название
Console.Write("Введите номер дня недели: ");
int daynum = int.Parse(Console.ReadLine());
if (daynum == 1)
{
    Console.WriteLine($"Название дня с номером {daynum} - Понедельник!");
}
if (daynum == 2)
{
    Console.WriteLine($"Название дня с номером {daynum} - Вторник!");
}
if (daynum == 3)
{
    Console.WriteLine($"Название дня с номером {daynum} - Среда!");
}
if (daynum == 4)
{
    Console.WriteLine($"Название дня с номером {daynum} - Четверг!");
}
if (daynum == 5)
{
    Console.WriteLine($"Название дня с номером {daynum} - Пятница!");
}
if (daynum == 6)
{
    Console.WriteLine($"Название дня с номером {daynum} - Суббота!");
}
if (daynum == 7)
{
    Console.WriteLine($"Название дня с номером {daynum} - Воскресение!");
}
if (daynum < 0 || daynum > 7)
{
    Console.WriteLine($"Дня с номером {daynum} не существует!");
}