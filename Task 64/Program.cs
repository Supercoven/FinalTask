// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число N");
int n =  Convert.ToInt32(Console.ReadLine());


int Recursion(int n)
{
            if (n == 1) return 1;
            else return Recursion (n - 1) * n;
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(Recursion(n));
}
