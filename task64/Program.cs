// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Write("Введите число n = ");
int n = Convert.ToInt32(Console.ReadLine());
void st(int n)
{
if  (n == 0) return;
else{
     Console.Write(n+ " ");
     st(n-1);
     }
} 
st(n);
// Console.WriteLine (st(n));
// Console.Write(n+ " ");
//  Console.WriteLine (st(n));
// for (int i = 1; i < n; i++)
// {
// Console.WriteLine (st(n));
// }
// 5=4+1
//   4=3+1
//     3=2+1
//       2=1+1
      //   1=0+1
      // Сделай метод, в него передавай два параметра. В нем проверка если б равно 1 ретёрн а.
      //  Если нет ретёрн а *на имя-функции с аргументами а, б-1
// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
// Console.WriteLine("Введите число A");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B");
// int B = Convert.ToInt32(Console.ReadLine());
// int st(int a, int b)
// {
//     if (b == 1)
//     {
//         return a;
//     }
//     return a * st(a, b-1);
// }
// Console.WriteLine (st(A, B));
