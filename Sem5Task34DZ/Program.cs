//Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.





int[] array = GenArray(50,100,999); //генерируем массив
Print1DArr(array);                  // печатаем сгенерированный массив
Console.WriteLine();                // разделяем строкой пустой
int result = CountEven(array);      // считаем четных чисел 
PrintData("Количество четных чисел в массиве: ", result);  // печатаем результат
Console.WriteLine();                // разделяем строкой пустой
int[] result1 = BubbleSort(array);       // генерируем масси с сортировкой
//PrintArray(result1);                     // печатаем конвертированный массив новый массив


PrintArray(BubbleSort(array));

//Генирируем массив со случайными числами
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

void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

// Вывод результата
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

// Подсчет кол-ва чётных чисел в массиве
int CountEven(int[] arr) // передаем массив
{
    int res = 0;                              //начинаем с 0
    for (int i = 0; i < arr.Length; i++)      // проходим по всем элементам массива
    {
        if (EvenTest(arr[i])) res++;
    }
    return res;
}

// Тест на четность числа
bool EvenTest(int res) 
{
    return (res % 2 == 0);  
}

//Метод сортировки пузырьком
// Каждый элемент массива сравнивается с последующим и если элемент[i] > элемент[i+1] происходит замена.
//Шаг 1 повторяется n-1 раз, где n — количество элементов в массиве.


int[] BubbleSort(int[] array)// передаем массив
{
    int[] outArray = array;
    int temp;                                   // задаем переменную, куда будем складывать значения
    for (int i = 0; i < outArray.Length; i++)   //проходим по всем элементам массива
    {
        for (int j = 0; j < outArray.Length - 1 - i; j++)  //количество элементов массива минус 1 и минус количество выполненных повторений основного цикла)
            {
            if (outArray[j] > outArray[j + 1]) //Если элемент массива с индексом j больше следующего за ним элемента
            {
                temp = outArray[j];             // то кладем в переменную его
                outArray[j] = outArray[j + 1];  // берем следующее значение
                outArray[j + 1] = temp;         // кладем его в переменную
            }
        }
    }
    return outArray;
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
