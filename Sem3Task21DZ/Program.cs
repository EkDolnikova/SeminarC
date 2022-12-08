// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int x1 = ReadData("Введите координату x1: ");
int y1 = ReadData("Введите координату y1: ");
int x2 = ReadData("Введите координату x2: ");
int y2 = ReadData("Введите координату y2: ");
int x3 = ReadData("Введите координату x3: ");
int y3 = ReadData("Введите координату y3: ");

double result = DiatanceBetweenPoints(x1, y1, x2, y2, x3, y3);
PrintData("Расстояние между точками: ", result);

// Метод читает данные от пользователя:
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

// Метод находит расстояние между точками на плоскости
double DiatanceBetweenPoints(double x1, double y1, double x2, double y2, double x3, double y3)
{
    double distance = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(Math.Pow(x3 - y3, 2)));
    return distance;
}

// Метод выводит данные пользователю
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

