// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/*
double[,] FillArrayWitnRandomNumbers(int row, int column)
{
    double[,] array = new double[row,column];
    Random rnd = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for(int j = 0; j < array.GetLength(1); j++)
       {
        array[i,j] = Math.Round(rnd.Next(-10,10)+ rnd.NextDouble(),2);
       }
    }
    return array;
}

void PrintMatrix(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for(int j = 0; j < array.GetLength(1); j++)
       {
        Console.Write($"{array[i,j]}  \t");
       }
    Console.WriteLine();
    }
}

Console.WriteLine("Input the number of rows:  ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number of columns:  ");
int column = Convert.ToInt32(Console.ReadLine());
double[,] matrix = FillArrayWitnRandomNumbers(row, column);
PrintMatrix(matrix);



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int[,] FillArrayWitnRandomNumbers(int row, int column)
{
    int[,] array = new int[row,column];
    Random rnd = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for(int j = 0; j < array.GetLength(1); j++)
       {
        array[i,j] = rnd.Next(-10,10);
       }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for(int j = 0; j < array.GetLength(1); j++)
       {
        Console.Write($"{array[i,j]}  \t");
       }
    Console.WriteLine();
    }
}

void SearchValue(int[,] array, int row, int column)
{
Console.WriteLine("Input the position of the element we are looking for. The row-position in the matrix is:  ");
int lookingRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the position of the element we are looking for. The column-position in the matrix is:  ");
int lookingColumn = Convert.ToInt32(Console.ReadLine()); 
if(lookingRow > row - 1  || lookingColumn > column - 1)
    Console.WriteLine("There is no element with the specified position in the matrix.");
else
    Console.WriteLine("The value of the desired element is: " + array[lookingRow,lookingColumn]);   
}

Console.WriteLine("Input the number of rows in matrix:  ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number of columns in matrix:  ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillArrayWitnRandomNumbers(row, column);
PrintMatrix(matrix);
SearchValue(matrix, row, column);





// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int[,] FillArrayWitnRandomNumbers(int row, int column)
{
    int[,] array = new int[row,column];
    Random rnd = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for(int j = 0; j < array.GetLength(1); j++)
       {
        array[i,j] = rnd.Next(-10,10);
       }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for(int j = 0; j < array.GetLength(1); j++)
       {
        Console.Write($"{array[i,j]}  \t");
       }
    Console.WriteLine();
    }
}

void ArithmeticMean(int[,] array)
{
  for(int j = 0; j < array.GetLength(1); j++)
  {
    double sum = 0;
    double arMean = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
       sum += array[i,j];
    }
    arMean = Math.Round(sum / array.GetLength(0),2);
    Console.WriteLine($"The arithmetic mean of the elements in the column {j+1} is {arMean}");
  }
}

Console.WriteLine("Input the number of rows:  ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number of columns:  ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillArrayWitnRandomNumbers(row, column);
PrintMatrix(matrix);
ArithmeticMean(matrix);

*/