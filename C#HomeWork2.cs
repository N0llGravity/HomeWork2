// Вывод второго знака из любого заданного числа

void DigitCounter(double num)
{
    if(num < 0)
    {
        num = num * -1;                      //Math.Floor((n % 1) * 10)
    }
    if (num < 10)
    {
        if(num == Math.Floor(num))
        {
            Console.WriteLine($"Number {num} has not a second symbol");
        }
        else
        {
            
        }

    }   
}   

double n = Convert.ToDouble(Console.ReadLine());
DigitCounter(n);