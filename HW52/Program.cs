// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] GetRandomMatrix(int rows, int cols)
{
    int[,] martix = new int[rows,cols];

    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++) 
        {
            martix[i,j] = random.Next(1,20);
        } 
    }

    return martix;

}

double[] GetAverageColm (int[,] matrix)
{
    int rows = matrix.GetUpperBound(0) + 1;    // количество строк
    int cols = matrix.Length / rows;        // количество столбцов

    double CountColm = 0;
    double[] AverageColm = new double[cols];

    for (int j = 0; j < cols; j++)
    {
        CountColm = 0;

        for (int i = 0; i < rows; i++) 
        {
            CountColm+=matrix[i,j];
        } 

        AverageColm[j]=CountColm/rows; //
    }

    return AverageColm;
}

void    PrintMatrix(int[,] matrix, double[] Average)
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
    Console.WriteLine ("----------------------------");
    for (int j = 0; j < cols; j++) 
        {
            Console.Write ($"{Average[j]} \t");
        } 

}

//----------------------------------------------------------------------------------------

int[,] RandomMatrix = GetRandomMatrix(4,4);

double[] AverageM = GetAverageColm(RandomMatrix);

PrintMatrix(RandomMatrix, AverageM);