// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

string InputTxt (string TxtSrting) // Модуль приглашения для ввода данных в виде текста с клавиатуры
{
    Console.Write (TxtSrting);
    return Console.ReadLine();
}

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

void    PrintMatrix(int[,] matrix, int SearchRow, int SearchColm)
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

    if (rows < SearchRow || cols < SearchColm)
    {
        Console.WriteLine ($"Число с индексом [{SearchRow},{SearchColm}] в массиве нет");
    }
    else
    {
        Console.WriteLine ($"Число с индексом [{SearchRow},{SearchColm}] в массиве равен {matrix[SearchRow-1,SearchColm-1]}");
    }


}

//----------------------------------------------------------------------------------------

int[,] RandomMatrix = GetRandomMatrix(4,4);

int MatrixRow = int.Parse(InputTxt("Введите нномер строки в массиве: "));

int MatrixColm = int.Parse(InputTxt("Введите номер столбца в массиве: "));

PrintMatrix(RandomMatrix,MatrixRow,MatrixColm);