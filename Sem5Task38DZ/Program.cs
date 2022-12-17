// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] array = FillArray(12,50); //генерируем массив
PrintArray(array);  //печатаем массив
double result = GetMaxMin(array);
PrintData(result);



// заполнение массива веществ. числами
double[] FillArray(int arrayLength, double max) 
{
    double[] array = new double[arrayLength];
    Random num = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((num.NextDouble() * max), 2);
    }
    return array;
}
// выводим массив
void PrintArray(double[] array) 
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

// вывод результата вычисления
void PrintData(double diffMaxMin) 
{
    Console.WriteLine("Разница между максимальным и минимальным элементами: " + Math.Round (diffMaxMin, 2));
}

//вычисляем максимальный и минимальный элементы массива
double GetMaxMin(double[] array)
{
    double max = int.MinValue;
    double min = int.MaxValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return (max - min);
}


