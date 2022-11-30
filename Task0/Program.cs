string? inputLine = Console.ReadLine(); //Считываем данные с консоли

if(inputLine!=null)  // Проверяем, чтобы данные были не пустыми

{
   // Парсим введенное число
   int inputNumber = int.Parse(inputLine);

   // Находим квадрат числа
   int outNumber = inputNumber*inputNumber;

   //Выводим данные на консоль
   Console.WriteLine(outNumber);
}
