// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int num = ReadData("Введите пятизначный палиндром: ");

bool result = PolinTest(num);

Console.WriteLine(result);
//PrintData(result);

// Метод читает данные от пользователя:
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

// Метод выводит данные пользователю
//void PrintData(string msg, string result)
//{
//    Console.WriteLine(msg + result);
//}

bool PolinTest(int num)
{
    bool result = false;
    result = (((num/10000== num%10))&&((num/1000)%10 == (num/10) %10));
    return result;
}

