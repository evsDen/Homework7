// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// void InputMatrix(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = Math.Round(new Random().NextDouble() * 10, 3);
//             Console.Write($"{matrix[i, j]} \t");
//         }
//     Console.WriteLine();
//     }
// }


// Console.Clear();
// Console.Write("Введите кол-во строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int m = Convert.ToInt32(Console.ReadLine());
// double[,] matrix = new double[n, m];
// InputMatrix(matrix);

// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(-10, 11);
//             Console.Write($"{matrix[i, j]} \t");
//         }
//     Console.WriteLine();
//     }
// }
// Console.Clear();
// int[,] matrix = new int[4, 4];
// InputMatrix(matrix);
// Console.WriteLine("Введите № строки: ");
//  int m = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите № столбца: ");
//  int n = Convert.ToInt32(Console.ReadLine());
// void FindIndexMatrix(int[,] matrix)
// {
//     if (m >= 0 && m < matrix.GetLength(0) && n >= 0 && n < matrix.GetLength(1))
//     {
//         Console.WriteLine(matrix[m-1, n-1]);
//     }
//     else
//     {
//         Console.WriteLine("Такого числа в массиве нет");
//     }
// }
// FindIndexMatrix(matrix);

// //Задача 52.  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(1, 10);
//     }
// }


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} \t");
//     Console.WriteLine();
//     }
// }

//     void AvgMatrix(int[,] matrix)
// {
//     double avg = 0;
//     double summa = 0;

//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             summa += matrix[i, j];
//         }
//         avg = summa / matrix.GetLength(0);
//         Console.Write($"{avg} \t");
//         summa = 0;
//     }
// }

// Console.Clear();
// Console.Write("Введите кол-во строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[n, m];
// InputMatrix(matrix);
// Console.WriteLine("Начальный массив: ");
// PrintMatrix(matrix);
// Console.WriteLine("Среднее арифметическое столбцов: ");
// AvgMatrix(matrix);

