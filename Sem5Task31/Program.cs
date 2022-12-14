// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

{
    int posetivSum = 0;
    int negotivSum = 0;

    int[] testArr = GenArray(12, -9, 9); // заполняем массив
    NegotivPosetivSum(testArr); // передаем методу заполненный массив
    Print1DArr(testArr);
    PrintData("Сумма положительных чисел в массиве: ", posetivSum);
    PrintData("Сумма отрицательных чисел в массиве: ", negotivSum);

    int[] GenArray(int len, int minValue, int maxValue)
    {
        Random rnd = new Random(); // создаем рандомайзер
        int[] arr = new int[len];  // создаем массив
        for (int i = 0; i < arr.Length; i++) // проходим по массиву от мин до макс значения
        {
            arr[i] = new Random().Next(minValue, maxValue + 1);
        }
        return arr;
    }

    void PrintData(string res, int value)
    {
        Console.WriteLine(res + value);
    }

    void NegotivPosetivSum(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0) // усли элемент массива больше 0, то
            {
                posetivSum += arr[i];
            }
            else
            {
                negotivSum += arr[i];
            }
        }
    }

    // Метод печати одномерного массива
    void Print1DArr(int[] arr) // принимаем на вход массив
    {
        for (int i = 0; i < arr.Length - 1; i++) // пробегаемся по элементам массива
        {
            Console.Write(arr[i] + ", ");
        }
        Console.WriteLine(arr[arr.Length -1]); // выводим на печать
    }
} 
