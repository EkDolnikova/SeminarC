// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

int num = int.Parse(Console.ReadLine()??"0");  // ??"0" - проверка на 0

int res1 = num%7; 
int res2 = num%23; 

if((res1==0)&&(res2==0)) //&& - и, // - или
{
Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

