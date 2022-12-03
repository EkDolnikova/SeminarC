// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

string? num1Line = Console.ReadLine(); // считываем данные с консоли
string? num2Line = Console.ReadLine();
string? num3Line = Console.ReadLine();

if (num1Line != null && num2Line != null && num3Line != null);  // проверяем, что не нулевые

int num1 = int.Parse(num1Line); // получаем действительные значения числа
int num2 = int.Parse(num2Line);
int num3 = int.Parse(num3Line);

if(num1 > num2)
{
    if (num1 > num3)
    {
        Console.WriteLine("Максимальное число:" + num1);
    }
    else
    {
        Console.WriteLine("Максимально число:" + num3);
    }

}
else if (num2 > num3)
    {
       
        Console.WriteLine("Максимально число:" + num2);
    }
else
{
    Console.WriteLine("Максимально число:" + num3);
}



