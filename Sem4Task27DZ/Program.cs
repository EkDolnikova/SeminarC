// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// * Сделать оценку времени алгоритма через вещественные числа и строки

// Метод читает данные от пользователя:
int ReadData(string line)
{
    Console.WriteLine(line); // выводит сообщение
   int numberP = int.Parse(Console.ReadLine()??"0"); //считываем число
   return numberP; //возвращаем значение
}

// Метод выводит результат
void PrinResult(string line)
{
    Console.WriteLine(line);
}


int SumDigit(int num)
{
    int res = 0;
    while (num >0)
    {
        res += num % 10;
        num = num /10;
    }
    return res;
}

//Метод с разбитием на символы
int VariantString(int number)
{
    int sum = 0;
    char[] charArray = number.ToString().ToCharArray();
    for (int i = 0; i < charArray.Length; i++)
    {
        sum += (int)Char.GetNumericValue(charArray[i]);
    }
    return sum;
}



int number = ReadData("Введите число:");

DateTime d1 = DateTime.Now;
int sum1 = SumDigit(number);
PrinResult("Сумма цифр в числе равна(простой метод): " + sum1);
Console.WriteLine(DateTime.Now - d1);


DateTime d2 = DateTime.Now;
int sum2 = VariantString(number);
PrinResult("Сумма цифр в числе равна(string): " + sum2);
Console.WriteLine(DateTime.Now - d2);



