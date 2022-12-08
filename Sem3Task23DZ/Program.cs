// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int number = ReadData("Введите число: "); // считывает число

string outLine = LineBilder(number, 1);// конструирует первую строку
PrintData("", outLine);

outLine = LineBilder(number, 3); // конструтрует вторую строку
PrintData("", outLine);

// Метод читает данные от пользователя:
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
// Метод выводит данные пользователю
void PrintData(string msg, string result)
{
    Console.WriteLine(msg + result);
}
//Метод сборки строки
string LineBilder(int numN, int pow)
{
    string outLine = string.Empty;
    for (int i=1; i<numN; i++)
    {
        outLine = outLine + Math.Pow(i, pow) + ", ";
    }
    outLine = outLine + Math.Pow (numN, pow);
    return outLine;
}
