/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */
Console.WriteLine("Координата X первой точки: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Координата Y первой точки: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Координата Z первой точки: ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Координата X второй точки: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Координата Y второй точки: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Координата Z второй точки: ");
int z2 = int.Parse(Console.ReadLine());

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");


// Функция ввода сообщения
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}