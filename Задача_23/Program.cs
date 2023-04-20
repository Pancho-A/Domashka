/* 
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.Write("Ваше число = ");
int N = int.Parse(Console.ReadLine());
int count = 1;
while (count <= N){
    Console.WriteLine($"{count} в кубе = {count * count * count}");
    count++;
}