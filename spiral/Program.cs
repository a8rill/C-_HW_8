﻿//  ДОПОЛНИТЕЛЬНАЯ ЗАДАЧКА
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



Console.WriteLine("Введите размерность крадратной матрицы:");
int size = int.Parse(Console.ReadLine());
int[,] matrix = new int[size, size];
int i = 0, j = 0, temp = 1;
while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
{
    matrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= matrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > matrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

PrintMatrix(matrix);
/// <summary>
/// Печатает матрицу, которую перадли на  вход
/// </summary>
/// <param name="array">Входная  матрица</param>
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($"0{array[i, j]} ");
            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
