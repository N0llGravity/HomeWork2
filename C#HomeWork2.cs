// Вывод второго знака из любого заданного числа

double ReverseNegative(double num)         //проверяем число и преобразовываем в положительное если необходимо
{
    if(num < 0)
    {
        num = num * -1;                      
    }
    return num;
    
}

void LessTen(double smallnum, double startnum)              //Работа с дробными числами меньше 10
    {
        if(smallnum == Math.Floor(smallnum))
        {
            Console.WriteLine($"Number {startnum} has not a second digit");
        }
        
        else
        {
            double secondDigit = Math.Floor((smallnum % 1) * 10);
            Console.WriteLine($"Second digit in number {startnum} is {secondDigit}");
        }

    }

void MoreTen(double bignum, double startnum)                //Работа числами больше 10
{
    while(bignum > 100)
    {
        bignum = bignum / 10;
    }
    double secondDigit = Math.Floor(bignum % 10);
    Console.WriteLine($"Second digit in number {startnum} is {secondDigit}");
}


Console.WriteLine("Input any number ");     
double n = Convert.ToDouble(Console.ReadLine());
double reversed = ReverseNegative(n);
if (reversed < 10)                                          //Сортировка числа по методам взависимости от величины
LessTen(reversed, n);
else
MoreTen(reversed, n);