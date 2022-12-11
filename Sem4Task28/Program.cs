// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. (Вычислить факториал)

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

long CalcFactor(int num)
{
    long count = 1;
    for(int i=1;i<= num;i++)
    {
        count *= i;
    }
    return count;
}



int number = ReadData("Введите число А:");
long length = CalcFactor(number);
PrinResult("Факториал равен: " + length);

