// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] filledMatrix = Cube(2, 2, 2, 10, 100);

/// <summary>
/// Метод генерации трехмерного массива(куба)
/// </summary>
/// <param name="x">Высота массива</param>
/// <param name="y">Ширина массива</param>
/// <param name="z">Глубина массива</param>
/// <param name="minValue">Минимальное допустимое значение для случайного числа</param>
/// <param name="maxValue">Максимальное допустимое значение для случайного числа</param>
/// <returns></returns>
int[,,] Cube(int x, int y, int z, int minValue, int maxValue)
{
    int[,,] threeDMatrix = new int[x, y, z];
    int[] uniqueNumbers = new int[x * y * z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                threeDMatrix[i, j, k] = new Random().Next(minValue, maxValue + 1);
                uniqueNumbers[k] = threeDMatrix[i, j, k];
                Console.WriteLine($"[{String.Join(", ", uniqueNumbers)}]");
            }
        }
    }
    return threeDMatrix;
}

/// <summary>
/// Метод вывода трехмерного массива в консоль
/// </summary>
/// <param name="inputMatrix">Трехмерный массив</param>
void PrintMatrix(int[,,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < inputMatrix.GetLength(2); k++)
            {
                Console.Write($"{inputMatrix[i, j, k]}({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }
    }
}

PrintMatrix(filledMatrix);