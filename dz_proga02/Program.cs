// Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

static int SumVal(int value)
{
    if (value < 10)
        return value;
    int dig = value % 10;
    int nextVal = value / 10;
    return dig + SumVal(nextVal);
}
int result = SumVal(number);
Console.WriteLine($"{number} -> " + result);