// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void Palindrom(int a)
{
    int last = a%10;
    Console.WriteLine("Last figure: " + last );
    int four = (a/10)%10;
    Console.WriteLine("Four figure: " + four );
    int first = a/10000;
    Console.WriteLine("First: " + first );
    int second = (a/1000)%10;
    Console.WriteLine("Second: " + second );
    if((last==first) & (second==four))
    {
        Console.WriteLine("Это палидром");
    }
    else
    {
        Console.WriteLine("Это НЕ палидром");
    }
}
Console.WriteLine("Число:");
int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Palindrom(a);