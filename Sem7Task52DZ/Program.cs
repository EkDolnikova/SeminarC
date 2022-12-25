// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Метод считывает данные с консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}


// метод печатает двумерный массив
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Универсальный метод генерации и заполнение двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}

// Метод печатает одномерный массив
void Print1DArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " | ");
    }
    Console.WriteLine();
}

// Метод считает сумму элементов в двумерном массиве
double[] SumColumn (int[,] array2D)
{
    double[] arr = new double[array2D.GetLength(1)];
        for( int i=0; i<array2D.GetLength(0); i++)
        {
            for ( int j=0; j<array2D.GetLength(0); j++)
            {
                arr[j] = array2D[i,j] +arr[j] ;
            }
        }
    return arr;
}

// Метод считает среднее арифметическое в каждом столбце; 
double[] ArithmeticMean(int[,] array2D)
{
    double[] arr = SumColumn(array2D);
    for (int k = 0; k < array2D.GetLength(1); k++)
    {
        arr[k] = arr[k] / Math.Round((double)array2D.GetLength(0), 1);
    }
    return arr;
}


int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] array2D = Fill2DArray(row, column, 1, 99);
Print2DArray(array2D);
Print1DArray(ArithmeticMean(array2D));



