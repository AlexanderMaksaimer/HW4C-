// Задача № 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int number = checkNumInput();

Console.WriteLine($"{number} -> {SummNumbers(number)} - сумма цифр в заданном числе");


int checkNumInput()
{
    bool StrInt = true;
    int number =0;
    while (StrInt)
    {
        Console.WriteLine("Введите число (больше чем 10) : ");
        string NumStr = Console.ReadLine();
        if (int.TryParse(NumStr, out int IntNum) )
        {
            number = IntNum;
            if (number < -9 )
            {
                Console.WriteLine($"Взял число {number} по модулю - > {-number}");
                number *= -1;
                StrInt = false;
                }
            else if (number <= 9) Console.WriteLine("Вы ввели число меньше 10");
            else StrInt = false;
            } 
            
        } 
return number;
}


int SummNumbers(int number)
{
    int FromNumber =0;
    int sum =0;
    while ( number > 9)
    {
        FromNumber = number%10;
        number = number/10;
        sum = sum+FromNumber;
        }
    sum = sum + number;
return sum;
}


