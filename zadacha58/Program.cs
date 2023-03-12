// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] firstMatrix = GetMatrix(2, 2);
// int[,] secondMatrix = GetMatrix(2, 2);
int[,] firstMatrix = new int[2, 2];
firstMatrix[0, 0] = 2;
firstMatrix[0, 1] = 4;
firstMatrix[1, 0] = 3;
firstMatrix[1, 1] = 2;
int[,] secondMatrix = new int[2, 2];
secondMatrix[0, 0] = 3;
secondMatrix[0, 1] = 4;
secondMatrix[1, 0] = 3;
secondMatrix[1, 1] = 3;

/// <summary>
/// Метод генерирования двумерного массива(матрицы)
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="cols">Количество столбцов</param>
/// <returns>Заполненный двумерный массив</returns>
int[,] GetMatrix(int rows, int cols)
{
    int[,] result = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            result[i, j] = new Random().Next(1, 11);
        }
    }
    return result;
}

/// <summary>
/// Метод вывода двумерного массива в консоль
/// </summary>
/// <param name="inputMatrix">Входящий в метод двумерный массив</param>
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write($"{inputMatrix[i, j]} ({i} {j}) \t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("----------Первая-матрица----------");
PrintMatrix(firstMatrix);
Console.WriteLine("----------Вторая-матрица----------");
PrintMatrix(secondMatrix);
Console.WriteLine("----------------------------------");



/// <summary>
/// Метод для нахождения произведения двух матриц
/// </summary>
/// <param name="matrix1">Первый двумерный массив(матрица)</param>
/// <param name="matrix2">Второй двумерный массив(матрица)</param>
/// <returns>Возвращаемый результат произведения</returns>
int[,] GetProduct(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(1); k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }

    }
    return result;
}


if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
{
    int[,] matrixProduct = GetProduct(firstMatrix, secondMatrix);
    Console.WriteLine("Произведение двух матриц:");
    PrintMatrix(matrixProduct);
}
else
{
    Console.WriteLine($"Произведение матриц невозмножно, так как колчество столбцов первой матрицы не совпадает с количеством строк второй матрицы");
}