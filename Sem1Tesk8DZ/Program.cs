// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

string? inputLine = Console.ReadLine(); //считываем дынные с консоли
if(inputLine!= null);  // проверяем, что данные не пустые
int inputNumber = int.Parse(inputLine); //делаем число вещественным

int even = 2; // потому, что нужны четные числа

string res = string.Empty; // т.е пустая строка

while (even <= inputNumber)
{
    res = res + even + ",";
    even = even + 2;
}

Console.WriteLine(res);

