// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



Console.WriteLine($"Введите размер трехмерного массива:");
Console.Write("Введите X:");
int numberX = int.Parse(Console.ReadLine()); 
Console.Write("Введите Y:");
int numberY = int.Parse(Console.ReadLine()); 
Console.Write("Введите Z:");
int numberZ = int.Parse(Console.ReadLine()); 
int[,,] matrix3D = new int[numberX, numberY, numberZ];
GetMatrixIndex3D(matrix3D);
PrintMatrix(matrix3D);

/// <summary>
/// Сетод  заполняем  массив неповторяющимися  двузначными числами и  отображает  индексы элементов
/// </summary>
/// <param name="array3D">Входная  матрица</param>
void GetMatrixIndex3D(int[,,] array3D)
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }

    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
}
/// <summary>
/// Печатает матрицу, которую перадли на  вход
/// </summary>
/// <param name="array3D">Входная  матрица</param>
void PrintMatrix(int[,,] array3D)
{
    for (int k = 0; k < array3D.GetLength(2); k++)
    {
        for (int i = 0; i < array3D.GetLength(0); i++)
        {
            for (int j = 0; j < array3D.GetLength(1); j++)
            {
                Console.Write($"{array3D[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}




