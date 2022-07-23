// Задайте прямоугольный двумерный массив. 
// Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//5 2 6 7
Console.WriteLine("Введите число m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine());

int[,] matrix = InitMatrix(m, n);
Console.WriteLine($"Матрица размером {m}x{n}:");
Console.WriteLine();


int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random randomizer = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = randomizer.Next(1, 10);
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
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int MinSum(int[,] matrix, int i)
{
  int sumLine = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    sumLine += matrix[i,j];
  }
  return sumLine;
}
int minSumLine = 0;
int sumLine = MinSum(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int tempSumLine = MinSum(matrix, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"строкa с наименьшей суммой ({sumLine}) элементов ");

PrintMatrix(matrix);