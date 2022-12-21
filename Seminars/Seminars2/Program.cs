// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// 78 -> 8

// 12-> 2

// 85 -> 8

// int MaxNamber (int num)
// {
//     int a = num / 10;
//     int b = num % 10;
//     if (a > b)
//     {
//         return a;
//     }
//     else
//     {
//         return b;
//     }
// }

// int randomNumber = new Random().Next(10, 99+1);
// Console.WriteLine(randomNumber);
// int result = MaxNamber(randomNumber); 
// Console.WriteLine(result);

// int DeleteNumber (int num)
// {
//     int sot = num / 100;
//     int ed = num % 10;
//     return sot*10 + ed;
// }
// int randomNumber = new Random().Next(100, 1000);
// Console.WriteLine(randomNumber);
// int result = DeleteNumber(randomNumber); 
// Console.WriteLine(result);

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// void kratnost(int num1, int num2)
// {

//     if (num1 % num2 == 0)
//     {
//         Console.WriteLine($"{num1}, {num2} -> кратно");
//     }

//         else
//         Console.WriteLine($"{num1}, {num2} -> не кратно, остаток {num1 % num2}");    


// }

// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// kratnost(num1, num2);


// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

// bool kratnost(int num)
// {
//     if (num % 7 == 0 && num % 23 == 0)
//     {
//         return true;
//     }
//     else
//         return false;
// }
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// bool result = kratnost(num);
// Console.WriteLine(result);
















