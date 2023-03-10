
int[,] filledMatrix = SpiralMatrix(4, 4);

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

