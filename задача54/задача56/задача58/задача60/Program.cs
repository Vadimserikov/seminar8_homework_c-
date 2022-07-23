// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)

Console.WriteLine("Введите первое число для трехмерного массива");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число для трехмерного массива");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число для трехмерного массива");
int z = int.Parse(Console.ReadLine());

int [,,] matrix = new int[x, y, z];

void InitMatrix(int[,,] matrix)
{
  int[] temp = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < matrix.GetLength(0); x++)
  {
    for (int y = 0; y < matrix.GetLength(1); y++)
    {
      for (int z = 0; z < matrix.GetLength(2); z++)
      {
        matrix[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
void PrintMatrix (int[,,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < matrix.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={matrix[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}
InitMatrix(matrix);
PrintMatrix(matrix);
