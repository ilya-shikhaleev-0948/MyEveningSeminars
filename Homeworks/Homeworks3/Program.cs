// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// void NamberN(int number)
// {

// for (int i = 1; i < number+1; i++)
// {

//   Console.WriteLine(i*i*i);

// }

// }

// Console.WriteLine("Введите число:");
// int i = Convert.ToInt32(Console.ReadLine());
// NamberN(i);
// Console.WriteLine();


// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// double N (double x1, double y1, double z1, double x2, double y2, double z2)
// {
// double k1 = x1 - x2;
// double k2 = y1 - y2;
// double k3 = z1 - z2;
// double g =Math.Round(Math.Sqrt(k1*k1+k2*k2+k3*k3),2);

// return g ;
// }
// Console.WriteLine("Координаты x1:");
// double x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты y1:");
// double y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты z1:");
// double z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты x2:");
// double x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты y2:");
// double y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты z2:");
// double z2 = Convert.ToInt32(Console.ReadLine());

// double result = N(x1, y1,z1, x2, y2,z2);
// Console.WriteLine(result);


// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


// static void Palindrome(int nunber)
// {
    
//     int remineder, sum = 0;
//     int temp = nunber;
    
//     while ( nunber > 0)
//     {
         
//         remineder = nunber % 10;
        
//         sum = (sum * 10) + remineder;
        
//         nunber = nunber / 10;
//     }
//     if (temp == sum)
//     {
//         Console.WriteLine($"Number {temp} is Palindrome.");
//     }
//     else
//     {
//         Console.WriteLine($"Number {temp} is not Palindrome");
//     }
//     Console.ReadKey();
// }

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// Palindrome(num);







