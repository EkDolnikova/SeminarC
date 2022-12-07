﻿// Напишите программу, которая принимает на входкоординаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
//выдаёт номер четверти плоскости, в которой находится эта точка.

// (Этап 1) Вводим данные:
//Console.WriteLine("Введите координату x: ");
//int coordX = int.Parse(Console.ReadLine()??"0");
//Console.WriteLine("Введите координату y: ");
//int coordY = int.Parse(Console.ReadLine()??"0");


int coordX = ReadData("Введите координату x: ");
int coordY = ReadData("Введите координату y: ");
PrintQuterTest();

// Метод читает данные от пользователя:
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
// Метод определяет четверть по координатам
void PrintQuterTest()
{
    if(coordX>0 && coordY>0) Console.WriteLine("Точка в четверти 1");
    if(coordX>0 && coordY<0) Console.WriteLine("Точка в четверти 2");
    if(coordX<0 && coordY<0) Console.WriteLine("Точка в четверти 3");
    if(coordX<0 && coordY>0) Console.WriteLine("Точка в четверти 4");
}
