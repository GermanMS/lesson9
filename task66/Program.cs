// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Введите число m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n = ");
int n = Convert.ToInt32(Console.ReadLine());
//         n      m
int st(int x, int y)
{
    if (y < x)
    {
        if (x == y )
        {
            return y;
        }
     //    st( x - 1, y);
     return x + st(x - 1,y);
        Console.Write($"{x} ");
    }
    else if (y > x)
    {
        if (y == x )
        {
          return x;
        }
     //    Console.Write($"{y} ");
     //    st(x, y-1);
     return y + st(x,y - 1);
     Console.Write($"{y} ");
    }
    else
    {    return y;
        Console.Write($"{y} ");
    }
}
// st(n, m);
int summa = st(n,m);
Console.Write(summa);
// // Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// // M = 1; N = 5 -> "1, 2, 3, 4, 5"
// // M = 4; N = 8 -> "4, 5, 6, 7, 8"
// Console.Write("Введите значение N - ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение M - ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Натуральные числа от {n} до {m} - ");
// //         n      m
// void z(int x, int y)
// {  3     5
//     if (y < x)
//     {5     2
//         if (x == y - 1)
//         {
//             return;
//         }
//         z(x - 1, y);
//         Console.Write($"{x} ");
//     }
//     else if (y > x)
//     {
//         if (y == x - 1)
//         {
//             return;
//         }
//         Console.Write($"{y} ");
//         z(x, y-1);
//     }
//     else
//     {
//         Console.Write($"{y} ");
//     }
// }
// z(n, m);