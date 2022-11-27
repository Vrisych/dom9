// Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1.
Console.Clear();
Console.WriteLine("Программа создает случайное число от N и выводит все четные числа от N до 1");
int N = new Random ().Next (4,100);
Console.Write($"N = {N}.");
void CheckN(int n)
{
    if (n%2 ==0) PrintNTo1(n);
    else 
    {
        n=n-1;
        PrintNTo1(n);
    }
}
void PrintNTo1 (int n)
{
    if (n>2) 
    {
        Console.Write($"{n}, ");
        n=n-2;
        PrintNTo1(n);
    }
    else Console.Write($"{n}.");
}
Console.WriteLine("");
CheckN(N);