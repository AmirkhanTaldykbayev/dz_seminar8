// ДОПОЛНИТЕЛЬНАЯ ЗАДАЧКА
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] filledMatrix = SpiralMatrix(4, 4);

/// <summary>
/// Метод генерация двумерного массива(матрицы) с заполнением чисел по спирали
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="cols">Количество столбцов</param>
/// <returns></returns>
int[,] SpiralMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    int row = 0;
    int col = 0;
    int dirX = 1;
    int dirY = 0;
    int dirChange = 0;
    int flag = cols;
    for (int i = 0; i < matrix.Length; i++)
    {
        matrix[row, col] = i + 1;
        if (--flag == 0)
        {
            flag = rows * (dirChange % 2) + cols * ((dirChange + 1) % 2) - (dirChange / 2 - 1) - 2;
            int temp = dirX;
            dirX = -dirY;
            dirY = temp;
            dirChange++;
        }
        col += dirX;
        row += dirY;
    }

    return matrix;
}

/// <summary>
/// Метод вывода двумерного массива в консоль
/// </summary>
/// <param name="inputMatrix">Двумерный массив</param>
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

PrintMatrix(filledMatrix);

