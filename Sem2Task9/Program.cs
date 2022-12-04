// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// ВАРИАНТ 1

// Создаем экземпляр классов рандомайзер
System.Random numberSintezator = new System.Random();

//Получаем новое случайное число
int number = numberSintezator.Next(10,100);

//Выводим данные в консоли
Console.WriteLine(number);

//Получаем первое и второе число поотдельности
int firstNumber = number/10; //72  72/10=7.2. но тк int данные целочисленные, то отобразит только 7
int secondNumber = number%10; // 72 72%10=2 тк остаток от деления

//Сравниваем числа
if(firstNumber>secondNumber)
{
    //выводим данные в консоль
    Console.WriteLine(firstNumber);
}
else
{
   Console.WriteLine(secondNumber); 
}



//ВАРИАНТ 2
//char[] digit = numberSintezator.Next(10,100).ToString().ToCharArray();
//Console.WriteLine(digits);
//firstNumber = ((int)digits[0])-48;
//secondNumber = ((int)digits[1])-48;
//int resultNumber = firstNumber>secondNumber?resultNumber=firstNumber:resultNumber=secondNumber;
//Console.WriteLine(resultNumber);

//Вариант 3
//int[] indxAnsw = new int[90];
// далее необходимо заполнитиь большой массив данных