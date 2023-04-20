/* Задача 19 
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);
int res, sum = 0, t;
if(num > 9999 && num < 100000)
{
for(t = num; num!=0;num = num/10)
{
res = num % 10;
sum = sum*10+res;
}
if(t == sum)
Console.Write($"{t} является палиндромом");
else
Console.Write($"{t} не является палиндромом");
} else
Console.Write("Число не корректное!");