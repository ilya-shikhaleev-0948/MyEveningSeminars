// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// double FindDegree( double a,int  b)
// {
//     if (b < 0) {(a, b) = (1.0 / a, -b);}
//     {

//         double degree = 1.0;
//         for (; b != 0; a *= a, b /= 2)
//         {
//             if (b % 2 != 0) { degree *= a; }
//         }
//         return degree;
//     }
// }
// Console.WriteLine("Input A:");
// double a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input B:");
// int b = Convert.ToInt32(Console.ReadLine());
// double result = FindDegree(a,b);
// Console.WriteLine(result);


// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// int getSum(int n)
// {
//     int sum = 0;
//     while (n != 0)
//     {
//         sum = sum + n % 10;
//         n = n / 10;
//     }
//     return sum;
// }

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int result = getSum(n); 
// Console.WriteLine(result);