// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Обратите внимание! Количество столбцов 1 массива должно бать  равно  количеству строк 2 массива!");

Console.Write("Введите количество строк 1 массива: ");
int rowsFirst = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 1 массива: ");
int columnsFirst = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк 2 массива: ");
int rowsSecond = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 2 массива: ");
int columnsSecond = int.Parse(Console.ReadLine());

if (columnsFirst != rowsSecond)
{
    Console.WriteLine("Такие матрицы умножить невозможно!");
    return;
}

int[,] firstArray = GetMatrix(rowsFirst, columnsFirst, 0, 10);
Console.WriteLine($"Первая матрица:");
PrintMatrix(firstArray);
Console.WriteLine();

int[,] secondArray = GetMatrix(rowsSecond, columnsSecond, 0, 10);
Console.WriteLine($"Вторая матрица:");
PrintMatrix(secondArray);
Console.WriteLine();


Console.WriteLine("Результирующая матрица:");
PrintMatrix(MultiplicationMatrix(firstArray,secondArray));


/// <summary>
/// Этот метод заполняет двумерный массив
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="cols">Количество столбцов</param>
/// <param name="min">Минимальное число для рандома</param>
/// <param name="max">Максимальное число для рандома</param>
/// <returns>Заполненный двумерный массив целых чисел</returns>
int[,] GetMatrix(int rows, int cols, int min, int max)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

/// <summary>
/// Метод печатает матрицу, которую передали на вход
/// </summary>
/// <param name="inputMatrix"> Двумерный массив или таблица </param>
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

/// <summary>
/// Метод произведения  первой  матрицы  на втору
/// </summary>
/// <param name="arrayA">Первая матрица</param>
/// <param name="arrayB">Вторая матрица</param>
/// <returns>Результат произведения двух матриц</returns>
   int [,] MultiplicationMatrix(int[,] arrayA, int[,] arrayB)
    {
      int[,] resulArray = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
      for (int i = 0; i < arrayA.GetLength(0); i++)
      {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
          for (int k = 0; k < arrayA.GetLength(1); k++)
          {
            resulArray[i, j] += arrayA[i, k] * arrayB[k, j];
          }
        }
      }
      return resulArray;
    }