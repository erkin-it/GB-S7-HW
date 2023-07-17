// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

string InputTxt (string TxtSrting) // Модуль приглашения для ввода данных в виде текста с клавиатуры
{
    Console.Write (TxtSrting);
    return Console.ReadLine();
}

double [,] GetRandomMatrix(int rows, int cols)
{
    double[,] martix = new double[rows,cols];

    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++) 
        {
            martix[i,j] = Math.Round(-10 + (20 * random.NextDouble()), 2);
        } 
    }

    return martix;

}

void    PrintMatrix(double[,] matrix)
{
    int rows = matrix.GetUpperBound(0) + 1;    // количество строк
    int cols = matrix.Length / rows;        // количество столбцов

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++) 
        {
            Console.Write ($"{matrix[i,j]} \t");
        } 
        Console.WriteLine ("");
    }
}

//----------------------------------------------------------------------------------------

int MatrixRows = int.Parse(InputTxt("Введите колличество строк в массиве: "));

int MatrixColms = int.Parse(InputTxt("Введите колличество столбцов в массиве: "));

double[,] RandomMatrix = GetRandomMatrix(MatrixRows,MatrixColms);

PrintMatrix(RandomMatrix);
