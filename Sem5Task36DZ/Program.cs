// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = GenArray(5,-10,10);       
PrintArray(array);                     
Console.WriteLine();  
int result = SumElement (array);
Console.WriteLine();
PrintData("Сумма элементов, стоящих на нечетных позициях: ", result);


// генерируем массив, заполненный случайными числами
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

// печатаем сгенерированный массив
void PrintArray(int[] arr) 
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

// находим сумму элементов на нечетных позициях
int SumElement(int[] array)
{
    int sumPos = 0;       
    for (int i = 0; i < array.Length; i = i + 2)  
    {
        sumPos+= (array[i]);
    }
    return sumPos;
}

void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}
