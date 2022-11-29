// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int FindSum (int n, int m)
{   
    if (m > n)
    {
    int sum = 0;
    for (int i = n; i < m; i++)
    {
        sum += i;
    }
    return sum;
    }
    else
    {
    int sum = 0;
    for (int i = m; i < n; i++)
    {
        sum += i;
    }
    return sum;
    }
}

Console.WriteLine("Введите целое положительное целое число N");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое положительное целое число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма натуральных чисел в ряду M и N равна: {FindSum(n , m)}");