// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// Метод читает данные от пользователя:
int ReadData(string line)
{
    Console.WriteLine(line); // выводит сообщение
   int numberP = int.Parse(Console.ReadLine()??"0"); //считываем число
   return numberP; //возвращаем значение
}

// Метод выводит результат
void PrinResult(string line, int[] arr)
{
    Console.WriteLine(line);
    PrintArray(arr);
}

//
int[] GenArr(int num)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i=0;i<arr.Length; i++)
    {
        arr[i] = rnd.Next(0,2);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i=0;i<arr.Length-1; i++) //Length-1 т,к последняя запятая не нужна
    {
    Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length-1] + "]");
}

int arrLen = ReadData("Введите длину массива: ");
int[] arr = GenArr(arrLen);
PrinResult("Сгенерированный массив: " , arr);

