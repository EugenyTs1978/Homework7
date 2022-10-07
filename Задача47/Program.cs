/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/
double[,] CreateMatrix(int row, int column, double randomStart, double randomEnd)
{
    double[,] matrix = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i,j] = Math.Round((new Random().NextDouble()) * (randomEnd - randomStart)
                                     + randomStart, 1); 
        }
    }
    return matrix;
}
void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void print2DArray(double[,] arrayToPrint)
{
    Console.Write(" \t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i+"\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i+"\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
double[,] generatedArray = CreateMatrix(5,5,-10,10);
print2DArray(generatedArray);
