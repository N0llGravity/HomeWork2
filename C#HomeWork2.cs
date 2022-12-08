// Вывод второго знака из заданного числа

double DigitCounter(double num)
{
    if(num < 0)
    {
        num = num * - 1;
    }
    return Math.Floor(num);
}

double n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(DigitCounter(n));