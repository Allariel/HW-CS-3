//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
//Применение массивов принципиально ничего не меняет, мне просто легче с ними понять код
void Dlina(double[] A, double[] B)
{
    double x = (B[0]-A[0])*(B[0]-A[0]);
    double y = (B[1]-A[1])*(B[1]-A[1]);
    double z = (B[2]-A[2])*(B[2]-A[2]);
    double result = Math.Sqrt(x+y+z);
    Console.WriteLine(String.Format("Длина отрезка: {0:0.00} ",result));
}






double[] A = new double[3];
double[] B = new double[3];
Console.WriteLine("Введите координаты точки А");
for (int i = 0; i < A.Length; i++)
{
    A[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine("Введите координаты точки Б");
for (int i = 0; i < B.Length; i++)
{
    B[i] = Convert.ToDouble(Console.ReadLine());
}
Dlina(A,B);