// Напишите программу, которая выводит третью цифру заданного числа или сообщает,что третьей цифры нет.

int num = int.Parse(Console.ReadLine()??"0"); // считываем с консоли и парсим число
if(num!=null);  //проверяем, чтобы данные были не пустые
if(num>99)
{
    char[] digits = num.ToString().ToCharArray(); // превращаем число в массив
    Console.WriteLine(digits[2]);
}
else Console.WriteLine("Третьего числа нет");