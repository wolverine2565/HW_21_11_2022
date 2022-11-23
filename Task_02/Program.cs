//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите число A");
string a = Console.ReadLine();
int A = int.Parse(a);

Console.WriteLine("Введите число B");
string b = Console.ReadLine();
int B = int.Parse(b);

Console.WriteLine("Введите число C");
string c = Console.ReadLine();
int C = int.Parse(c);

int max = A;
if(max<B)
{
    max = B;
}
if(max<C)
{
    max = C;
}

Console.Write($"Максимальное число {max} "); 