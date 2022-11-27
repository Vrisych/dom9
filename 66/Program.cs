// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();
Console.WriteLine("Программа создает случайные числа M и N и находит сумму натуральных элементов в промежутке от M до N");
int N = new Random ().Next (1,10);
int M = new Random ().Next (1,10);
Console.WriteLine($"N = {N}.");
Console.WriteLine($"M = {M}.");
void Check(int n, int m)
{
    if (n>m) Console.WriteLine($"Сумма чисел равна {Sum(m, n)}");
    else if(m>n) Console.WriteLine($"Сумма чисел равна {Sum(n, m)}");
    else Console.WriteLine("Числа равны.");
}
int Sum (int m, int n)
{
    if (m==n) return  n;
    else return m + Sum(m+1, n);
}
Console.WriteLine("");
Check(N, M);