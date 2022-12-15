// Напишите программу замена элементов массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.

int[] array = GenArray(10,-9,9);    // генерируем массив(10 значений от -9 до 9)
    Print1DArr(array);              // печатаем этот массив
    int[] newArray = InverseArr(array);   // получаем новый преобразованный массив
    Print1DArr(newArray);       // печатаем новый массив

    // Генерируем(запоняем) массив
    int[] GenArray(int len, int minValue, int maxValue)
    {
        Random rnd = new Random();
        int[] arr = new int[len];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(minValue, maxValue + 1);
        }
        return arr;
    }
    //Печатает одномерный массив
    void Print1DArr(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.WriteLine(arr[arr.Length - 1]);
    }

    //Преобразовываем массив
    int[] InverseArr(int[] arr)   //принимает и возвращает массив
    {
        int[] outArr = new int[arr.Length]; // указываем как параметр длину массива
        for(int i=0;i<arr.Length;i++)  // проходим по элементам массива
        {
            outArr[i]=arr[i]*(-1);     // каждый элемент массива умножаем на "-1"
        }
        return outArr;                  // Возвращаем значение
    }