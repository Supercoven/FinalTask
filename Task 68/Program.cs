// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число M для функции Аккермана");
int m =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N для функции Аккермана");
int n =  Convert.ToInt32(Console.ReadLine());

int Ackermann(int m, int n)
{
  int result = 1;
  if (m == 0 & n >= 0)
  return (n + 1);
  else if (n == 0 & m >= 0) 
  return result = Ackermann (m - 1,1);
  else return result = Ackermann(m - 1, Ackermann(m, n - 1));
}

Console.WriteLine(Ackermann(m,n));

