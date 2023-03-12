// Задайте двумерный массив. 
//Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

int[,] GenerateArray(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }
    System.Console.WriteLine();
}

void OrderedArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int x = 0; x < array.GetLength(1) - 1; x++)
            {
                if (array[i, x] < array[i, x + 1])
                {
                    int temp = array[i, x];
                    array[i, x] = array[i, x + 1];
                    array[i, x + 1] = temp;
                }
            }
        }
    }
}

int[,] matrix = GenerateArray(3, 3);
PrintArray(matrix);
Console.WriteLine("Массив, упорядоченный по убыванию чисел в строках: ");
OrderedArray(matrix);
PrintArray(matrix);



