// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.Write("Введите проверяемое число: ");
int numChk = int.Parse(Console.ReadLine());
Console.Write("Введите число, кратно которому должно быть проверяемое: ");
int numMult = int.Parse(Console.ReadLine());
if ((numChk % numMult) == 0)
{
    Console.WriteLine($"Число {numChk} кратно числу {numMult}!");
}
else
{
     Console.WriteLine($"Число {numChk} не кратно числу {numMult}, остаток равен {numChk % numMult}"!);
}