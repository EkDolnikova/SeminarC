﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int num = int.Parse(Console.ReadLine()??"0"); // считываем с консоли и парсим число
if(num!=null)  //проверяем, чтобы данные были не пустые
if(num<1000&&num>99)
{
    int res = (num / 10) % 10;
    Console.WriteLine(res);
}
else Console.WriteLine("Введите трехзначное число");