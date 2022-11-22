//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


Console.WriteLine("Введите число A");
string a = Console.ReadLine();
int A = int.Parse(a);

Console.WriteLine("Введите число B");
string b = Console.ReadLine();
int B = int.Parse(b);

if (A > B)
{
Console.Write($"Максимальное число {A} ");  
}
if (A < B)
{
Console.Write($"Максимальное число {B} ");  
}
if (A == B)
{
Console.WriteLine("Оба числа равны"); 
}