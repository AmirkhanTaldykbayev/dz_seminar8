// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] filledMatrix = GetMatrix(4, 4, 1, 10);

/// <summary>
/// Метод генерации двумерного массива(матрицы) с рандомными числами
/// </summary>
/// <param name="rows">Количество строчек</param>
/// <param name="cols">Количество столбцов</param>
/// <param name="minValue">Минимальное значение случайного числа</param>
/// <param name="maxValue">Максимальное значение случайного числа</param>
/// <returns>Сгенерированный двумерный массив</returns>
int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}


/// <summary>
/// Метод вывода двумерного массива(матрицы) в консоль
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

Console.WriteLine("Заполненная матрица: ");
PrintMatrix(filledMatrix);
Console.WriteLine("------------------------------------------------");


/// <summary>
/// Метод для нахождения строки с наименьшей суммой элементов
/// </summary>
/// <param name="matr">Двумерный массив</param>
void MinimalSumOfElem(int[,] matr)
{
    int indexOfRow = 0;
    int temp = 0;
    int minimalSum = 0;
    for (int m = 0; m < matr.GetLength(1); m++) // Зададим первую строку как строку с наименьшей суммой элементов
    {
        minimalSum += matr[0, m];
    }
    for (int i = 0; i < matr.GetLength(0); i++) // Теперь пройдемся по всем строкам в поисках строки с мин суммой элементов
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            temp += matr[i, j];
        }
        if (temp < minimalSum)
        {
            minimalSum = temp;
            indexOfRow = i;
        }
        Console.WriteLine($"Строка {i} содержит в себе сумму элементов: {temp}");
        temp = 0;
    }
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine($"Строка с наименьшей суммой элементов: {indexOfRow} ({minimalSum})");
    Console.WriteLine("------------------------------------------------");

}

MinimalSumOfElem(filledMatrix);
