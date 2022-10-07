/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
*/
 int[,] generate2DArray(int height,int width, int randomStart, int randomEnd)
{
    int[,] twoDArray = new int[height,width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i,j] = new Random().Next(randomStart, randomEnd+1 );
        }
    }
    return twoDArray;
}
void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void print2DArray(int[,] arrayToPrint)
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
double[] avgOfColumns(int[,] twoDarray)
{
    double[] arr = new double[twoDarray.GetLength(1)];
    for (int j = 0; j < twoDarray.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < twoDarray.GetLength(0); i++)
        {
            sum += twoDarray[i,j];
        }
        arr[j] = Math.Round((double)sum/(double)twoDarray.GetLength(0), 1);
    }
    return arr;
}
void printArray(double[] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($" {array[i]};");
    }
    Console.WriteLine($" {array[array.Length -1]}.");
} 

int[,] generatedArray = generate2DArray(5,7,-100,100);
print2DArray(generatedArray);
Console.WriteLine();
double[] avgColumns = avgOfColumns(generatedArray);
printArray(avgColumns);
