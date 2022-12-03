// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// % - целочисленное деление

string? inputLine = Console.ReadLine(); // считываем данные в стороковом виде

if(inputLine!=null)  //проверяем, чтобы данные были не пустые

{ 
int inputNumber = int.Parse(inputLine); //превращает число в цизический вид
int lestDigit = inputNumber % 10; // остаток от деления
Console.WriteLine(lestDigit); // выводим сообщение
}

