//Программа, которая на вход принимает 2 числа и проверяет, является ли первое число квадратом второго.

//Вводим строковые значения, считываем данные с консоли
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();

if (num1Line != null && num2Line != null);  

{
// Парсим введенное число
   int num1 = int.Parse(num1Line);
   int num2 = int.Parse(num2Line);

   if (num2 * num2 == num1)
   {
    Console.WriteLine("Да.первое число квадрат второго");
   }
   else
   {
    Console.WriteLine("Нет,первое число не квадрат второго");
   }
}
