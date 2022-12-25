// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.

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

// Метод поиска элемента в двумерном массиве;
int SearchElement(int x, int y, int[,] array2D)
{
    if (x < array2D.GetLength(0) && y < array2D.GetLength(1))
    { return array2D[x, y]; }
    else { return -1; }
}


void PrintData(string prefix, int data) //разбили на две части вывод в консоль
{
    if (data == -1) { Console.WriteLine("Такого элемента в массиве нет!"); }
    else { Console.WriteLine("Элемент в заданной позиции: " + data); } //сначала выводим prefix + а потом данные data;
}

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] array2D = Fill2DArray(row, column, 1, 99);
Print2DArray(array2D);

int y = ReadData("Введите позицию элемента в массиве по горизонтали: ");
int x = ReadData("Введите позицию элемента в массиве по вертикали: ");
PrintData("", SearchElement(x, y, array2D));

