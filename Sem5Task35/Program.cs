// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99]

int[] array = GenArray(123,-100,100); //генерируем массив
PrintArray(array);      //печатаем сгенерированный массив
int result = CountElement(array,10,99); // считаем кол-во элементов от 10 до 99
Console.WriteLine();
PrintData("Количество элементов массива, значения которых лежат в отрезке [10,99] составляет: ", result);

int[] GenArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] outArray = new int[len];
    for (int i = 0; i < len; i++)
    {
        outArray[i] = new Random().Next(minValue, maxValue);
    }
    return outArray;
}

void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

void PrintArray(int[] arr) 
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}


int CountElement(int[] array, int min, int max) //принимаем массив и  мин и макс значения
{
    int res = 0;        // 
    for (int i = 0; i < array.Length; i++)  //проходим по всем элементам массива
    {
        if (array[i] > min && array[i] < max)   //если элемент массива больше мин и меньше макс, то
        {
            res++; // показываем колличество этих элементов
        }
    }
    return res;     // возвращаем значение
}