// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Заполняем массив случайными числами
void Fill2DArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    Console.WriteLine();
        for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
        }
    Console.WriteLine();
}

// Метод нахождения суммы элементов в строке;
int SumRows(int[,] arr, int i)
{
    int Sum = arr[i, 0];
    for (int j = 1; j < arr.GetLength(1); j++)
    {
        Sum += arr[i, j];
    }
    return Sum;
}


// Метод поиска строки с наименьшей суммой элементов;
int FindMinRow(int[,] arr)
{
    int minSumRow = 0;
    int Sum = SumRows(arr, 0);
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        int bufSum = SumRows(arr, i);
        if (Sum > bufSum)
        {
            Sum = bufSum;
            minSumRow = i;
        }
    }
    return minSumRow + 1;
}

// Печать результата;
void PrintResult(string prefix, string data)
{
    Console.WriteLine(prefix + data);
}

int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = new int[m, n];


int[,] array2D = new int[m, n];
Fill2DArray(array2D, 1, 10);
Print2DArray(array2D);
int result = FindMinRow(array2D);
PrintResult("Строка с наименьшей суммой: ", "№ " + result + " сверху вниз");