// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// // Заполняем массив
// int[] GenArray(int len, int minValue, int maxValue)
// {
//     Random rnd = new Random();
//     int[] arr = new int[len];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return arr;
// }

// //Печатает одномерный массив
// void Print1DArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.WriteLine(arr[arr.Length - 1]);
// }

// // Чтение данных из консоли
// int ReadData(string line)
// {
//     // Выводим сообщение
//     Console.WriteLine(line);
//     // Считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     // Возвращаем значение
//     return number;
// }


// // Печать результата
// void PrintData(string res, int value)
// {
//     Console.WriteLine(res + value);
// }

int[] array = GenArray(10, -9, 10);     //генерируем массив
Print1DArr(array);                      // печатаем сгенерированный массив
int num = ReadData("Введите число");    // получаем от пользователя число
int result = SearchElem(array, num);    // производим поиск числа в массиве

if (result >= 0)    // если мы нашли число в массиве
{
    PrintData("Элемент найден в позиции: " + result);   
}
else
{
    PrintData("В массиве элемент не найден!");
}


int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

int[] GenArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

int SearchElem(int[] arr, int elem)  // выдаем из массива индекс
{
    int res = -1;       
    for (int i = 0; i < arr.Length; i++)  //проходим по всему массиву
    {
        if (arr[i] == elem)     //если элемент масссива равен введенному элементу
        {
            res = i;            // тогда присваиваем ему это значене
            break;              // иначе прекращаем пересчет
        }
    }
    return res;                 // возвращаем значение
}