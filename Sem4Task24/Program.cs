// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А

int numberA = ReadData("Введите число А:");

DateTime d1 = DateTime.Now;
int res1 = VariantSumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = VariantSumGause(numberA);
Console.WriteLine(DateTime.Now - d2);


PrinResult("Сумма чисел от 1 до А равна(простой метод):" + res1 );
PrinResult("Сумма чисел от 1 до А равна(метод Гауса):" + res2 );

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

int VariantSumSimple(int numA)
{
    int sumOfNumbers =0;
    for(int i =1; i<=numA; i++)
    {
        sumOfNumbers += i;
    }
    return sumOfNumbers;
}

// Метод Гаусса

int VariantSumGause(int numA)
{
    int sumOfNumbers= 0;
    sumOfNumbers = ((1 + numA) * numA) / 2;
    return sumOfNumbers;
}
