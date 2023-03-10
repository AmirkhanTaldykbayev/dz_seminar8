// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] filledMatrix = GetMatrix(4, 4, 1, 10);
PrintMatrix(filledMatrix);

/// <summary>
/// Метод для создания двумерного массива(матрицы)
/// </summary>
/// <param name="rows">Количество строчек</param>
/// <param name="cols">Количество столбцов</param>
/// <param name="minValue">Минимальное допустимое значение в матрице</param>
/// <param name="maxValue">Максимальное допустимое значение в матрице</param>
/// <returns>Заполненный двумерный массив целых чисел</returns>
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
/// Метод для вывода в консоль матрицы
/// </summary>
/// <param name="inputMatrix">Матрица(двумерный массив)</param>
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

// Теперь есть готовая матрица для перехода к решению задачи. Будем использовать метод VOID, так как нет нужды
// создавать новый массив.

/// <summary>
/// Метод для сортировки строк в матрице по убыванию
/// </summary>
/// <param name="nonFilteredMatrix">Неотсортированная матрица</param>
void DecreasingRows(int[,] nonFilteredMatrix) //Decreasing - убывающий (прим. перевод); Пардон за длинное название параметра
{
    for (int k = 0; k < nonFilteredMatrix.GetLength(0); k++)
    {
        for (int i = 0; i < nonFilteredMatrix.GetLength(1); i++)
        {
            for (int j = i + 1; j < nonFilteredMatrix.GetLength(1); j++) // Переменная "j" добавлена для проверки текущего элемента со следующим
            {
                if (nonFilteredMatrix[k, i] < nonFilteredMatrix[k, j])
                {
                    int max = nonFilteredMatrix[k, i];
                    nonFilteredMatrix[k, i] = nonFilteredMatrix[k, j];
                    nonFilteredMatrix[k, j] = max;
                }
            }
        }
    }
}

Console.WriteLine("Результат: ");
DecreasingRows(filledMatrix);
PrintMatrix(filledMatrix);