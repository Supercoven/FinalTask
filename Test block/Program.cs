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

Console.WriteLine("Введите положительное целое число N");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите положительное целое число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел от между M и N равна: {FindSum(n , m)}");