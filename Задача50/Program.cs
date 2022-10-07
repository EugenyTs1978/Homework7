/*Задача 50. Напишите программу, которая на вход принимает позицию элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, 
 что такого элемента нет.
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
void printValueOfPosition(int[,] twoDarray, int position)
{
    int row = twoDarray.GetLength(0);
    int column = twoDarray.GetLength(1);
    if (position < 0 || position > row * column - 1)
    {
        Console.WriteLine($"Элемента с позицией {position} нет");
    }
    else
    {
        int element = twoDarray[position / column, position % column];
        Console.WriteLine($"Элемент с позицией {position} - {element}");
    }    
}

Console.Write("Введите позицию элемента: ");
int userPosition = Convert.ToInt32(Console.ReadLine());
int[,] generatedArray = generate2DArray(3,5,-100,100);
print2DArray(generatedArray);
printValueOfPosition(generatedArray, userPosition);