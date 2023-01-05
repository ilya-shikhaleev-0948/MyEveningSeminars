//Задайте массив и поменяйте любую скроку в этом массиве

// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] ChengeRows(int[,] array,int row1, int row2)
// {
//     if (row1>= array.GetLength(0) ||row2>= array.GetLength(0))
//     return array;
//     else 
//     for(int j=0; j<array.GetLength(1); j++)
//     {
//         int temp = array[row1,j];
//         array[row1,j]=array[row2,j];
//         array[row2,j]= temp;
//     }
//     return array;
// }

// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int max = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите номер первой строки которую хотите поменять ");
// int r1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер второй строки которую хотите поменять ");
// int r2 = Convert.ToInt32(Console.ReadLine());

// int[,] myArray=Create2DRandomArray(m,n,min,max);

// Show2DArray(myArray);

// Console.WriteLine();

// ChengeRows(myArray,r1,r2);

// Show2DArray(myArray);


// Задайте двух мерный массив. Напишите программу которая
// заменяет строки на столбцы, в случае если это не возможно 
// программа должна вывести собщение для пользователя.

// Например задан массив

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//В итоге получиться:

//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7 


// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] RowsToColumns(int[,] array)
// {
//     if(array.GetLength(0) != array.GetLength(1))
//     return array;
//     else
//     {
//         for(int i = 0; i < array.GetLength(0)-1; i++)
//         {
//             for (int j = i +1; j < array.GetLength(0); j++)
//             {
//                 int temp = array[i,j];
//                 array[i,j] = array[j,i];
//                 array[j,i] = temp;
//             }

//        }
//     }
//     return array;
// }

// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(m,n,min,max);
// Show2DArray(myArray);
// myArray = RowsToColumns(myArray);
// Console.WriteLine();
// Show2DArray(myArray);


//Из двумерного массива целых чисел, заменить на 0 стоку и столбец 
//на пересечение которых расположен наименьший элимент.
//Тоесть зануляем строку и столбец в котором находиться этот элемент.

// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] MinusMin(int[,] arrey)
// {
//     int min = arrey[0,0];
//     int row = 0;
//     int column = 0;
//     for(int i = 0; i < arrey.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrey.GetLength(1); j++)
//         {
//             if(arrey[i,j]<= min) 
//             {
//                 min= arrey[i,j];
//                 row = i;
//                 column = j;
//             }
//         }
//     }
//     for(int a = 0; a < arrey.GetLength(1); a++)
//     {
//         arrey[row,a]=0;
//     }
//     for(int b = 0; b < arrey.GetLength(0); b++)
//     {
//         arrey[b,column]=0;
//     }
//     return arrey;
// }

// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(m,n,min,max);
// Show2DArray(myArray);
// myArray =MinusMin(myArray);
// Console.WriteLine();
// Show2DArray(myArray);

