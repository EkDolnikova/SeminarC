// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//метод считывает число с консоли
int ReadData(string line)
{
        Console.WriteLine(line);
        int number = int.Parse(Console.ReadLine() ?? "0");
       return number;
}

// метод выводит результат
void PrintData(string line) // вывод результата вычисления;
{
    Console.WriteLine(line);
}


double[] FindPoint(double b1, double k1, double b2, double k2) // вычисляем точку пересечения прямых;
{
    double[] outArray = new double[2];
    double xLine = 0;
    double yLine = 0;
    if (b1 == b2 & k1 == k2) { Console.WriteLine("Прямые совпадают"); }
    else
    {
        if (k1 == k2) { Console.WriteLine("Прямые параллельны"); }
        else { xLine = (b2 - b1) / (k1 - k2); yLine = k1 * xLine + b1; }
    }
    outArray[0] = xLine;
    outArray[1] = yLine;
    return outArray;
}

double b1 = ReadData("Введите значение b1: ");
double k1 = ReadData("Введите значение k1: ");
double b2 = ReadData("Введите значение b2: ");
double k2 = ReadData("Введите значение k2: ");

double[] result = FindPoint(b1, k1, b2, k2);
PrintData("Точка пересечения двух прямых(математ.метод): " + " (" + result[0] + " ; " + result[1] + ")");

Console.WriteLine();
// Встроенное решение
var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
x = Math.Round(x, 3);
y = Math.Round(y, 3);
Console.WriteLine($"Точка пересечения двух прямых(встроенный метод): ({x};{y})");

