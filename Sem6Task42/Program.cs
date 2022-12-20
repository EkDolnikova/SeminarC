// Напишите программу, которая будет преобразовывать десятичные числа в двоичные.

int inputNumber = ReadData("Enter number: ");

PrintData("Result: " + DegToBin(inputNumber));
PrintData("Result: " + DecToBinNativ(inputNumber));
PrintData("Result: " + Convert.ToString(inputNumber, 8));  // конвертация в 8-ричную систему
PrintData("Result: " + Convert.ToString(inputNumber, 16)); // конвертация в 16-ричную систему

// Считывает с пользователя число
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод речатает результат
void PrintData(string res)
{
    Console.WriteLine(res);
}

// Метод конвертирует число из десятичной системы в двоичную
string DegToBin(int num)
{
    string outBin = String.Empty;
    while (num > 0)
    {
        outBin = (num % 2) + outBin;
        num = num / 2;
    }
    return outBin;
}

// Встроенный метод перевода числа из десятичной системы в двоичную
string DecToBinNativ(int num)
{
    return Convert.ToString(num, 2);
}
