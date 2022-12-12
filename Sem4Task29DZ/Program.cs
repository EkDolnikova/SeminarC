// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// * Ввести с клавиатуры длину массива и диапазон значений элементов 

// Метод читает данные от пользователя:
int ReadData(string line)
{
    Console.WriteLine(line); // выводит сообщение
   int numberP = int.Parse(Console.ReadLine()??"0"); //считываем число
   return numberP; //возвращаем значение
}

// Метод вывода массива
void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i=0;i<arr.Length-1; i++) //Length-1 т,к последняя запятая не нужна
    {
    Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length-1] + "]");
}

int[] GenArr(int lenthArr, int numMin, int numMax)
{
        int[] randomArr = new int[lenthArr];
        Random rnd = new Random();
    for (int i=0;i<lenthArr; i++)
    {
        randomArr[i] = rnd.Next(numMin, numMax + 1);
    }
    return randomArr;
}

int lenthArr = ReadData("Введите длину массива: ");
int numMin = ReadData("Введите min значение: ");
int numMax = ReadData("Введите max значение: ");
//int[] arr = GenArr(arrLen);
PrintArray(GenArr(lenthArr,numMin,numMax));