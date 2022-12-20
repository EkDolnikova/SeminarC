// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// * Пользователь вводит число нажатий. Программа следит за нажатиями, затем выдает, сколько чисел больше 0 было введено

int M = ReadData("Введите M суммарное количество чисел: ");
PrintData(CountPosNum(M));


// Метод считывает число с консоли
int ReadData(string line)
{
        Console.WriteLine(line);
        int number = int.Parse(Console.ReadLine() ?? "0");
        return number;
}

// Метод выводит результат
void PrintData(int number)
{
    Console.WriteLine("Количество введённых чисел больше 0: " + number);
}

// Метод подсччета кол-ва чисел введенных больше 0
int CountPosNum(int M) 
{
    int res = 0;
    for (int i = 0; i < M; i++)
    {
        int num = ReadData("Введите число: ");
        if (num > 0) res++;
    }
    return res;
}
