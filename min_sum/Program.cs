// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = GetMatrix(3,6,0,10);
PrintMatrix(array);
Console.WriteLine();
MinSumElStr(array);

/// <summary>
/// Этот метод заполняет двумерный массив
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="cols">Количество столбцов</param>
/// <param name="min">Минимальное число для рандома</param>
/// <param name="max">Максимальное число для рандома</param>
/// <returns>Заполненный двумерный массив целых чисел</returns>
int[,] GetMatrix(int rows, int cols, int min, int max) // параметры (4)
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
/// Метод находит строку с наименьшей суммой элементов
/// </summary>
/// <param name="matrix">входящая  матрица </param>
void MinSumElStr(int[,] matrix)
{
    int minRows = 0;
    int minSumRows = 0;
    int sumRows = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minRows += matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) sumRows += matrix[i, j];
        if (sumRows < minRows)
        {
            minRows = sumRows;
            minSumRows = i;
        }
        sumRows = 0;
    }
    Console.Write($"Строка с минимальной суммой  элементов с строке: {minSumRows + 1}");
}