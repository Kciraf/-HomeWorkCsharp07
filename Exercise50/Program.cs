// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void PrintMatrix(int[,] matrix)
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

void SearchNum(int[,] matrix)
{
    System.Console.WriteLine("Задайте координаты в матрице для поисков (строка <пробел> столбец): ");
    int[] coords = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    if(coords[0] <= matrix.GetLength(0) && coords[1] <= matrix.GetLength(1))
    {
        System.Console.WriteLine($"В строке {coords[0]} и столбце {coords[1]} находится число {matrix[coords[0]-1,coords[1]-1]}");
    }
    else System.Console.WriteLine("За пределами размера массива, числа такого нет.");
}

System.Console.WriteLine("Задайте размер матрицы (строки <пробел> столбцы): ");
int[] size = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
int[,] meArray = CreateMatrix(size[0], size[1]);
PrintMatrix(meArray);
SearchNum(meArray);

