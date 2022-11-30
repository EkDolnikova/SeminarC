// Напишите программу, котора на вход принимает одно число n, а на выходе показывает все целые числа в промежутке от -n до n

//считываем данные
string? inputLine = Console.ReadLine();

//проверяем, чтобы данные были не пустые
if(inputLine!=null)
{
    int inputNumber = int.Parse(inputLine); //парсим введенное число

    int startNumber = inputNumber*(-1);

     //выходное значение
      string outLine = string.Empty;

while(startNumber<inputNumber)
{
    outLine = outLine + startNumber + ", ";
    startNumber++; //равносильно startNumer=startNumer+1
}

outLine = outLine + inputNumber;

// выводим данные в консоль
Console.WriteLine(outLine);
}
