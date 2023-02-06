// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] FillMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matr = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0, 10);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void Average(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        double result = 0.0;
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            result = result + matr[j, i];
        }
        System.Console.WriteLine($"Среднее арифметическое столбца {i}: {Math.Round(result / matr.GetLength(0), 2)}");
    }
}

System.Console.WriteLine("Введите m и n: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(m, n);
System.Console.WriteLine();
PrintMatrix(matrix);
System.Console.WriteLine();
Average(matrix);

