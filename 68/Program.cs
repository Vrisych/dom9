// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Clear();
Console.WriteLine("Программа вычисляет функцию Аккермана для введеных чисел. Введите m и n через enter");
double OriginalM = double.Parse(Console.ReadLine());
double OriginalN = double.Parse(Console.ReadLine());
double Akkerman (double m, double n)
{
    if (m == 0) return n+1;
    else if(m>0 && n==0) return Akkerman(m-1, 1);
    else return Akkerman(m-1, Akkerman(m, n-1));
}

void CheckAndStart (double m, double n)
{
    if (m<4 || (m ==4 && n==0)) Console.WriteLine ($"Функция Аккермана равна {Akkerman(OriginalM, OriginalN)}");
    else Console.WriteLine("Такой просчет будет очень долгим и в конце выдаст ошибку.");
}
CheckAndStart(OriginalM, OriginalN);