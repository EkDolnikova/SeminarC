//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// * Написать калькулятор с операциями +, -, /, * и возведение в степень(pow)

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

int Pow(int num1, int num2)
{
    int res = 1;
    for (int i=1; i<=num2;i++)
    {
        res = res * num1;
    }
    return res;
}


// Калькулятор




int number1 = ReadData("Введите число А:");
int number2 = ReadData("Введите число B:");


int res = Pow(number1, number2);
PrinResult("A в степени B равно: " + res);




