// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Cube(int N)
{
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine(Math.Pow(i,3));
    }
}

Console.WriteLine("N");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Cube(N);

