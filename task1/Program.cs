// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число (A), которое хотите возвести в степень: ");
string NumberA = Console.ReadLine();
Console.WriteLine("Введите степень (B), в которую хотите возвести число A: ");
string NumberB = Console.ReadLine();
int first = int.Parse(NumberA);
int second = int.Parse(NumberB);

if(IsNumberPositive(second))
{
    double result = Math.Pow(first, second);
    Console.WriteLine($"Результат возведения числа {first} в степень {second} равняется: {result} ");
}
else
{
    Console.WriteLine("Введено некорректное число");
}

bool IsNumberPositive(int second)
{
    return second > 0;
}





