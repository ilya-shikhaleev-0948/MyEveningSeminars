// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {

//     int[] result = new int[size];
//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }

// void ShowArray (int[] array)
// {
// Console.WriteLine("Полученный массив ->:");
// for(int i = 0; i < array.Length; i++)
// {
// Console.Write(array[i]+" ");
// }
// Console.WriteLine();
// }

// void EvenNumbers(int[] MyArray)
// {

//     int sun = 0;
//     for (int i = 0; i < MyArray.Length; i++)
//     {
//         if (MyArray[i]%2==0) 
//         {
//             sun = sun + 1;
//         }
//     }
//     Console.WriteLine($"Чётных чисел {sun}");
// }

// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива=100");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива=999");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(lenght,min,max);

// ShowArray(newArray);
// EvenNumbers(newArray);


// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray (int size,int minValue, int maxValue)
// {
// int[] myArray = new int[size];
// for(int i=0;i<size;i++)
// {
// myArray[i] = new Random().Next(minValue,maxValue+1);
// }
// return myArray;
// }

// void ShowArray (int[] array)
// {
// Console.WriteLine("Полученный массив ->:");
// for(int i = 0; i < array.Length; i++)
// {
// Console.Write(array[i]+" ");
// }
// Console.WriteLine();
// }

// void FindMinSum (int[] array)
// {
//     int sumNegative = 0;
//     for(int i = 0; i < array.Length;i++)
//     {
//         if ((i++ % 2) == 0)
//         {
//             if(array[i] > 0) sumNegative += array[i];
//         }
//     }
//     Console.WriteLine($"Сумма элементов на нечётных позициях {sumNegative}");
// }

// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(lenght,min,max);

// ShowArray(newArray);
// FindMinSum(newArray);



// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// int size = 5;
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// int max = numbers[0];
// int min = numbers[0];

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > max)
//     {
//         max = numbers[i];
//     }
//     else if (numbers[i] < min)
//     {
//         min = numbers[i];
//     }
// }

// Console.WriteLine($"Минимальное число: {min}");
// Console.WriteLine($"Максимальное число: {max}");
// Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");

// void FillArrayRandomNumbers(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 100);
//     }
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }