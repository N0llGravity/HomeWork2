// Вывод второго знака из любого заданного числа

double ReverseNegative(double num)         //проверяем число и преобразовываем в положительное если необходимо
{
    if(num < 0)
    {
        num = num * -1;                      
    }
    return num;
    
}

void LessTen(double smallnum)              //Работа с дробными числами меньше 10
    {
        if(smallnum == Math.Floor(smallnum))
        {
            Console.WriteLine($"Number {smallnum} has not a second digit");
        }
        
        else
        {
            double secondDigit = Math.Floor((smallnum % 1) * 10);
            Console.WriteLine($"second digit of in number {smallnum} is {secondDigit}");
        }

    }

void MoreTen(double bignum)
{
    bignum
}


double n = Convert.ToDouble(Console.ReadLine());
ReverseNegative(n);





//Math.Floor((n % 1) * 10)
// Console.WriteLine($"Number {num} has not a second digit");