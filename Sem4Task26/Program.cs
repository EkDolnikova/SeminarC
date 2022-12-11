// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

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

// Простой метод
int VariantSimple(int num)
{
    int res = 0;
    while(num >0)
    {
        res++;
        num = num / 10;
    }
    return res;
}

//Метод с логарифмом
int VariantLog(int num)
{
    int count = (int)Math.Log10(num)+1;
    return count;
}

//Метод со строкой
int VarianString(int num)
{
    int count = num.ToString().Length;
    return count;
}

int number = ReadData("Введите число А:");
int length = VariantLog(number);
int length2 = VariantSimple(number);
int length3 = VarianString(number);

PrinResult("Количество цифр в числе равно(метод с логарифмом): " + length);
PrinResult("Количество цифр в числе равно(метод простой): " + length2);
PrinResult("Количество цифр в числе равно(метод со строкой): " + length3);
