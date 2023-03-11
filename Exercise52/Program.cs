// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix2D(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void PrintMatrix1D(double[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        System.Console.Write(matrix[i] + "\t");
    }
}

void AvrOfRow(int[,] matr)
{
    double[] avarage = new double[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            avarage[j] += matr[i,j];
        }
        avarage[j] = Math.Round(avarage[j] / matr.GetLength(0), 2);
    }
    
    System.Console.Write("Среднее в каждом столбце: ");
    PrintMatrix1D(avarage);
}

System.Console.WriteLine("Задайте размер матрицы (строки <пробел> столбцы): ");
int[] size = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
int[,] myArray = CreateMatrix(size[0], size[1]);
PrintMatrix2D(myArray);
System.Console.WriteLine();
AvrOfRow(myArray);