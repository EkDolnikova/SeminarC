// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

string? num1Line = Console.ReadLine(); // считываем данные с консоли
string? num2Line = Console.ReadLine();

if (num1Line != null && num2Line != null);  // проверяем, что не нулевые

int num1 = int.Parse(num1Line); // получаем действительные значения числа
int num2 = int.Parse(num2Line);

if(num1 > num2)
{
    Console.WriteLine("Да.первое число больше второго");
}
else
{
    Console.WriteLine("Нет.Второе число больше первого");
}
