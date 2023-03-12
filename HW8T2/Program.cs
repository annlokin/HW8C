// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int InputUser(string message)
{
    System.Console.Write($"{message} = ");
    return Convert.ToInt32(Console.ReadLine());
}

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

int SumLine(int[,] array, int i)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
}

int minSumLine(int[,] array)
{
    int minSum = 0;
    int sum = SumLine(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSum = SumLine(array, i);
        if (sum > tempSum)
        {
            sum = tempSum;
            minSum = i + 1;
        }
    }
    return minSum;
}

int userRow = InputUser("Введите количество строк");
int userColumn = InputUser("Введите количество столбцов");
int[,] matrix = GenerateArray(userRow, userColumn);
PrintArray(matrix);
Console.WriteLine(($"Строка с наименьшей суммой элементов: {minSumLine(matrix)} "));