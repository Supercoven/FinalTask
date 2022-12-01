// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число N");
int n =  Convert.ToInt32(Console.ReadLine());

int Recursion(int n)
{
            if (n >= 1)
            {
            Console.Write($" {n} |");
            return Recursion (n - 1);
            }
            else return 1;

        
}
Console.WriteLine("Натуральные числа от N до 1: ");
Recursion(n);

